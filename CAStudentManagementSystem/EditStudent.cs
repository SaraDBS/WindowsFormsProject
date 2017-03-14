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

namespace CAStudentManagementSystem
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
            this.CenterToScreen();
            comboEditCounties.DataSource = Enum.GetValues(typeof(Counties));
            comboEditCourses.DataSource = Enum.GetValues(typeof(Courses));
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu1 = new Menu();
            menu1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            string fname = txtEditFirstName.Text;
            string lname = txtEditSurname.Text;
            string email = txtEditEmail.Text;
            string phone = txtEditPhone.Text;
            string address1 = txtEditAdrline1.Text;
            string address2 = txtEditAdrline2.Text;
            string city = txtEditCity.Text;
            string county = comboEditCounties.SelectedItem.ToString();
            string course = comboEditCourses.SelectedItem.ToString();
            string level = "";
            if (radioEditUnder.Checked)
            {
                level = "Undergraduate";
            }
            else if (radioEditPost.Checked)
            {
                level = "Postgraduate";
            }
            int studentNumber = int.Parse(txtEditStudentNumber.Text);

            UpdatingStudent updateStudent = new UpdatingStudent(fname, lname, email, phone, address1, address2, city, county, level, course,studentNumber);
            updateStudent.UpdateDB();
            MessageBox.Show("Student successfully updated!");
            this.Hide();
            Menu menu1 = new Menu();
            menu1.Show();
        }
    }
}
