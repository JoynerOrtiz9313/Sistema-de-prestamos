using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal.Class
{
    class Socio
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }

        Conexion DB;


        public bool Save()
        {

            try
            {
                DB = new Conexion();
                string Query;

                if (Cedula == "" || Nombre == "")
                    return false;

                if (DB.GetData("Select * from socios where cedula = '" + Cedula.Trim() +
                                "'").Rows.Count > 0)
                {
                    Query = "UPDATE Socios set " +
                            " Nombre = '" + Nombre +
                            "', Telefono1 = '" + Telefono1 +
                            "', Telefono2 = '" + Telefono2 +
                            "', Direccion = '" + Direccion +
                            "' WHERE Cedula = '" + Cedula + "'";
                }
                else
                {
                    Query = "INSERT INTO Socios (Cedula,Nombre,Telefono1,Telefono2,Direccion)" +
                                    " VALUES ('" + Cedula +
                                    "', '" + Nombre + "','" + Telefono1 +
                                    "','" + Telefono2 + "','" + Direccion + "')";
                }

                DB.ExecuteCMD(Query);

                return true;
            }
            catch (Exception es)
            {
                throw es;
            }

        }

        public bool Fill(string _Cedula)
        {

            try
            {
                DB = new Conexion();

                var dt = DB.GetData("Select * from socios where cedula = '" + _Cedula.Trim() + "'");

                if (dt.Rows.Count > 0)
                {
                    Cedula = dt.Rows[0]["Cedula"].ToString();
                    Nombre = dt.Rows[0]["Nombre"].ToString();
                    Telefono1 = dt.Rows[0]["Telefono1"].ToString();
                    Telefono2 = dt.Rows[0]["Telefono2"].ToString();
                    Direccion = dt.Rows[0]["Direccion"].ToString();

                    return true;
                }

                return false;
            }
            catch (Exception es)
            {

                throw es;
            }

        }

    }
}
