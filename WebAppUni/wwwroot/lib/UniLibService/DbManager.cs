using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;

using System.Linq;


namespace UniManager
{
    public class DbManager
    {
        public  string _connectionString { get; set; }=string.Empty;
       

        public DbManager()
        {
            _connectionString = ConfigurationManager.AppSettings["DbConnectionString"];
        }

        public static string ConnectionString { get; internal set; }= ConfigurationManager.AppSettings["DbConnectionString"];

        public bool IsDbOnLine
        {
            get
            {
                try
                {
                    using ( var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
     

     

     

    }
}
