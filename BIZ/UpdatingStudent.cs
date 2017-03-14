using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class UpdatingStudent : UpdateData
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Level { get; set; }
        public string Course { get; set; }
        public int StudentNumber { get; }

        public UpdatingStudent(string fn, string sn, string email, string phone, string ad1, string ad2, string cy, string cty, string level, string course,int studentNumber)
        {
            FirstName = fn;
            Surname = sn;
            Email = email;
            Phone = phone;
            AddressLine1 = ad1;
            AddressLine2 = ad2;
            City = cy;
            County = cty;
            Level = level;
            Course = course;
            StudentNumber = studentNumber;
            
        }

        public void UpdateDB()
        {
            UpdateStudent(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course,StudentNumber);
        }
    }
}
