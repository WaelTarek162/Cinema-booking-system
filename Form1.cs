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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtLogInUserName;
            txtLogInUserName.Focus();
        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string add, sql = "";
            add = @"Data Source = DESKTOP-M8NM9AS; Initial Catalog = My project;
                       User ID = sa; Password=A.kazem";
            cnn = new SqlConnection(add);
            cnn.Open();
            SqlCommand command;
            SqlParameter adExist = new SqlParameter("@AdminExist",SqlDbType.Int);
            SqlParameter usExist = new SqlParameter("@UserExist", SqlDbType.Int);
            adExist.Direction = ParameterDirection.Output;
            usExist.Direction = ParameterDirection.Output;
            sql = "Log";
            command = new SqlCommand(sql, cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@User_Name", txtLogInUserName.Text);
            command.Parameters.AddWithValue("@Pass", txtLogInPassword.Text);
            command.Parameters.Add(adExist);
            command.Parameters.Add(usExist);
            command.ExecuteScalar();
            Int16 AdminExist = Convert.ToInt16(adExist.Value);
            Int16 UserExist = Convert.ToInt16(usExist.Value);
            command.Dispose();
            cnn.Close(); 
            if (txtLogInUserName.Text == "")
            {
                MessageBox.Show("Please enter your name .");
            }
            else if (txtLogInPassword.Text == "")
            {
                MessageBox.Show("Please enter your password .");
            }
            else
            {
                
                if ((checkAdmin.Checked == false && checkUser.Checked == false)||(checkAdmin.Checked==true&&checkUser.Checked==true))
                {
                    MessageBox.Show("Please choose you are Admin or User .");
                }
                else if (checkAdmin.Checked == false && checkUser.Checked == true && UserExist == 1)
                {
                    MessageBox.Show("You are user.");
                    cnn.Open();
                    SqlParameter userName = new SqlParameter("@OUserName", SqlDbType.VarChar,50);
                    SqlParameter userId = new SqlParameter("OUserId", SqlDbType.Int);
                    userName.Direction = ParameterDirection.Output;
                    userId.Direction = ParameterDirection.Output;
                    command = new SqlCommand("RUAN", cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", txtLogInUserName.Text);
                    command.Parameters.Add(userName);
                    command.Parameters.Add(userId);
                    command.ExecuteScalar();
                    string UserName = (string)userName.Value;
                    Int16 UserId = Convert.ToInt16(userId.Value);
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show(UserId.ToString());
                    UserSearch fuser = new UserSearch(UserId, UserName);
                    //form3 will appeare after Ali's form appears
                    //Form3 form3 = new Form3("ff",UserName,UserId);
                    this.Hide();
                    fuser.Show();
                }
                else if(checkAdmin.Checked == true && checkUser.Checked == false && AdminExist == 1)
                {
                    MessageBox.Show("You are Admin.");
                    AdminSearch fadmin = new AdminSearch();
                    this.Hide();
                    fadmin.Show();
                }
                else
                {
                    MessageBox.Show("Enter correct Name and password.");
                }
                
            }

        }

        
        private void txtLogInUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = txtLogInPassword;
                txtLogInPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLogInPassword.UseSystemPasswordChar == true)
            {
                btnShow.Text = "Hide";
                txtLogInPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShow.Text = "Show";
                txtLogInPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
