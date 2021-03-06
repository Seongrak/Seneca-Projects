// Author : Seongrak Choi (156405177)

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
    public class ApplyDAO
    {
        private string UserName { get; set; }
        private string Password { get; set; }

         public ApplyDAO(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

         public List<ExAvApplication> GetExAvApplications()
         {
             List<ExAvApplication> ExAvApplicationList = new List<ExAvApplication>();

             OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1}",UserName,Password));
             OracleCommand cmd = new OracleCommand("SELECT id, description, month FROM exav LEFT JOIN apply ON exav.id = apply.exav_id",conn);
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             DataTable dt = new DataTable();

             da.Fill(dt);

             foreach(DataRow dr in dt.Rows)
             {
                 int id = Convert.ToInt32(dr["id"]);
                 string description = Convert.ToString(dr["description"]);
                 int numMonth = Convert.ToInt32(dr["month"]);
                 string strMonth = DateTimeFormatInfo.CurrentInfo.MonthNames[numMonth];

                 ExAvApplicationList.Add(new ExAvApplication(id,description,strMonth));
             }

             return ExAvApplicationList;

         }

         public int Apply(int ExAvId, int Month)
         {
             OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1}", UserName, Password));
             OracleCommand cmd = new OracleCommand("EXAV_APPLY", conn);

             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("pexav_id", ExAvId);
             cmd.Parameters.AddWithValue("pmonth", Month);
             cmd.Parameters.Add("psuccess", OracleType.Int32).Direction = ParameterDirection.Output;

             conn.Open();

             try
             {
                 cmd.ExecuteNonQuery();
                 if (Convert.IsDBNull(cmd.Parameters["psuccess"].Value))
                     return 1; // when there will be available spots, always true

                 else
                     return Convert.ToInt32(cmd.Parameters["psuccess"].Value);
             }
             finally
             {
                 conn.Close();
             }
  

         }

    }
  

}