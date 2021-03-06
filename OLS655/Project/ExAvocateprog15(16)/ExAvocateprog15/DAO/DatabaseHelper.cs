using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace ExAvocateprog15.DAO
{
    public class DatabaseHelper
    {
        public static ApplicantDAO Login(string UserName, string Password)
        {
            OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1};", UserName, Password));
            conn.Open(); // Try to connect using given username/password - if can't connect, an exception is thrown
            conn.Close();
            return new ApplicantDAO(UserName, Password);
        }

    }
}