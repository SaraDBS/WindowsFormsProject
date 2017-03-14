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
using System.Configuration;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Net.Mail;

namespace CAStudentManagementSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            this.CenterToScreen();
            comboBoxCounties.DataSource = Enum.GetValues(typeof(Counties));
            comboCourses.DataSource = Enum.GetValues(typeof(Courses));
        }

        private void groupBoxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu1 = new Menu();
            menu1.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            XmlSerializer serialiser;
            XmlWriter xmlWriter;
            string filePath = string.Empty;

            string fname = txtFirstName.Text;
            string lname = txtSurname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address1 = txtAdrline1.Text;
            string address2 = txtAdrline2.Text;
            string city = txtCity.Text;
            string county = comboBoxCounties.SelectedItem.ToString();
            string course = comboCourses.SelectedItem.ToString();
            string mobileRegularExpression = ConfigurationManager.AppSettings["MobRegEx"];
            try
            {
                int studentNumber = int.Parse(txStudentNumber.Text);


                string level = "";
                if (radioUnder.Checked)
                {
                    level = "Undergraduate";
                }
                else if (radioPost.Checked)
                {
                    level = "Postgraduate";
                }

                AddNewStudent addNewStudent = new AddNewStudent(fname, lname, email, phone, address1, address2, city, county, level, course, studentNumber);
                addNewStudent.AddStudentToDB();
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = "xml files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    serialiser = new XmlSerializer(typeof(AddNewStudent));
                    xmlWriter = XmlWriter.Create(filePath);
                    serialiser.Serialize(xmlWriter, addNewStudent);
                }
                else
                {
                    MessageBox.Show("Student details not serialised!");
                }

                MessageBox.Show("Student successfully added to database!");
                this.Hide();
                Menu menu1 = new Menu();
                menu1.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("A student number must have 8 digits. Please enter a valid student number.");
                this.Hide();
                AddStudent addStudent = new AddStudent();
                addStudent.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            bool can = false;
            //checking to see if text box is empty
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {

                MessageBox.Show("Must enter text");
                can = true;
            }
            e.Cancel = can;

        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            bool can = false;
            //checking to see if text box is empty
            if (string.IsNullOrEmpty(txtSurname.Text))
            {

                MessageBox.Show("Must enter text");
                can = true;
            }
            e.Cancel = can;

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string mrx = ConfigurationManager.AppSettings["MobRegEx"];
            string number = txtPhone.Text;

            if (!Regex.IsMatch(number, mrx))
            {
                MessageBox.Show("Invalid Format!");
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                MailAddress m = new MailAddress(txtEmail.Text);


            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format!");
            }
        }
    }
}
    
    

