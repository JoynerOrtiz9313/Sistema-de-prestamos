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
    public partial class Reporte_Ganancias : Form
    {
        Conexion DB;

        public Reporte_Ganancias()
        {
            InitializeComponent();
        }

        private void CmdCargarGrid_Click(object sender, EventArgs e)
        {

            DB = new Conexion();
            try
            {
                if (CmbTipo.Text == "Detalle")
                {
                    var Query = "";
                    if (CmbSocios.Text.Trim() == "")

                        Query = string.Format("SP_Traer_Ganancias_Detalle_Mes {0}", CmbMes.SelectedIndex + 1);
                    else
                        Query = string.Format("SP_Traer_Ganancias_Detalle_Mes_Socio {0}, '{1}'",
                            CmbMes.SelectedIndex + 1, CmbSocios.Text);

                    GridGanancias.DataSource = DB.GetData(Query);

                }
                else
                {

                    var Query = "";
                    if (CmbSocios.Text.Trim() == "")

                        Query = string.Format("SP_Traer_Ganancias_Global_Mes {0}", CmbMes.SelectedIndex + 1);
                    else
                        Query = string.Format("SP_Traer_Ganancias_Global_Mes_Socio {0}, '{1}'",
                            CmbMes.SelectedIndex + 1, CmbSocios.Text);

                    GridGanancias.DataSource = DB.GetData(Query);

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Reporte_Ganancias_Load(object sender, EventArgs e)
        {


        }

        private void CmbSocios_Click(object sender, EventArgs e)
        {
            DB = new Conexion();
            try
            {
                CmbSocios.DataSource = DB.GetData("Select Nombre from socios");
                CmbSocios.DisplayMember = "Nombre";
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                CmbSocios.DataSource = null;
                CmbSocios.Items.Clear();
                GridGanancias.Rows.Clear();
            }
            catch (Exception es) {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
