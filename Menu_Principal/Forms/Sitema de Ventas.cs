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
    public partial class Sitema_de_Ventas : Form
    {
        public Sitema_de_Ventas()
        {
            InitializeComponent();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Facturacion frm = new Forms.Facturacion();
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Productos frm = new Forms.Productos();
            frm.Show();
        }

        private void mercanciaRecibidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.MR frm = new Forms.MR();
            frm.Show();
        }
    }
}
