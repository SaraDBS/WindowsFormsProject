using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BIZ
{
    public class ShowingTransactions
    {
        public DataTable GetTransaction()
        {
            ShowTransactions showTrans = new ShowTransactions();
            return showTrans.Read();
        }
    }
}
