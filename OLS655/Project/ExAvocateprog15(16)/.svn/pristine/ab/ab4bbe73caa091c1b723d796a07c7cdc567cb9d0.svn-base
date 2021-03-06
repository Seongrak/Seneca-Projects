/* Author : Albright Nsubuga
 * StudentID :141358176
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace ExAvocateprog15.DAO
{
    public class ExAvDAO
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        public ExAvDAO(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public int GetNumberOfExAvApplications()
        {

            OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1}", UserName, Password));
            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) AS num FROM apply WHERE applicant_username = :username",conn);
            
            cmd.Parameters.AddWithValue(":username", UserName);
            conn.Open();
            try
            {
                int applications = Convert.ToInt32(cmd.ExecuteScalar());
                return applications;
            }
            finally 
            {
                conn.Close();
            }
        }
        public List<ExAv>GetAvailableExAvs()
        {
            OracleConnection conn = new OracleConnection(String.Format("Data Source=Neptune; User Id={0}; Password={1}", UserName, Password));
            OracleCommand cmd = new OracleCommand("SELECT id,description,max_applicants FROM exav WHERE IS_EXAV_AVAILABLE(id)=1 ORDER BY description ASC", conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ExAv> avocations = new List<ExAv>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    int exav_id = Convert.ToInt32(dr["id"]);
                    string description = Convert.ToString(dr["description"]);
                    int maximum_applicants = Convert.ToInt32(dr["max_applicants"]);
                    avocations.Add(new ExAv(exav_id, description, maximum_applicants));
                }
                return avocations;
            }
            else
                return null;

        }
    }
}