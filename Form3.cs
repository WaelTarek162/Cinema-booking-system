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
    public partial class Form3 : Form
    {
        public string movieName, userName, buttonName;
        public Int16 nomOfSeat = 0, userId, movieId;
        public Form3(string mName,string User_Name,Int16 User_Id,Int16 M_Id)
        {
            movieName = mName;
            userName = User_Name;
            userId = User_Id;
            movieId = M_Id;
            InitializeComponent();
            SqlConnection cnn;
            string add, sql = "";
            add = @"Data Source = DESKTOP-M8NM9AS; Initial Catalog = My project;
                       User ID = sa; Password=A.kazem";
            cnn = new SqlConnection(add);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            sql = "select Place , Movie_Time from Movie where Movie_Name = '" + movieName + "'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtMPlace.Text = (string)dataReader["Place"];
                txtMTime.Text = dataReader.GetValue(1).ToString();
            }
            txtMTime.Enabled = false;
            txtMPlace.Enabled = false;
            btnAvaliable.Enabled = false;
            btnBooked.Enabled = false;
            btnSelected.Enabled = false;
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userId.ToString());
            SqlConnection cnn;
            string add;
            add = @"Data Source = DESKTOP-M8NM9AS; Initial Catalog = My project;
                       User ID = sa; Password=A.kazem";
            cnn = new SqlConnection(add);
            cnn.Open();
            SqlCommand command, cmd, sqlCommand;
            cmd = new SqlCommand("update Movie set user_id ='"+userId+"' where Movie_id = '"+movieId+"'", cnn);
            cmd.ExecuteNonQuery();
            sqlCommand = new SqlCommand("update UserInfo set movie_Id = '"+movieId+"' where User_id='"+userId+"'",cnn);
            sqlCommand.ExecuteNonQuery();
            command = new SqlCommand("Add_Ticket", cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@User_Name", userName);
            command.Parameters.AddWithValue("@Movie_Name", movieName);
            command.Parameters.AddWithValue("@Movie_Date", ChoosenDate.Value);
            command.Parameters.AddWithValue("@Movie_Time", txtMTime.Text);
            command.Parameters.AddWithValue("@Movie_NomOfSeat", nomOfSeat);
            command.Parameters.AddWithValue("@UserId", userId);
            command.Parameters.AddWithValue("@Movie_Place", txtMPlace.Text);
            command.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            Ticket1 ticket = new Ticket1(userId);
            this.Hide();
            ticket.Show();
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            if (btn16.BackColor == Color.Lavender)
            {
                btn16.BackColor = Color.Red;
                nomOfSeat = 16;
            }
            else
            {
                btn16.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            if (btn13.BackColor == Color.Lavender)
            {
                btn13.BackColor = Color.Red;
                nomOfSeat = 13;
            }
            else
            {
                btn13.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (btn14.BackColor == Color.Lavender)
            {
                btn14.BackColor = Color.Red;
                nomOfSeat = 14;
            }
            else
            {
                btn14.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.BackColor == Color.Lavender)
            {
                btn1.BackColor = Color.Red;
                nomOfSeat = 1;
            }
            else
            {            
                btn1.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == Color.Lavender)
            {
                btn2.BackColor = Color.Red;
                nomOfSeat = 2;
            }
            else
            {
                btn2.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.Lavender)
            {
                btn3.BackColor = Color.Red;
                nomOfSeat = 3;
            }
            else
            {
                btn3.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.Lavender)
            {
                btn4.BackColor = Color.Red;
                nomOfSeat = 4;
            }
            else
            {
                btn4.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.Lavender)
            {
                btn5.BackColor = Color.Red;
                nomOfSeat = 5;
            }
            else
            {
                btn5.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.Lavender)
            {
                btn6.BackColor = Color.Red;
                nomOfSeat = 6;
            }
            else
            {
                btn6.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.Lavender)
            {
                btn7.BackColor = Color.Red;
                nomOfSeat = 7;
            }
            else
            {
                btn7.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.Lavender)
            {
                btn8.BackColor = Color.Red;
                nomOfSeat = 8;
            }
            else
            {
                btn8.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.Lavender)
            {
                btn9.BackColor = Color.Red;
                nomOfSeat = 9;
            }
            else
            {
                btn9.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.Lavender)
            {
                btn10.BackColor = Color.Red;
                nomOfSeat = 10;
            }
            else
            {
                btn10.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.BackColor == Color.Lavender)
            {
                btn11.BackColor = Color.Red;
                nomOfSeat = 11;
            }
            else
            {
                btn11.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.BackColor == Color.Lavender)
            {
                btn12.BackColor = Color.Red;
                nomOfSeat = 12;
            }
            else
            {
                btn12.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btnBooked_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserSearch user = new UserSearch(userId, userName);
            this.Hide();
            user.Show();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (btn15.BackColor == Color.Lavender)
            {
                btn15.BackColor = Color.Red;
                nomOfSeat = 15;
            }
            else
            {
                btn15.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (btn17.BackColor == Color.Lavender)
            {
                btn17.BackColor = Color.Red;
                nomOfSeat = 17;
            }
            else
            {
                btn17.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (btn18.BackColor == Color.Lavender)
            {
                btn18.BackColor = Color.Red;
                nomOfSeat = 18;
            }
            else
            {
                btn18.BackColor = Color.Lavender;
                nomOfSeat = 0;
            }
        }
    }
}
