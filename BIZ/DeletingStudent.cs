using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BIZ
{
    public class DeletingStudent
    {   public void DeleteStudent(int studentNumber)
        {
            DeleteData deleteData = new DeleteData();
            deleteData.DeleteStudent(studentNumber);
        }
    }
}
