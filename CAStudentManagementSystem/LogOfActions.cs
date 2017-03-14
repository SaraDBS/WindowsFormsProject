using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using DAL;

namespace CAStudentManagementSystem
{
    public partial class LogOfActions : Form
    {
        public LogOfActions()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOfActions_Load(object sender, EventArgs e)
        {
            ShowingTransactions showTransaction = new ShowingTransactions();
            dataGridViewTrans.DataSource = showTransaction.GetTransaction();
        }

        private void backTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu1 = new Menu();
            menu1.Show();
        }
    }
}
