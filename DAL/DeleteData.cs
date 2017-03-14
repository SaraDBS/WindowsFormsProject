using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DeleteData : DAO
    {
        public void DeleteStudent(int studentNumber)
        {

            string del = "DELETE FROM Student WHERE StudentNumber="+studentNumber;
            SqlCommand cmd = new SqlCommand(del, OpenCon());
            cmd.ExecuteReader();
            
            

          
        }
    }
}
