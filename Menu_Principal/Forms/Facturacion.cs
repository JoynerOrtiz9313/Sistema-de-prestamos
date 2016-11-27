
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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Conexion con = new Conexion();
                DataTable table = new DataTable();
                table = con.GetData("Select * from TBL_Productos where Id_Producto = " + TBCodigo.Text + "");

                TBDescip.Text = table.Rows[0]["Descripcion"].ToString();
                TBPrecio.Text = table.Rows[0]["PrecioVenta"].ToString();
                
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

       }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Rows.Add(TBCodigo.Text, TBDescip.Text, TBPrecio.Text, TBCantidad.Text);
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

        } 
    }
}
