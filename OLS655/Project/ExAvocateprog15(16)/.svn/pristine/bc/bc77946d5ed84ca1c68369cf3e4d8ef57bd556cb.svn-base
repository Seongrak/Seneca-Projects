// Author: Oluwaseun Kelani      Student No: 160584173

using ExAvocateprog15.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OracleClient;
using System.Globalization;
using ExAvocateprog15.Classes;

namespace ExAvocateprog15
{
    public class ApplicantDAO
    {
        private string UserName { get; set; }
        private string Password { get; set; }

        public ApplicantDAO(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public Applicant ValidateApplicant()
        {
            OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1}", UserName, Password));
            OracleCommand cmd = new OracleCommand("SELECT username,first_name,last_name FROM applicant WHERE username = :username", conn);
            cmd.Parameters.AddWithValue(":username", UserName);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string firstname = Convert.ToString(dr["first_name"]);
                string lastname = Convert.ToString(dr["last_name"]);
                return new Applicant(UserName, Password, firstname, lastname);
            }
            else
                return null;
        }

        public void WithdrawApplication(int ExAvId)
        {
            string ExAv =  Convert.ToString(ExAvId);

            List<ExAvApplication> ExAvApplicationList = new List<ExAvApplication>();
            OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1}", UserName, Password));
            OracleCommand cmd = new OracleCommand("DELETE FROM apply WHERE exav_id = :id ", conn);
            cmd.Parameters.AddWithValue(":id", ExAv);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {   
                DataRow dr = dt.Rows[0];
          
                int exav_id = Convert.ToInt32(dr["id"]);
                   string description = Convert.ToString(dr["description"]);
                    int numMonth = Convert.ToInt32(dr["month"]);
                    string strMonth = DateTimeFormatInfo.CurrentInfo.MonthNames[numMonth];

                    ExAvApplicationList.Add(new ExAvApplication(exav_id, description, strMonth));
            }

           
        }

   
    }
}