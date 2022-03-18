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
    public partial class Ticket1 : Form
    {
        Int16 UserId;
        public Ticket1(Int16 User_Id)
        {
            UserId = User_Id;
            InitializeComponent();
            string connectionstirng;
            SqlConnection cnn;
            connectionstirng = @"Data Source=DESKTOP-M8NM9AS; Initial Catalog=My project;
                                User ID = sa; Password = A.kazem";

            cnn = new SqlConnection(connectionstirng);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            sql = "Select * from Ticket where User_id = '"+UserId+"'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                 userNameTextBox.Text = dataReader.GetValue(1).ToString();
                movieNameTextBox.Text =  dataReader.GetValue(2).ToString();
                movieDateDateTimePicker.Text =  dataReader.GetValue(3).ToString();
                movieTimeTextBox.Text = dataReader.GetValue(4).ToString();
                nomOfSeatTextBox.Text = dataReader.GetValue(5).ToString();
                txtPlace.Text = dataReader.GetValue(7).ToString();
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            Feedback feed = new Feedback(userNameTextBox.Text, movieNameTextBox.Text, UserId);
            this.Hide();
            feed.Show();
        }

      
    }
}
