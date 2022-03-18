using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinema_booking_system
{

    public partial class ManageBooking : Form
    {
        public ManageBooking()
        {
            InitializeComponent();
            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-M8NM9AS;Initial Catalog = My project;
                                    User ID = sa;Password = A.kazem");
            cnn.Open();
            string sql = @"select Name_user,Movie_Name from UserInfo inner join Movie on 
                           UserInfo.movie_Id = Movie.Movie_id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Ticket = new DataTable();
            Ticket.Columns.Add("Name_user");
            Ticket.Columns.Add("Movie_Name");
            DataRow row;
            while (reader.Read())
            {
                row = Ticket.NewRow();
                row["Name_user"] = reader["Name_user"];
                row["Movie_Name"] = reader["Movie_Name"];

                Ticket.Rows.Add(row);

            }
            dataGridView1.DataSource = Ticket;
            cmd.Dispose();
            reader.Close();
            cnn.Close();
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AdminSearch admin = new AdminSearch();
            this.Hide();
            admin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
