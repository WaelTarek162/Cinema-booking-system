using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cinema_booking_system
{
    public partial class AdminSearch : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-M8NM9AS;Initial Catalog = My project;
                    User Id = sa ; Password = A.kazem");

        public AdminSearch()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            AddMovie add = new AddMovie();
            this.Hide();
            add.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ManageBooking manage = new ManageBooking();
            this.Hide();
            manage.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlParameter isExist = new SqlParameter("@Mname", SqlDbType.Int);
            isExist.Direction = ParameterDirection.Output;
            SqlCommand com = new SqlCommand("Search_Movie", cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", txtSearch.Text);
            com.Parameters.Add(isExist);
            com.ExecuteScalar();
            Int16 Is_Exist = Convert.ToInt16(isExist.Value);

            if (Is_Exist == 1)
            {
                SqlParameter id = new SqlParameter("@Mid", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
                SqlCommand command = new SqlCommand("Read_id", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@moviename", txtSearch.Text);
                command.Parameters.Add(id);
                command.ExecuteScalar();

                Int16 id_sent = Convert.ToInt16(id.Value);
                MessageBox.Show(id_sent.ToString());
                MforAdmin mforadmin = new MforAdmin(id_sent);
                this.Hide();
                mforadmin.Show();
            }
            else
                MessageBox.Show("Enter correct Name");

        }
    }
}
