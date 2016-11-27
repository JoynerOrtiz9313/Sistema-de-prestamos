using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Principal.Forms
{
    public partial class Mant_Socios : Form
    {
        Conexion DB;

        public Mant_Socios()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Socio socio = new Class.Socio();
            try
            {

                socio.Cedula = TxtCedulaSocio.Text;
                socio.Nombre = TxtNombreSocio.Text;
                socio.Telefono1 = TxtTelefono1.Text;
                socio.Telefono2 = TxtTelefono2.Text;
                socio.Direccion = TxtDireccion.Text;

                if (socio.Save())
                    MessageBox.Show("Registro Afectado con éxito", "Cambio realizado!",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cambio NO completado", "Cambio RECHAZADO!",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Limpiar_Pantalla();
            }
        }

        void Limpiar_Pantalla()
        {

            TxtCedulaSocio.Text = "";
            TxtNombreSocio.Text = "";
            TxtTelefono1.Text = "";
            TxtTelefono2.Text = "";
            TxtDireccion.Text = "";

            RefreshGrid();
            tabControl1.SelectTab(0);
        }

        void RefreshGrid()
        {

            try
            {
                DB = new Conexion();
                GridSocios.DataSource = DB.GetData("SELECT * From Socios");
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtCedulaSocio.Text = "";
                TxtNombreSocio.Text = "";
                TxtTelefono1.Text = "";
                TxtTelefono2.Text = "";
                TxtDireccion.Text = "";

                tabControl1.SelectTab(1);
                TxtCedulaSocio.Focus();
            }
            catch (Exception)
            { }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtCedulaSocio.Text != "")
            {
                try
                {
                    DB = new Conexion();
                    if (DB.ExecuteCMD("Select * from Socios where cedula = '" +
                        TxtCedulaSocio.Text + "'"))
                    {
                        DB.ExecuteCMD("DELETE FROM Socios where cedula = '" + TxtCedulaSocio.Text + "'");

                        MessageBox.Show("Propietario de la cedula \"" + TxtCedulaSocio.Text +
                            "\" fue Eliminado!", "Tarea Ejecutada!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Inesperado!", "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }

                    Limpiar_Pantalla();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message, "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                }

            }
        }

        private void Mant_Socios_Load(object sender, EventArgs e)
        {
            Limpiar_Pantalla();
        }

        private void GridSocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Class.Socio socio = new Class.Socio();

                if (socio.Fill(GridSocios.Rows[e.RowIndex].Cells["Cedula"].Value.ToString()))
                {

                    TxtCedulaSocio.Text = socio.Cedula;
                    TxtNombreSocio.Text = socio.Nombre;
                    TxtTelefono1.Text = socio.Telefono1;
                    TxtTelefono2.Text = socio.Telefono2;
                    TxtDireccion.Text = socio.Direccion;

                    tabControl1.SelectTab(1);

                }

            }
            catch (Exception)
            {

            }
        }

        private void TxtTelefono1_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtTelefono1.Text = string.Format("{0} {1} {2}",
                    TxtTelefono1.Text.Substring(0,3),
                    TxtTelefono1.Text.Substring(3, 3),
                    TxtTelefono1.Text.Substring(6, TxtTelefono1.Text.Length - 6));
            }
            catch (Exception)
            {
                //TxtTelefono1.Text = "";
            }
        }

        private void TxtTelefono2_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtTelefono2.Text = string.Format("{0} {1} {2}",
                    TxtTelefono2.Text.Substring(0, 3),
                    TxtTelefono2.Text.Substring(3, 3),
                    TxtTelefono2.Text.Substring(6, TxtTelefono2.Text.Length - 6));
            }
            catch (Exception)
            {
                //TxtTelefono1.Text = "";
            }
        }


    }
}
