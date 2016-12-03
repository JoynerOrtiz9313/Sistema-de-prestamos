using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Principal

{
    public class Conexion
    {

        //private string conStr = @"Data Source=192.168.1.16,1433;Network Library=DBMSSOCN;Initial Catalog=Sistema;User ID=test;Password=pepper;";
        private string conStr = System.Configuration.ConfigurationSettings.AppSettings["ConStr"].ToString();
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable data;


        public bool Connect()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                return true;
            }
            catch (Exception es)
            {
                throw es;
            }

        }

        public DataTable GetData(string Query)
        {

            data = new DataTable();

            try
            {
                if (Connect())
                {
                    cmd = new SqlCommand(Query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
            }
            catch (Exception es)
            {
                throw es;
            }

            return data;

        }

        public DataTable GetData(string Query, SqlCommand _cmd)
        {
            data = new DataTable();
         
            try
            {
                if (Connect())
                {
                    _cmd = new SqlCommand(Query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                }
            }
            catch (Exception es)
            {
                throw es;
            }

            return data;

        }

        public bool ExecuteCMD(string CMD)
        {

            try
            {
                if (Connect())
                {
                    cmd = new SqlCommand(CMD, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception es)
            {
                throw es;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return false;

        }

        public bool ExecuteCMD(string Query, SqlCommand _CMD)
        {
            try
            {
                if (Connect())
                {
                    _CMD.CommandText = Query;
                    _CMD.Connection = conn;
                    _CMD.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception es)
            {
                throw es;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return false;

        }
    }
}
