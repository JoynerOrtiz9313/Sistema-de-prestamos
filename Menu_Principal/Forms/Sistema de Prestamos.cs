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

    public partial class Sistema_de_Prestamos : Form
    {
        public Sistema_de_Prestamos()
        {
            InitializeComponent();
        }

        Conexion DB = new Conexion();


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Clientes frm = new Forms.Clientes();
            frm.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPrestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Prestamos frm = new Forms.Prestamos();
            frm.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Pagos frm = new Forms.Pagos();
            frm.Show();
        }

        private void tazasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.Mant_Taza FRM = new Forms.Mant_Taza();
                FRM.ShowDialog();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.Mant_Socios FRM = new Forms.Mant_Socios();
                FRM.ShowDialog();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Reporte_Ganancias Frm = new Forms.Reporte_Ganancias();
            Frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Forms.Pagos frm = new Forms.Pagos();
                
            frm.Pagosc(GridPagosP.Rows[e.RowIndex].Cells[1].Value.ToString());
            frm.Show();
            
        }



        private void Sistema_de_Prestamos_Load(object sender, EventArgs e)
        {
            try
            {
                GridPagosP.DataSource = DB.GetData("select c.Id_Clientes,p.id_Prestamo,c.Cedula,c.Nombre,c.Apellido,p.Monto,  case (select count(id_cuota) from Cuotas ) when  '0'  then cast ((datediff((d),p.Fecha,GETDATE())/f.dias) as decimal)  else cast ((datediff((d),cu.Fecha,GETDATE())/f.dias) as decimal) end  as Cuotas_Atrasadas from tbl_prestamos  p JOIN taza t on t.id_taza = p.taza join TBL_Clientes c on p.Id_Cliente=c.Id_Clientes join TBL_Frecuencia f on p.Frecuencia=f.Id_Frecuencia join Cuotas cu on p.Id_Prestamo=cu.ID_Prestamo");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.RClientes frm = new Reportes.RClientes();
            frm.Show();
        }
    }
}
