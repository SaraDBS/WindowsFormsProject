using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class AddData : DAO
    {
        public void AddNewStudent(string firstName, string surname,string email,string phone, string address1,string address2, string city, string county,string courseLevel,string course,int studentNumber)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Student (FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course, StudentNumber) VALUES (@firstName,@surname,@email,@phone,@address1,@address2,@city,@county,@courselevel,@course,@studentNumber)", OpenCon());
            cmd.Parameters.AddWithValue("@firstName",firstName);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address1",address1);
            cmd.Parameters.AddWithValue("@address2",address2);
            cmd.Parameters.AddWithValue("@city",city);
            cmd.Parameters.AddWithValue("@county",county);
            cmd.Parameters.AddWithValue("@courselevel",courseLevel);
            cmd.Parameters.AddWithValue("@course",course);
            cmd.Parameters.AddWithValue("@studentNumber",studentNumber);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}
