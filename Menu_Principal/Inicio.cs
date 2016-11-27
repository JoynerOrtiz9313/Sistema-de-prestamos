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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 3000;
         
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Hide();
             Login frm = new Login();
            frm.Show();
        }

        
    }
}
