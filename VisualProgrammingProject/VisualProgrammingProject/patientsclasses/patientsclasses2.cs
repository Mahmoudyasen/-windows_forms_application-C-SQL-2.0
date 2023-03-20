using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace VisualProgrammingProject.patientsclasses
{
    class patientsclasses2
    {


        public string username { get; set; }
        public string password { get; set; }

        static string myconnection1 = ConfigurationManager.ConnectionStrings["VisualProgrammingProject.Properties.Settings.patientsConnectionString"].ConnectionString;




        public DataTable Select2()
        {
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnection1);

            //Create an Object for DataTable
            DataTable dt = new DataTable();
            try
            {
                // Step 2: Write Sql Query
                string sql = "SELECT * FROM adminDB";
                // Create Command using "sql" and "conn"
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create SqlDataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // Open connection
                conn.Open();
                // Fill our dt with our adapter.
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
