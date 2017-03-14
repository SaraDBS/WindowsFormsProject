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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ShowingStudents showStudent = new ShowingStudents();
            dataGridView.DataSource = showStudent.GetStudent();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void databaseHistoryOfActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogOfActions log = new LogOfActions();
            log.Show();
        }

        
    }
}
