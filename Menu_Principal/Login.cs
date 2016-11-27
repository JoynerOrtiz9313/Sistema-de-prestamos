
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Principal
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }
        Conexion con = new Conexion();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?",
              "Salir",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();


                DataTable table = new DataTable();
                table = con.GetData("Select count(*) from TBL_Usuarios where usuario = '" + TBUsuario.Text + "'and Contraseña ='" + TBPass.Text + "'");
          
                if (table.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Menu_Principal frm = new Menu_Principal();
                    frm.Show();

                }

                else
                    MessageBox.Show("Usuario o Contraseña Incorrecta");


            }
        



    }
}
