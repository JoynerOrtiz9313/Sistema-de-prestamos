using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Menu_Principal.Forms
{
    public partial class Pagos : Form
    {

        Conexion DB;
        Prestamo EstePrestamo;
        decimal montoPrestamo = 0;
        decimal _PorcentajePrestamo = 0;

        public Pagos()
        {
            InitializeComponent();

        }

        public void Pagosc (string _idcliente){
            TBCliente.Text = _idcliente.ToString();
            TBCliente_Leave(null, null);   
        }

        private void TBCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                Conexion DB = new Conexion();

                LblnombreCliente.Text =
                    DB.GetData("Select nombre from tbl_clientes where id_clientes = " +
                    TBCliente.Text).Rows[0][0].ToString();

                string Query =
                    string.Format("exec SP_TraerPrestamos_Cliente {0}",TBCliente.Text);
                /*
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add("@cliente", SqlDbType.Int).Value = TBCliente.Text;
                */
                DataTable dt = DB.GetData(Query);


                if (dt.Rows.Count > 0)
                    GridPagos.DataSource = DB.GetData(Query);
                else
                {
                    MessageBox.Show("No se encontro informacion de cliente",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    GridPagos.DataSource = dt;
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            
        }

        private void GridPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int IDPrest = int.Parse(GridPagos.Rows[e.RowIndex].Cells[0].Value.ToString());
                decimal totalPagos = 0;
                DB = new Conexion();

                EstePrestamo = new Prestamo();

                if (EstePrestamo.Fill(IDPrest))
                {
                    Pago p = new Pago();
                    totalPagos = p.GetTotalPagos(IDPrest);

                    montoPrestamo = Convert.ToDecimal(GridPagos.Rows[e.RowIndex].Cells["Monto"].Value.ToString());
                    TBCuota.Text = EstePrestamo.getCouta().ToString();
                    //-- //GridPagos.Rows[e.RowIndex].Cells["Cuota"].Value.ToString();

                    TBMontoInteres.Text = EstePrestamo.GetMontoInteres().ToString();

                    TBIDPrestamo.Text = EstePrestamo.ID_Prestamo.ToString();
                    TBFechaPrestamo.Text = EstePrestamo.Fecha.ToString();
                    try
                    {
                        TBFechafin.Text = EstePrestamo.GetFechaFin().ToString();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Error calculando Fecha fin " + es.Message);
                    }

                    TBBalancePendiente.Text = EstePrestamo.GetBalancePendiente().ToString();
                    TBMora.Text = EstePrestamo.GetMora().ToString();

                    if (EstePrestamo.LineaCredito)
                    {
                        TBTotalPago.Text = TBCuota.Text;
                    }
                    else
                    {
                        TBTotalPago.Text = (decimal.Parse(TBCuota.Text) + EstePrestamo.GetMora()).ToString();
                    }
                    string Query = "select porcentaje from taza t join tbl_prestamos p on " +
                      " p.taza = t.id_taza where p.id_prestamo = " + TBIDPrestamo.Text;

                    _PorcentajePrestamo = decimal.Parse(DB.GetData(Query).Rows[0]["porcentaje"].ToString());

                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void TBFechafin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TBCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TBCliente.Text.Contains("'") ||
                    TBCliente.Text.Contains("#") ||
                    TBCliente.Text.Contains(";"))
                    TBCliente.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CmdRegistrarPago_Click(object sender, EventArgs e)
        {

            try
            {
                Pago p = new Pago();

                if (ChkPagoAdelantado.Checked)
                    p.Fecha = DtFechaPagoAdelantado.Value;
                else
                    p.Fecha = DateTime.Now;

                p.Interes = decimal.Parse(TBMontoInteres.Text);
                p.Monto = decimal.Parse(TBCuota.Text);

                if (ChkPagoAdelantado.Checked || ChkSaltarMora.Checked)
                    p.Mora = 0;
                else
                    p.Mora = decimal.Parse(TBMora.Text);


                p.ID_Prestamo = EstePrestamo.ID_Prestamo;
                
                p.Save();
                MessageBox.Show("Pago efectuado satisfactoriamente!", "Pago procesado!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

                DB = new Conexion();
                SqlCommand _cmd = new SqlCommand();
                _cmd.Parameters.Add("@id_Prestamo",SqlDbType.Int).Value = EstePrestamo.ID_Prestamo;
                _cmd.Parameters.Add("@dias_frecuencia",SqlDbType.Int).Value = EstePrestamo.GetDiasFrecuencia();
                DB.ExecuteCMD("exec SP_Act_Prestamos_Pagados",_cmd);

            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        void Limpiar()
        {

            try
            {
                TBCliente.Text = "";
                TBBalancePendiente.Text = "";
                TBCuota.Text = "";
                TBIDPrestamo.Text = 0.ToString();
                TBMontoInteres.Text = "";
                TBMora.Text = "";
                TBTotalPago.Text = "";

                ChkPagoAdelantado.Checked = false;
                DtFechaPagoAdelantado.Value = DateTime.Now.Date;

                LblnombreCliente.Text = "-";
                GridPagos.Rows.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EstePrestamo != null)
                if (EstePrestamo.Exist(EstePrestamo.ID_Prestamo))
                {
                    Frm_Plan_De_Pago frm = new Frm_Plan_De_Pago(EstePrestamo.ID_Prestamo.ToString(),
                        montoPrestamo.ToString(), LblnombreCliente.Text,
                        TBBalancePendiente.Text, _PorcentajePrestamo.ToString());
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("No tiene ningún prestamo seleccionado!", "Seleccione un prestamo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

        }

        private void ChkPagoAdelantado_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPagoAdelantado.Checked)
            {
                try
                {
                    if (Convert.ToDecimal(TBMora.Text) > 0)
                    {
                        MessageBox.Show("Tienes Mora que pagar, no puedes efectuar pagos por padelantado",
                            "Primero debe ponerse al día", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        ChkPagoAdelantado.Checked = false;
                        return;
                    }
                    if (EstePrestamo.ID_Prestamo > 0)
                    {
                        DtFechaPagoAdelantado.Value = EstePrestamo.GetSiguienteFechaPago(false);
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ChkSaltarMora_CheckedChanged(object sender, EventArgs e)
        {
            //if(ChkSaltarMora.Checked)

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TBMontoInteres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCuota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
