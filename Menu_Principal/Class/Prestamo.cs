using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Menu_Principal
{
    class Prestamo
    {
        Conexion DB;
        DataTable dt;

        Int32 idprestamo;
        Int32 idcliente;
        Int32 tipo;
        Int32 frecuencia;
        Int32 cobrador;
        Int32 taza;
        string garantia;
        decimal monto;
        int cuotas;
        DateTime fecha;
        public bool Amortizar { get; set; }
        public bool Pagado { get; set; }
        public bool LineaCredito { get; set; }
        public int DiasCobro { get; set; }
        public int DiasCobro2 { get; set; }
        public decimal MontoCuota { get; set; }
        public DateTime ProximaFehcaCobro { get; set; }

        decimal interesMora;

        public Int32 ID_Prestamo
        {
            get { return idprestamo; }
        }
        public Int32 ID_Cliente
        {
            get { return idcliente; }
        }
        public Int32 Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public Int32 Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }
        public Int32 Cobrador
        {
            get { return cobrador; }
            set { cobrador = value; }
        }
        public Int32 Taza
        {
            get { return taza; }
            set { taza = value; }
        }
        public string Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }
        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public int Cuotas
        {
            get { return cuotas; }
            set { cuotas = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public bool Fill(Int32 ID)
        {

            try
            {
                dt = new DataTable();
                DB = new Conexion();

                dt = DB.GetData("Select * from TBL_prestamos where id_prestamo = " + ID.ToString());
                idcliente = Convert.ToInt32(dt.Rows[0]["ID_Cliente"].ToString());
                tipo = Convert.ToInt32(dt.Rows[0]["tipo"].ToString());
                frecuencia = Convert.ToInt32(dt.Rows[0]["frecuencia"].ToString());
                taza = Convert.ToInt32(dt.Rows[0]["taza"].ToString());
                garantia = dt.Rows[0]["garantia"].ToString();
                monto = Convert.ToDecimal(dt.Rows[0]["monto"].ToString());
                cuotas = Convert.ToInt16(dt.Rows[0]["cuotas"].ToString());
                fecha = DateTime.Parse(dt.Rows[0]["Fecha"].ToString());
                cobrador = Convert.ToInt16(dt.Rows[0]["cobrador"].ToString());
                Amortizar = bool.Parse(dt.Rows[0]["Amortizar"].ToString());
                Pagado = bool.Parse(dt.Rows[0]["Pagado"].ToString());
                DiasCobro = int.Parse(dt.Rows[0]["Dia_Cobro"].ToString());
                DiasCobro2 = dt.Rows[0]["Dia_Cobro2"] == DBNull.Value ? 0 : int.Parse(dt.Rows[0]["Dia_Cobro2"].ToString());
                LineaCredito = bool.Parse(dt.Rows[0]["LineaCredito"].ToString());
                MontoCuota = int.Parse(dt.Rows[0]["MontoCuota"].ToString());
                ProximaFehcaCobro = DateTime.Parse(dt.Rows[0]["FechaProximoPago"].ToString());
                idprestamo = ID;

                return true;


            }
            catch (Exception)
            {

            }

            return false;
        }

        //Fill @Override
        public bool Fill(Int32 ID_Client, Int32 _Tipo, Int32 _Frecuencia,
                    Int32 _Cobrador, Int32 _Taza, string _Garantia, decimal _Monto,
                    int _Cuotas, DateTime _fecha, bool _Amortizar, bool _pagado, bool _LienaCredito,
            decimal _MontoCuota, int _diacobro, int _diacobro2, bool _Nuevo)
        {

            try
            {
                idcliente = ID_Client;
                tipo = _Tipo;
                frecuencia = _Frecuencia;
                taza = _Taza;
                garantia = _Garantia;
                monto = _Monto;
                cuotas = _Cuotas;
                fecha = _fecha;
                Cobrador = _Cobrador;
                Amortizar = _Amortizar;
                Pagado = _pagado;
                LineaCredito = _LienaCredito;
                MontoCuota = _MontoCuota;
                DiasCobro = _diacobro;
                DiasCobro2 = _diacobro2;
                ProximaFehcaCobro = GetSiguienteFechaPago(_Nuevo);
                return true;

            }
            catch (Exception)
            {

            }

            return false;
        }


        public decimal GetInteresPrestamo()
        {
            try
            {
                DB = new Conexion();

                decimal _taza = decimal.Parse(DB.GetData("Select porcentaje from taza where id_taza = " +
                               Taza.ToString()).Rows[0][0].ToString());
                return _taza;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public decimal getCouta()
        {
            decimal _Cuota = 0;

            try
            {
                if (idprestamo == 0)
                {
                    throw new Exception("Prestamo Indefinido!");
                }
                else
                {
                    if (Amortizar)
                    {
                        DB = new Conexion();

                        _Cuota = MontoCuota;
                    }
                    else if (LineaCredito)
                    {
                        _Cuota = this.GetBalancePendiente() + this.GetMora() + this.GetMontoInteres();
                    }
                    else
                    {
                        _Cuota = ((this.Monto * GetInteresPrestamo() + this.Monto)) / Cuotas;
                    }
                }


                return _Cuota;
            }
            catch (Exception)
            {

                throw new Exception("Prestamo Indefinido!");
                //return 0;
            }

        }

        public decimal GetMontoInteres()
        {
            decimal _Interes = 0;

            try
            {
                if (idprestamo == 0)
                {
                    throw new Exception("Prestamo Indefinido!");
                }
                else
                {
                    if (Amortizar)
                    {
                        DB = new Conexion();
                        _Interes = MontoCuota - (Monto / cuotas);

                    }
                    else if (LineaCredito)
                    {
                        _Interes = (this.GetBalancePendiente() * this.GetInteresPrestamo());
                    }
                    else
                    {
                        _Interes = (this.Monto * GetInteresPrestamo()) / cuotas;
                    }
                }


                return _Interes;
            }
            catch (Exception)
            {

                throw new Exception("Prestamo Indefinido!");
                //return 0;
            }

        }

        public DateTime GetFechaFin()
        {
            try
            {
                DB = new Conexion();
                int dias = int.Parse(DB.GetData("Select (p.cuotas*f.dias) as dias from TBL_Prestamos p JOIN TBL_Frecuencia f on f.id_frecuencia = " + this.frecuencia.ToString() +
                    " WHERE p.ID_Prestamo = " + this.idprestamo.ToString()).Rows[0][0].ToString());

                return this.fecha.AddDays(dias);
            }
            catch (Exception es)
            {
                throw es;
            }

        }

        public DateTime GetSiguienteFechaPago(bool nuevo)
        {

            int dd, mm, yyyy;

            try
            {

                if (nuevo)
                {

                    var diaActual = DateTime.Today.Day;
                    var mesActual = DateTime.Today.Month;
                    var anioActual = DateTime.Today.Year;

                    if (diaActual > DiasCobro2)
                    {
                        dd = DiasCobro;
                        mm = mesActual == 12 ? 1 : mesActual += 1;
                        yyyy = mesActual == 12 ? anioActual += 1 : anioActual;
                    }
                    else if (diaActual > DiasCobro)
                    {

                        dd = DiasCobro2;
                        mm = mesActual;
                        yyyy = anioActual;
                    }
                    else
                    {

                        dd = DiasCobro;
                        mm = mesActual;
                        yyyy = anioActual;
                    }

                    return Convert.ToDateTime(string.Format("{0}-{1}-{2}", dd, mm, yyyy));
                }

                DB = new Conexion();

                return ProximaFehcaCobro;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public decimal GetMora()
        {
            if (LineaCredito)
            {
                interesMora = this.GetInteresPrestamo();
            }
            else
            {
                interesMora = decimal.Parse(System.Configuration.ConfigurationSettings.AppSettings["InteresMora"].ToString());
            }
            try
            {
                DB = new Conexion();

                /*
                  int dias = Int32.Parse(
                  DB.GetData("Select dias from tbl_frecuencia where id_frecuencia = " + 
                  this.frecuencia.ToString()).Rows[0][0].ToString());
                */


                DateTime FechaPago = GetSiguienteFechaPago(false);

                int diasDiff = FechaPago.Subtract(DateTime.Now).Days;
                decimal MontoMora = 0;
                if (diasDiff < 0)
                {
                    diasDiff *= (-1);


                    MontoMora = (this.GetBalancePendiente() * interesMora) * (diasDiff / this.GetDiasFrecuencia());

                    return MontoMora;
                }
                return MontoMora;

            }
            catch (Exception)
            {

            }
            return 0;
        }

        public int GetDiasFrecuencia()
        {
            int diasfrec = 0;
            DB = new Conexion();
            try
            {
                return diasfrec = Convert.ToInt32(DB.GetData("select dias from tbl_frecuencia where id_frecuencia = " +
                    this.Frecuencia.ToString()).Rows[0][0].ToString());

            }
            catch (Exception es)
            {

                throw es;
            }

        }

        public decimal GetMora(DateTime FechaLimite)
        {
            interesMora = decimal.Parse(0.066.ToString());
            try
            {
                DB = new Conexion();
                /*int dias = Int32.Parse(
                  DB.GetData("Select dias from tbl_frecuencia where id_frecuencia = " + 
                  this.frecuencia.ToString()).Rows[0][0].ToString());
                */


                DateTime FechaPago = GetSiguienteFechaPago(false);

                int diasDiff = FechaLimite.Subtract(DateTime.Now).Days;
                decimal MontoMora = 0;
                if (diasDiff < 0)
                {
                    diasDiff *= (-1);

                    for (int i = 0; i <= diasDiff; i++)
                    {
                        MontoMora = (Monto * interesMora) * i;
                    }
                    return MontoMora;
                }
                return MontoMora;

            }
            catch (Exception)
            {

            }
            return 0;
        }

        public decimal GetBalancePendiente()
        {
            decimal value = 0;
            try
            {
                DB = new Conexion();
                if (!Amortizar)
                {
                    decimal BalancePago = decimal.Parse(
                        DB.GetData("select sum(monto) as 'Pago' from cuotas where id_prestamo = " +
                        idprestamo.ToString()).Rows[0][0].ToString() == "" ? "0" :
                        DB.GetData("select cast(sum(monto) as decimal(18,2)) as 'Pago' from cuotas where id_prestamo = " +
                        idprestamo.ToString()).Rows[0][0].ToString());

                    decimal _taza = decimal.Parse(DB.GetData("Select porcentaje from taza where id_taza = " +
                                    Taza.ToString()).Rows[0][0].ToString());

                    value = ((Monto) - BalancePago);
                }
                else
                {


                    DB = new Conexion();

                    var _CuotasPagadas = Convert.ToDecimal(DB.GetData("Select count(*) from cuotas where id_prestamo = " +
                        idprestamo.ToString()).Rows[0][0].ToString()) == 0 ? 0 : Convert.ToDecimal(DB.GetData("Select count(*) from cuotas where id_prestamo = " +
                        idprestamo.ToString()).Rows[0][0].ToString());

                    if (_CuotasPagadas == 0)
                    {
                        value = Monto;
                    }
                    else
                    {
                        value = ((Monto - ((Monto / Cuotas) * _CuotasPagadas)) * GetInteresPrestamo()) +
                          ((Monto - ((Monto / Cuotas) * _CuotasPagadas)));
                    }
                }

                return value;

            }
            catch (Exception)
            {

            }

            return this.monto;
        }

        public bool Exist(Int32 _ID)
        {

            DB = new Conexion();

            if (DB.GetData("Select 1 from tbl_prestamos where id_prestamo = " + _ID.ToString()).Rows.Count < 1)
                return false;
            else
                return true;

        }

        public bool Save()
        {
            try
            {

                DB = new Conexion();
                string Query = "";

                Query = @"Insert into tbl_Prestamos (id_cliente,monto,taza,frecuencia,cuotas,
                        garantia,tipo,cobrador,fecha,Amortizar,pagado,MontoCuota,dia_cobro,
                        dia_cobro2,LineaCredito,FechaProximoPago)
                        VALUES (" +
                        ID_Cliente + "," +
                        Monto + "," +
                        Taza + "," +
                        Frecuencia + "," +
                        Cuotas + ",'" +
                        Garantia + "'," +
                        Tipo + "," +
                        Cobrador + ",'" +
                        fecha.ToString() +
                        "', '" + Amortizar.ToString() +
                        "','" + Pagado.ToString() +
                        "', " + MontoCuota.ToString() +
                        ", " + DiasCobro.ToString() +
                        ", " + DiasCobro2.ToString() +
                        ", '" + LineaCredito.ToString() + 
                        "','" + ProximaFehcaCobro.ToString("dd/MM/yyyy") + "')";

                DB.ExecuteCMD(Query);

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {

            if (idprestamo != 0)
            {
                DB = new Conexion();
                string Query = "";

                Query = "UPDATE tbl_Prestamos SET id_cliente = " + ID_Cliente +
                    ",monto=" + Monto +
                    ",taza=" + Taza + ",frecuencia=" + Frecuencia +
                    ",cuotas" + Cuotas +
                    ",garantia = '" + Garantia +
                    "',tipo" + Tipo +
                    ",cobrador = " + cobrador + ")" +
                    "WHERE id_prestamo = " + ID_Prestamo;

                DB.ExecuteCMD(Query);

                return true;
            }

            return false;
        }


    }
}
