using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Cinema_booking_system
{
    public partial class MforAdmin : Form
    {
        public Int16 movieId;
        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-M8NM9AS;Initial Catalog = My project;
                                    User ID = sa;Password = A.kazem");
        public MforAdmin(Int16 movie_Id)
        {
            movieId = movie_Id;
            InitializeComponent();
            txtName.Enabled = false;
            txtPlace.Enabled = false;
            //displayyyyyy
            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string x;
            x = "select * from Movie where Movie_id='" + movieId + "' ";
            command = new SqlCommand(x, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                txtName.Text = datareader.GetValue(1).ToString();
                txtPlace.Text = datareader.GetValue(2).ToString();
                txtSDate.Text = datareader.GetValue(3).ToString();
                txtEDate.Text = datareader.GetValue(6).ToString();
                txtTime.Text = datareader.GetValue(4).ToString();
            }
                datareader.Close();
                cnn.Close();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand comd = new SqlCommand("Update_Movie", cnn);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.AddWithValue("@m_startdate", txtSDate.Text);
            comd.Parameters.AddWithValue("@m_enddate", txtEDate.Text);
            comd.Parameters.AddWithValue("@m_time", txtTime.Text);
            comd.Parameters.AddWithValue("@m_id", movieId);
            comd.ExecuteNonQuery();
            comd.Dispose();
            cnn.Close();
            MessageBox.Show("updated");
        }
        

        
        private void button3_Click(object sender, EventArgs e)
        {
            ManageBooking MBform = new ManageBooking();
            this.Hide();
            MBform.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string del_movie = @"delete from Movie where Name='" + txtName.Text + "'";
            SqlCommand comnd = new SqlCommand(del_movie, cnn);
            adapter.DeleteCommand = new SqlCommand(del_movie, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            comnd.Dispose();
            cnn.Close();
            MessageBox.Show("Delete");
        }
    }
}
