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
    public partial class Feedback : Form
    {
        string userName, movieName;
        Int16 userId;
        public Feedback(string user_name,string movie_name , Int16 user_id)
        {
            InitializeComponent();
            userName = user_name;
            movieName = movie_name;
            userId = user_id;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            UserSearch fuser = new UserSearch(userId, userName);
            this.Hide();
            fuser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstirng;
            SqlConnection cnn;
            connectionstirng = @"Data Source=DESKTOP-M8NM9AS; Initial Catalog=My project;
                                User ID = sa; Password = A.kazem";
            cnn = new SqlConnection(connectionstirng);
            
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql= "insert into Feedback (MovieName,UserName,Description,User_id) values('" + movieName + "','" + userName + "','" + textBox1.Text+"','"+userId+"')"; 
            command = new SqlCommand(sql,cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Thanks for your Feedback");
            cnn.Close();
            this.Close();
        }
    }
}
