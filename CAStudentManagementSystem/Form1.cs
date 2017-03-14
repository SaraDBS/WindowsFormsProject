using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace CAStudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        CheckLogin c = new CheckLogin();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

          string user = txtUsername.Text;
          string pass = txtPassword.Text;

            string status = c.CheckUser(user, pass);
            if (status == "no")
            {
                MessageBox.Show("Invalid username or password");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }

            else
            {
                MessageBox.Show("Welcome to DBS Student Management!");
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                lblUsername.Enabled = false;
                lblPassword.Enabled = false;
                btnLogin.Enabled = false;
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    }

