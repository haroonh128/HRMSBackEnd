using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace Helper
{
    public class OdbHelper
    {
        static OdbcDataAdapter adapter = null;
        static OdbcConnection connection = null;
        static OdbcCommand command = null;
        static string connectionString = "DRIVER={HDBODBC};UID=DEV;PWD=Abacus@000;SERVERNODE=10.1.10.39:30015;CS=NAEEMELC_PRODUCTION1";
        //SAPbobsCOM.Company oCompany;

        public OdbHelper()
        {

        }
        
        public static void InitializeConnection()
        {
            try
            {
                connection = new OdbcConnection(connectionString);
                //    odbcConnection.Open();
                //if (connection.State == ConnectionState.Closed)
                //{
                    connection.Open();
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string GetHANAConnection()
        {
            string con = connectionString;
            try
            {
                //RegistryKey reg = Registry.LocalMachine.OpenSubKey(@"Software\AbacusConsulting");
                //if (reg != null)
                //{
                //    //return Configuration.["applicationSettings:DBCON_HANA"].ToString();
                //    con = reg.GetValue("DBCON_HANA").ToString();
                //    //return connectionString;
                //}
                //else
                //{
                //    return string.Empty;
                //}
            }
            catch (Exception e)
            {
                throw e;
                //return string.Empty;
            }

            return con;
        }

        public static DataTable GetResults(string query)
        {
            try
            {
                InitializeConnection();
                connection = new OdbcConnection(connectionString);
                adapter = new OdbcDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                //Logger.Error(ex.Message);
                throw ex;
            }
        }
    }
}
