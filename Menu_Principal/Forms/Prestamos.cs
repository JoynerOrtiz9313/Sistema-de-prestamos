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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }
        Conexion DB;
        int IDCliente = 0;
        decimal totalApagar = 0;

        private void TxtCedulaCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                DB = new Conexion();
                DataTable dt = new DataTable();
                dt = DB.GetData("Select Nombre,id_clientes from tbl_clientes where cedula = '" + TxtCedulaCliente.Text.Replace("'", "") + "'");
                LblnombreCliente.Text = dt.Rows[0][0].ToString();
                IDCliente = Convert.ToInt16(dt.Rows[0][1].ToString());
                //TxtCedulaCliente.Text = String.Format("{0:0.00}", TxtCedulaCliente.Text);
            }
            catch (Exception) { }
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        void LlenarCombos()
        {

            DB = new Conexion();
            //---------------------------------------------------
            DataTable dt = DB.GetData("Select * From Taza");

            CmbTaza.DataSource = new BindingSource(dt, null);
            CmbTaza.DisplayMember = "Porcentaje";
            CmbTaza.ValueMember = "ID_Taza";

            //---------------------------------------------------
            dt = DB.GetData("Select * From tbl_frecuencia");

            CmbFrecuencia.DataSource = new BindingSource(dt, null);
            CmbFrecuencia.DisplayMember = "Frecuencia";
            CmbFrecuencia.ValueMember = "ID_Frecuencia";

            #region//-------------------socios--------------------------------
            /*dt = DB.GetData("Select Nombre,Cedula From Socios");

            CmbSocio.DataSource = new BindingSource(dt, null);
            CmbSocio.DisplayMember = "Nombre";
            CmbSocio.ValueMember = "Cedula";

            */
            #endregion//---------------------------------------------------

            dt = DB.GetData("Select * From tbl_tipos_prestamos");

            CmbTipo.DataSource = new BindingSource(dt, null);
            CmbTipo.DisplayMember = "Descripcion";
            CmbTipo.ValueMember = "ID_Tiposp";
            //---------------------------------------------------
            dt = DB.GetData("Select * From tbl_cobradores");

            CmbCobrador.DataSource = new BindingSource(dt, null);
            CmbCobrador.DisplayMember = "Nombre";
            CmbCobrador.ValueMember = "id_Cobradores";
            //---------------------------------------------------

        }

        void CalcMontoCuotas()
        {

            if (TxtMonto.Text == "" ||
                TxtCantCuotas.Text == "" ||
                CmbTaza.Text == "" ||
                CmbFrecuencia.Text == "") { return; }
            try
            {
                var Monto = Convert.ToDecimal(TxtMonto.Text);
                var Taza = Convert.ToDecimal(CmbTaza.Text);
                var CantCuotas = Convert.ToDecimal(TxtCantCuotas.Text);

                decimal MontoTotal = 0;

                if (ChkPorFrecuencia.Checked)
                    MontoTotal = Monto + ((Monto * Taza) * CantCuotas);
                else
                    MontoTotal = Monto + (Monto * Taza);

                var pagos = CalcularPagos(Monto, Taza, CantCuotas, Chk_Amortizar.Checked);

                TxtMontoTotal.Text = pagos.Sum(p => p.Monto + p.Interes).ToString();
                TxtmontoCuotas.Text = (pagos.Sum(p => p.Monto + p.Interes) / CantCuotas).ToString();

                CalcularFechaFinal();
                //LstPagos.Items.Clear();
                //var pagos = CalcularPagos(Monto, Taza, CantCuotas, Chk_Amortizar.Checked);


            }
            catch (Exception) { }


        }


        List<Pago> CalcularPagos(decimal _Monto, decimal _taza, decimal _cuotas,
                        bool _amortizar)
        {

            List<Pago> Pagos = new List<Pago>();
            decimal MontoTotal = 0;
            decimal _Cuota_Interes;
            decimal _Cuota_Capital;
            DateTime fechaCuota = DateTime.Now;
            var _MontoInteres = (_Monto * _taza);

            try
            {
                _Cuota_Capital = _Monto / _cuotas;
                _Cuota_Interes = (_Monto * _taza);
                var _CuotaTotal = _Cuota_Capital + _Cuota_Interes;

                var DiasFrecuencia = Convert.ToInt32(DB.GetData(
                   "Select Dias from tbl_frecuencia where id_frecuencia = '" +
                   CmbFrecuencia.SelectedValue.ToString() + "'").Rows[0][0].ToString());

                MontoTotal = _Monto;
                fechaCuota = DtFechaInicio.Value;
                var EsMensual = CmbFrecuencia.Text.ToLower().Trim() == "mensual" ? true : false;

                var cuotasPendientes = _cuotas;

                while (MontoTotal > 0)
                {
                    Pago _p = new Pago();
                    _p.Monto = MontoTotal /cuotasPendientes;  //SOLO EN ESTE CASO EL MONTO DEL PAGO HACE REFERENCIA AL MONTO CAPITAL
                    _p.Interes = _Cuota_Interes;
                    _p.Mora = 0;

                    if (!EsMensual)
                        fechaCuota = fechaCuota.AddDays(DiasFrecuencia);
                    else
                        fechaCuota = fechaCuota.AddMonths(1);

                    _p.Fecha = fechaCuota;

                    _Cuota_Capital = MontoTotal / cuotasPendientes;
                    MontoTotal -= _Cuota_Capital;

                    if (_amortizar)
                    {
                        _Cuota_Interes = (MontoTotal * _taza);
                    }
                    Pagos.Add(_p);
                    cuotasPendientes -= 1;
                }

            }
            catch (Exception es)
            {
                MessageBox.Show("Error calculando los pagos " + es.Message
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Pagos;


        }

        private void tazasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Mant_Taza frm = new Mant_Taza();
            frm.Show();
        }

        private void TxtMonto_Leave(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

        private void TxtCantCuotas_Leave(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

        private void CmbTaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

        private void CmbFrecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            CalcMontoCuotas();
        }

        private void CmbCobrador_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(TxtMonto.Text);
            }
            catch (Exception)
            {
                TxtMonto.Text = "";
            }
        }

        private void TxtCantCuotas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(TxtCantCuotas.Text);
            }
            catch (Exception)
            {
                TxtCantCuotas.Text = "";
            }
        }

        private void TxtCedulaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        void CalcularFechaFinal()
        {

            DB = new Conexion();
            try
            {
                var DiasFrecuencia = Convert.ToDecimal(DB.GetData(
                    "Select Dias from tbl_frecuencia where id_frecuencia = '" +
                    CmbFrecuencia.SelectedValue.ToString() + "'").Rows[0][0].ToString());

                var fechaPrimerPago = DateTime.Now;


                for (DateTime i = DateTime.Now; i.Day-1 != TxtDiaCobro.Value; i = i.AddDays(1))
                {
                    if (i.Day == TxtDiaCobro2.Value)
                    {
                        fechaPrimerPago = i;
                        break;
                    }

                    fechaPrimerPago = i;
                }


                var CantCuotas = Convert.ToInt16(TxtCantCuotas.Text);
                var fechaInicio = DtFechaInicio.Value;

                var DiasPrestamo = (DiasFrecuencia * CantCuotas);

                if (CmbFrecuencia.Text == "Diario")
                    DiasPrestamo += DiasPrestamo > 7 ? Math.Round(((DiasPrestamo / 30) * 4)) : 0;

                var fechaFinal = fechaPrimerPago.AddDays(Convert.ToInt32(DiasPrestamo));

                for (DateTime i = fechaFinal; i.Day-1 != TxtDiaCobro.Value; i = i.AddDays(1))
                {
                    if (i.Day == TxtDiaCobro2.Value)
                    {
                        fechaFinal = i;
                        break;
                    }

                    fechaFinal = i;
                }

                dtFechaFin.Value = fechaFinal;

            }
            catch (Exception es)
            {
                MessageBox.Show("Error Calculando la fecha final" + es.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamo prest = new Prestamo();
            DB = new Conexion();
            int _IDPrestamo = 0;

            #region Socios comentado
            /*
            if (Porcentaje_Socios() != 100)
            {
                MessageBox.Show("No has alcanzado el 100% en el reparto de beneficios. \nFavor completar.",
                    "100% No alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
            #endregion

            try
            {

                var MtCuota = decimal.Parse(TxtmontoCuotas.Text);

                prest.Fill(IDCliente,
                    Convert.ToInt16(CmbTipo.SelectedValue),
                    Convert.ToInt16(CmbFrecuencia.SelectedValue),
                    Convert.ToInt16(CmbCobrador.SelectedValue),
                    Convert.ToInt16(CmbTaza.SelectedValue),
                    TxtGarantia.Text,
                    Convert.ToDecimal(TxtMonto.Text),
                    Convert.ToInt16(TxtCantCuotas.Text),
                    DtFechaInicio.Value,
                    Chk_Amortizar.Checked, false,
                    ChkLineaDeCredito.Checked,
                    MtCuota,
                    Convert.ToInt32(TxtDiaCobro.Value),
                    Convert.ToInt32(TxtDiaCobro2.Value));

                if (prest.Save())
                {

                    DB = new Conexion();

                    _IDPrestamo = int.Parse(DB.GetData("Select max(id_Prestamo) as id from TBL_Prestamos")
                                        .Rows[0]["id"].ToString());
                    /*
                    foreach (ListViewItem item in LstSociosPrestamo.Items)
                    {

                        var _Cedula = item.SubItems[0].Text;
                        var _Porcentaje = (Convert.ToDecimal(item.SubItems[2]
                            .Text
                            .Replace("%", "")) / 100).ToString();

                        DB.ExecuteCMD("INSERT INTO Ganancia_Socios (Prestamo,Socio,Porcentaje) " +
                                       " values (" + _IDPrestamo +
                                       ",'" + _Cedula +
                                       "'," + _Porcentaje + ")");

                    }*/

                    MessageBox.Show("Done!", "Guardado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al guardar prestamo!", "No Guardado",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show(string.Format("Error al guardar prestamo! \n{0}",
                    es.Message),
                    "No Guardado",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

                if (_IDPrestamo != 0)
                {
                    try
                    {
                        DB.ExecuteCMD("DELETE FROM Ganancia_socios where prestamo = " + _IDPrestamo.ToString());
                        DB.ExecuteCMD("DELETE FROM tbl_Prestamos where id_prestamo = " + _IDPrestamo.ToString());

                        MessageBox.Show("Prestamo Reversado!", "REVERSADO!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {

                    }
                }

            }
            
            
        }
        /*
        decimal Porcentaje_Socios()
        {

            decimal _porcentaje = 0;
            try
            {
                foreach (ListViewItem item in LstSociosPrestamo.Items)
                {
                    _porcentaje += Convert.ToDecimal(item.SubItems[2].Text.Replace("%", ""));
                }

                return _porcentaje;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _porcentaje;

        }
        */
        private void ChkPorFrecuencia_CheckedChanged(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }


        private void TxtPorcentajeSocio_TextChanged(object sender, EventArgs e)
        {

        }


        /*/
        void addSocioToList()
        {

            try
            {
                if (TxtPorcentajeSocio.Text == "")
                {
                    MessageBox.Show("Favor inserte un porcentaje", "Porcentaje no insertado"
                        , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //Add Socio Lst
                LstSociosPrestamo.Items.Add(CmbSocio.SelectedValue.ToString(), 0);
                //Add Nombre Socio
                LstSociosPrestamo.Items[LstSociosPrestamo.Items.Count - 1]
                                 .SubItems.Add(CmbSocio.Text);
                //Add % socio
                LstSociosPrestamo.Items[
                    LstSociosPrestamo.Items.Count - 1].SubItems.Add(
                    (TxtPorcentajeSocio.Text + "%"));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        private void CmdAddSocio_Click(object sender, EventArgs e)
        {
            addSocioToList();
        }
        */
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Chk_Amortizar_CheckedChanged(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

        private void TxtDiaCobro_ValueChanged(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

        private void CmbFrecuencia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbFrecuencia.Text.ToLower().Trim() == "quincenal")
            {
                label14.Visible = true;
                TxtDiaCobro2.Visible = true;


            }
            else
            {
                label14.Visible = false;
                TxtDiaCobro2.Visible = false;
            }

            if (CmbFrecuencia.Text.ToLower().Trim() == "diario" ||
                CmbFrecuencia.Text.ToLower().Trim() == "semanal")
            {
                label14.Visible = false;
                TxtDiaCobro2.Visible = false;

                label13.Visible = false;
                TxtDiaCobro.Visible = false;
            }
            else {

                label13.Visible = true;
                TxtDiaCobro.Visible = true;
            }

        }

        private void ChkLineaDeCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLineaDeCredito.Checked)
            {
                TxtCantCuotas.Text = "1";
                TxtCantCuotas.Enabled = false;
                CalcMontoCuotas();
            }
        }

        private void TxtDiaCobro2_ValueChanged(object sender, EventArgs e)
        {
            CalcMontoCuotas();
        }

    }
}
