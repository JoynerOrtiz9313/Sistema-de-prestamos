using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Menu_Principal
{
    class Pago
    {

        Int32 ID { get; set; }
        public Int32 ID_Prestamo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal Interes { get; set; }
        public decimal Mora { get; set; }
        Conexion DB;
        DataTable dt;

        public Pago()
        {

        }

        public Pago(Int32 _ID)
        {

            try
            {
                Fill(_ID);
            }
            catch (Exception)
            {

            }

        }

        public bool Fill(Int32 _ID)
        {
            try
            {
                DB = new Conexion();
                dt = DB.GetData("select * from cuotas where id_cuota = " + _ID);
                ID_Prestamo = int.Parse(dt.Rows[0]["ID_Prestamo"].ToString());
                Fecha = DateTime.Parse(dt.Rows[0]["fecha"].ToString());
                Monto = decimal.Parse(dt.Rows[0]["Monto"].ToString());
                Interes = decimal.Parse(dt.Rows[0]["MontoInteres"].ToString());
                Mora = decimal.Parse(dt.Rows[0]["MontoMora"].ToString());
                ID = _ID;

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Save()
        {

            try
            {
                DB = new Conexion();
                if (DB.ExecuteCMD(
                    "INSERT INTO CUOTAS (ID_Prestamo,Fecha,Monto,MontoMora,MontoInteres) " +
                    " VALUES (" + ID_Prestamo + ",'" + Fecha + "'," + Monto.ToString().Replace(",", ".") +
                    "," + Mora.ToString().Replace(",", ".") +
                    "," + Interes.ToString().Replace(",", ".") + ")"))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public decimal GetTotalPagos(int ID_Prestamo)
        {

            try
            {
                dt = new DataTable();
                DB = new Conexion();

                dt = DB.GetData("Select sum(Monto) from cuotas where id_prestamo = " +
                        ID_Prestamo.ToString());

                if (dt.Rows[0][0].ToString() != "")
                    return decimal.Parse(dt.Rows[0][0].ToString());
                else
                    return 0;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Pago> GetPagosPendientes(int _ID,int _PagosPendientes)
        {
            int Contador_cuotas = 0;
            DB = new Conexion();
            List<Pago> lista = new List<Pago>();
            Prestamo Prest = new Prestamo();
            Prest.Fill(_ID);
            dt = new DataTable();
            DateTime FechaPago = Prest.ProximaFehcaCobro; ;
            DateTime UltFechaPago = Prest.ProximaFehcaCobro.AddDays(-Prest.GetDiasFrecuencia());
            DateTime fechaAlDia = DateTime.Now;
            try
            {
                int DiasFrec = int.Parse(DB.GetData("Select dias from TBL_Frecuencia where id_frecuencia =  " +
                                Prest.Frecuencia.ToString()).Rows[0][0].ToString());

             
                while (Contador_cuotas < _PagosPendientes)
                {
                    #region Armar query
                    if (UltFechaPago.Date >= DateTime.Now.Date)
                        return lista;

                    string Query = "select cast(((((p.monto*t.porcentaje))+p.monto)/p.cuotas) as decimal(18,2)) as Cuota," +
                            " cast(" + Prest.GetMora(UltFechaPago).ToString() + " as decimal(18,2)) as Mora, " +
                            " cast((p.monto*t.porcentaje) as decimal(18,2)) as Interes, " +
                            " cast((((p.monto*t.porcentaje)+p.monto)/p.cuotas) + " +
                            Prest.GetMora(UltFechaPago).ToString() +
                            " as decimal(18,2)) as 'Total_A_Pagar', '" +
                             UltFechaPago.ToString() + "' as Fecha " +
                            " from tbl_prestamos  p " +
                            " JOIN taza t on t.id_taza = p.taza" +
                            " where p.id_prestamo = " + Prest.ID_Prestamo.ToString();

                    #endregion

                    if (dt.Rows.Count <= 0)
                    {
                        dt = DB.GetData(Query);
                    }
                    else
                    {
                        DataRow r = dt.NewRow();
                        DataTable dt_Aux = DB.GetData(Query);

                        r["Cuota"] = Prest.getCouta();//dt_Aux.Rows[0][0].ToString();
                        r["Mora"] = dt_Aux.Rows[0][1].ToString();
                        r["Interes"] = dt_Aux.Rows[0][2].ToString();
                        r["Total_A_Pagar"] = dt_Aux.Rows[0][3].ToString();
                        r["Fecha"] = dt_Aux.Rows[0][4].ToString();

                        dt.Rows.Add(r);
                    }

                    UltFechaPago = UltFechaPago.AddDays(DiasFrec);
                    Contador_cuotas++;
                    //FechaPago = UltFechaPago;

                }

                foreach (DataRow dr in dt.Rows)
                {

                    Pago p = new Pago();
                    p.Mora = decimal.Parse(dr["Mora"].ToString());
                    p.Monto = decimal.Parse(dr["Cuota"].ToString());
                    p.Interes = decimal.Parse(dr["Interes"].ToString());
                    p.Fecha = DateTime.Parse(dr["fecha"].ToString());
                    p.ID_Prestamo = Prest.ID_Prestamo;
                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception es)
            {

                throw es;
            }

        }



    }
}
