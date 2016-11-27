
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
    public partial class Productos : Form
    { 
        public Productos()
        {
            InitializeComponent();
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Conexion con = new Conexion();
                DataTable table = new DataTable();
                table = con.GetData("Select Descripcion,Costo,Precioventa,(((Precioventa-Costo)/Costo)*100) as ganancia  from TBL_Productos where Id_Producto = " + TBCodigo.Text + "");

                TBDesc.Text = table.Rows[0]["Descripcion"].ToString();
                TBCosto.Text = table.Rows[0]["Costo"].ToString();
                TBPreciov.Text = table.Rows[0]["Precioventa"].ToString();
                TBGanancia.Text = table.Rows[0]["ganancia"].ToString();
                
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToString("G");
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            Conexion DB = new Conexion();


            try
            {
                string Query = "Insert into TBL_Productos (Fecha,Descripcion,Costo,Precioventa) values (('" + lbFecha.Text + "'),('" + TBDesc.Text + "'),('" + TBCosto.Text + "'),('" + TBPreciov.Text + "'))";
                DB.ExecuteCMD(Query);



            }
            catch (Exception es)
            {

                throw es;

            }
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            DataTable table = new DataTable();
            table = con.GetData("Select count(id_Producto)+1 as 'conteo' from TBL_productos");

            TBCodigo.Text = table.Rows[0]["conteo"].ToString();

            lbFecha.Text = "";
            TBDesc.Text = "";
            TBCosto.Text = "";
            TBPreciov.Text = "";
            lbFecha.Text = DateTime.Now.ToString("G");
           
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            DataTable table = new DataTable();
            table = con.GetData("Select count(id_Producto)+1 as 'conteo' from TBL_productos");

            TBCodigo.Text = table.Rows[0]["conteo"].ToString();

            lbFecha.Text = "";
            TBDesc.Text = "";
            TBCosto.Text = "";
            TBPreciov.Text = "";
            lbFecha.Text = DateTime.Now.ToString("G");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion DB = new Conexion();


            try
            {
                string Query = "Insert into TBL_Productos (Fecha,Descripcion,Costo,Precioventa) values (('" + lbFecha.Text + "'),('" + TBDesc.Text + "'),('" + TBCosto.Text + "'),('" + TBPreciov.Text + "'))";
                DB.ExecuteCMD(Query);



            }
            catch (Exception es)
            {

                throw es;

            }
        }
    }
}
