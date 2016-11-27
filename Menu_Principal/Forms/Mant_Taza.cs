
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Principal.Forms
{
    public partial class Mant_Taza : Form
    {
        Conexion DB;

        public Mant_Taza()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar_Pantalla();
                tabControl1.SelectTab(1);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Limpiar_Pantalla()
        {
            TxtIDTaza.Text = "";
            TxtPorcentaje.Text = "";

            Act_Grid();
            tabControl1.SelectTab(0);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtPorcentaje.Text.Trim() == "")
                return;

            var porcentaje = Convert.ToDecimal(TxtPorcentaje.Text) / 100;
            var Query = "";
            try
            {
                if (DB.GetData("Select porcentaje from taza where porcentaje = " +
                    porcentaje.ToString()).Rows.Count <= 0)
                {
                    Query = "Insert into taza (porcentaje) values (@porcentaje)";
                }
                else
                {
                    MessageBox.Show("Ya existe un porcentaje similar almacenado, favor inserte un porcentaje diferente", "Existe registro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Limpiar_Pantalla();
                    return;
                }


                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = Query;
                cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = Convert.ToDecimal(TxtPorcentaje.Text) / 100;
                con.ExecuteCMD(Query, cmd);
                MessageBox.Show("Registro Insertado");
                Limpiar_Pantalla();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void TxtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(TxtPorcentaje.Text);
            }
            catch (Exception)
            {
                TxtPorcentaje.Text = "";
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (TxtIDTaza.Text == "")
            {
                MessageBox.Show("No hay Registro para eliminar!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                try
                {
                    DB.ExecuteCMD("Delete from taza where ID_Taza = " + TxtIDTaza.Text);
                    MessageBox.Show("Registro eliminado con éxito", "Eliminado!",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception es)
                {

                    MessageBox.Show(es.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Mant_Taza_Load(object sender, EventArgs e)
        {
            try
            {
                Act_Grid();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        void Act_Grid()
        {
            DB = new Conexion();
            GridTazas.DataSource = DB.GetData("select * from taza");
        }

        private void GridTazas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIDTaza.Text = GridTazas.Rows[e.RowIndex].Cells["ID_Taza"].Value.ToString();
                TxtPorcentaje.Text = (Convert.ToDecimal(
                    GridTazas.Rows[e.RowIndex].Cells["Porcentaje"].Value.ToString()) * 100).ToString();

                tabControl1.SelectTab(1);
            }
            catch (Exception)
            {

            }
        }
    }
}
