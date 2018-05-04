using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace factorySystem.Models
{
    
    public class DatabaseHandlerClass
    {
        SqlConnection scon;
        private void connection()
        {
            string con = ConfigurationManager.ConnectionStrings["fms"].ToString();
            scon = new SqlConnection(con);
        }

        public bool addCompany(Company com)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddCompany", scon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@companyName", com.Company_Name);
            cmd.Parameters.AddWithValue("@name", com.Name);
            cmd.Parameters.AddWithValue("@contactNumber", com.Contact_No);
            cmd.Parameters.AddWithValue("@email", com.Email);
            cmd.Parameters.AddWithValue("@address", com.Address);

            scon.Open();
            int i = cmd.ExecuteNonQuery();
            scon.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Company> companyList()
        {
            connection();
            List<Company> comp = new List<Company>();
            string query = "select * from Company";
            SqlCommand cmd = new SqlCommand(query,scon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            scon.Open();
            sda.Fill(dt);
            scon.Close();

            foreach (DataRow dr in dt.Rows)
            {
                comp.Add(new Company
                    {
                        Company_Id = Convert.ToInt32((dr["Company_Id"])),
                        Company_Name = Convert.ToString((dr["Company_Name"])),
                        Name = Convert.ToString((dr["Name"])),
                        Contact_No = Convert.ToString((dr["Contact_No"])),
                        Email = Convert.ToString((dr["Email"])),
                        Address = Convert.ToString(dr["Address"])
                    });
            }
            return comp;
        }

    }
}