using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ShowTransactions : DAO
    {
        DataTable dataTable = new DataTable();
        public DataTable Read()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Transactions", OpenCon());
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            return dataTable;
        }
    }
}
