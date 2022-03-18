using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_booking_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnShow.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShow.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter your name .");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password .");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your E_mail .");
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter your phone .");
            }
            else
            {
                SqlConnection cnn;
                string add, sql = "";
                add = @"Data Source = DESKTOP-M8NM9AS; Initial Catalog = My project;
                       User ID = sa; Password=A.kazem";
                cnn = new SqlConnection(add);
                cnn.Open();
                SqlCommand command;
                sql = "User_Inseret";
                command = new SqlCommand(sql, cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", this.txtUserName.Text);
                command.Parameters.AddWithValue("@mobile", this.txtPhone.Text);
                command.Parameters.AddWithValue("@email", this.txtEmail.Text);
                command.Parameters.AddWithValue("@password", this.txtPassword.Text);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = txtPassword;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = txtEmail;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = txtPhone;
                txtPhone.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
