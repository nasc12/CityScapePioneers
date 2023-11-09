using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AVisit.Models
{
    public class Home_location_Manager
    {
        public List<location> DropDownName()
        {
            List<location> loc = new List<location>();
            string scn = ConfigurationManager.ConnectionStrings["scn"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("prc_location", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            location sp=new location();
                            sp.Location = reader["Location"].ToString();
                           
                            loc.Add(sp);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    //SelectList selectListItems = new SelectList(speciality_Names, "Speciality", "Speciality");
                    //ViewBag.DropdownList = selectListItems;
                }

            }
            return loc;
        }
    }
}