using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
namespace Cinema_booking_system
{
    public partial class Mforuser : Form
    {
        public Int16 movieId, userId;
        public string userName;
        public Mforuser(Int16 m_Id,string User_Name,Int16 User_Id)
        {
            movieId = m_Id;
            userName = User_Name;
            userId = User_Id;
            InitializeComponent();
            textBoxName.Enabled = false ;
            textBoxPlace.Enabled = false;
            textBoxstart.Enabled = false;
            textBoxTime.Enabled = false;
            textBoxend.Enabled = false;
            groupBoxdiscription.Enabled = false;

            SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-M8NM9AS; Initial Catalog = My project;
                                                    User ID = sa; Password=A.kazem");
            cnn.Open();
            string sql = "select* from Movie where Movie_id ='" + movieId + "'";
            SqlCommand cmd;
            cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBoxName.Text = reader.GetValue(1).ToString();
                textBoxPlace.Text = reader.GetValue(2).ToString();
                textBoxstart.Text = reader.GetValue(3).ToString();
                textBoxTime.Text = reader.GetValue(4).ToString();
                groupBoxdiscription.Text = reader.GetValue(5).ToString();
                textBoxend.Text = reader.GetValue(6).ToString();
                
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            cnn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(textBoxName.Text, userName, userId,movieId);
            this.Hide();
            form3.Show();
        }
    }
}

