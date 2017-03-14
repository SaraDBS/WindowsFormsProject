using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class CheckLogin : DAO
    {
        public string UserLoginName { get; set; }

        public string CheckUser(string user, string password)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username=@user AND password=@pass", OpenCon());
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", password);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return UserLoginName = dr.GetString(3);
            }
            else
            {
                return "no";

            }
        }
    }
}
