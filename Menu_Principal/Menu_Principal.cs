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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void BPrestamos_Click(object sender, EventArgs e)
        {
            Sistema_de_Prestamos frm = new Sistema_de_Prestamos();
            frm.Show();
            
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            Forms.Sitema_de_Ventas frm = new Forms.Sitema_de_Ventas();
                            frm.Show();
        }
    }
}
