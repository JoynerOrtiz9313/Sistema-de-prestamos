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
    public partial class Frm_Plan_De_Pago : Form
    {
        Pago pago;
        List<Pago> Pagos = new List<Pago>();
        List<Pago> PagosSeleccionados = new List<Pago>();
        Prestamo EstePrestamo;
        Pago PagoEnCurso;
        Conexion DB;

        public Frm_Plan_De_Pago(string id_Prestamo, string _Monto,
            string _Cliente, string _MontoPendiente, string _Interes)
        {
            InitializeComponent();
            Lbl_ID_Prestamo.Text = id_Prestamo;
            LblMonto.Text = _Monto;
            LblNombreCliente.Text = _Cliente;
            LblMontoPendiente.Text = _MontoPendiente;
            LblInteres.Text = _Interes;
        }

        private void Frm_Plan_De_Pago_Load(object sender, EventArgs e)
        {
            try
            {
                EstePrestamo = new Prestamo();
                if (!EstePrestamo.Fill(int.Parse(Lbl_ID_Prestamo.Text)))
                {
                    MessageBox.Show("Error con este prestamo favor verificar!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                DB = new Conexion();
                var CantPagosPendientes = int.Parse(DB.GetData("Select cuotas from tbl_prestamos where " +
                    " id_prestamo = " + Lbl_ID_Prestamo.Text).Rows[0]["cuotas"].ToString()) -
                    int.Parse(DB.GetData("Select count(id_cuota) as pagos from cuotas where id_prestamo = " +
                    Lbl_ID_Prestamo.Text).Rows[0]["pagos"].ToString());

                pago = new Pago();
                Pagos = pago.GetPagosPendientes(EstePrestamo.ID_Prestamo, CantPagosPendientes);
                LlenarListaPagos(Pagos);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        bool LlenarListaPagos(List<Pago> lstPagos)
        {

            try
            {

                if (Pagos.Count > 0)
                {
                    foreach (var _Pago in Pagos)
                    {
                        LstPagos.Items.Add(_Pago.Monto.ToString(), 0);    //Cuota
                        LstPagos.Items[LstPagos.Items.Count - 1].SubItems.Add(_Pago.Mora.ToString());    //Mora
                        LstPagos.Items[LstPagos.Items.Count - 1].SubItems.Add(_Pago.Interes.ToString());   //Interes
                        LstPagos.Items[LstPagos.Items.Count - 1].SubItems.Add((_Pago.Monto + _Pago.Mora).ToString());   //Total
                        LstPagos.Items[LstPagos.Items.Count - 1].SubItems.Add(_Pago.Fecha.ToString());   //Fecha
                        LstPagos.Items[LstPagos.Items.Count - 1].SubItems.Add(DateTime.Now.Subtract(_Pago.Fecha).Days.ToString());   //Dias Atraso

                        //Inserto la instancia de pago actual en el tag de este item de la lista
                        LstPagos.Items[LstPagos.Items.Count - 1].Tag = _Pago;
                    }

                    LblMoraAcumulada.Text = lstPagos.Sum(p => p.Mora).ToString();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (ChkMora.Checked)
                {
                    PagoEnCurso = (Pago)LstPagos.SelectedItems[0].Tag;
                    if (PagosSeleccionados.Count > 0)
                    {
                        if (PagosSeleccionados.Exists(p => p.Fecha == PagoEnCurso.Fecha) == false)
                        {
                            PagoEnCurso.Mora = 0;
                            PagosSeleccionados.Add(PagoEnCurso);
                        }
                    }
                    else
                    {
                        PagoEnCurso.Mora = 0;
                        PagosSeleccionados.Add(PagoEnCurso);
                    }
                }
                else
                {
                    PagoEnCurso = (Pago)LstPagos.SelectedItems[0].Tag;
                    if (PagosSeleccionados.Count > 0)
                    {
                        bool Existe = PagosSeleccionados.Exists(p => p.Fecha == PagoEnCurso.Fecha) ? true : false;

                        if (!Existe)
                        {
                            PagosSeleccionados.Add(PagoEnCurso);
                        }
                    }
                    else
                    {
                        PagosSeleccionados.Add(PagoEnCurso);
                    }

                }

                RefreshStatusPagos();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void RefreshStatusPagos()
        {

            try
            {
                if (PagosSeleccionados.Count > 0)
                {
                    TxtCantCuotas.Text = PagosSeleccionados.Count.ToString();
                    TxtTotalCuotas.Text = PagosSeleccionados.Sum(p => p.Monto).ToString();
                    TxtTotalMora.Text = PagosSeleccionados.Sum(p => p.Mora).ToString();
                    TxtTotal_A_Pagar.Text = PagosSeleccionados.Sum(p => p.Mora + p.Monto).ToString();
                }
                else
                {
                    TxtCantCuotas.Text = 0.ToString();
                    TxtTotalCuotas.Text = 0.ToString();
                    TxtTotalMora.Text = 0.ToString();
                    TxtTotal_A_Pagar.Text = 0.ToString();
                }
            }
            catch (Exception es)
            {

                throw es;
            }

        }

        private void CmdQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                PagoEnCurso = (Pago)LstPagos.SelectedItems[0].Tag;
                PagosSeleccionados.Remove(PagoEnCurso);
                RefreshStatusPagos();
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
