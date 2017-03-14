using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BIZ
{
    public class ShowingStudents
    {
        public DataTable GetStudent()
        {
            ShowData showData = new ShowData();
            return showData.Read();
        }
    }
}
