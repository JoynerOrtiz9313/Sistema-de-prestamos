
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void TBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Conexion con = new Conexion();
                DataTable table = new DataTable();
                table = con.GetData("Select * from TBL_Clientes where Id_Clientes = " + TBCliente.Text + "");

                TBNombre.Text = table.Rows[0]["nombre"].ToString();
                TBApellido.Text = table.Rows[0]["apellido"].ToString();
                TBCedula.Text = table.Rows[0]["cedula"].ToString();
                TBTelefono.Text = table.Rows[0]["telefono"].ToString();
                TBDireccion.Text = table.Rows[0]["direccion"].ToString();

            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            Conexion DB = new Conexion();


            try
            {
                string Query = "Insert into TBL_Clientes (Nombre,Apellido,Cedula,Telefono,Direccion) values (('" + TBNombre.Text + "'),('" + TBApellido.Text + "'),('" + TBCedula.Text + "'),('" + TBTelefono.Text + "'),('" + TBDireccion.Text + "'))";
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
            table = con.GetData("Select count(id_clientes)+1 as 'conteo' from TBL_Clientes");

            TBCliente.Text = table.Rows[0]["conteo"].ToString();

            TBNombre.Text = "";
            TBApellido.Text = "";
            TBCedula.Text = "";
            TBTelefono.Text = "";
            TBDireccion.Text = "";

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            DataTable table = new DataTable();
            table = con.GetData("Select count(id_clientes)+1 as 'conteo' from TBL_Clientes");

            TBCliente.Text = table.Rows[0]["conteo"].ToString();

            TBNombre.Text = "";
            TBApellido.Text = "";
            TBCedula.Text = "";
            TBTelefono.Text = "";
            TBDireccion.Text = "";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion DB = new Conexion();


            try
            {
                string Query = "Insert into TBL_Clientes (Nombre,Apellido,Cedula,Telefono,Direccion) values (('" +
                    TBNombre.Text.Replace("'", "").Replace("#", "").Replace("{", "")
                    + "'),('" + TBApellido.Text.Replace("'", "").Replace("#", "").Replace("{", "")+"'),('" +
                    TBCedula.Text.Replace("'", "").Replace("#", "").Replace("{", "") + "'),('" +
                    TBTelefono.Text.Replace("'", "").Replace("#", "").Replace("{", "") + "'),('" +
                    TBDireccion.Text.Replace("'", "").Replace("#", "").Replace("{", "") + "'))";

                DB.ExecuteCMD(Query);

                MessageBox.Show("Cliente Registrado!", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception es)
            {

                throw es;

            }
        }

    }
}
