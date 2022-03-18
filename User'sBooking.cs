using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema_booking_system
{
    public partial class User_sBooking : Form
    {
        Int16 userId;
        string userName;
        public User_sBooking(Int16 User_Id,string User_Name)
        {
            userId = User_Id;
            userName = User_Name;
            InitializeComponent();
            SqlConnection cnn;
            cnn = new SqlConnection("Data Source = DESKTOP-M8NM9AS; Initial Catalog = My project;" +
                      "User ID = sa; Password = A.kazem");
            cnn.Open();
            string sql = "select Name_user,Movie_Name from UserInfo inner join Movie on  UserInfo.User_id=Movie.user_id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name_user");
            tbl.Columns.Add("Movie_Name");
            DataRow row;
            while (reader.Read())
            {
                row = tbl.NewRow();
                row["Name_user"] = reader["Name_user"];
                row["Movie_Name"] = reader["Movie_Name"];
                tbl.Rows.Add(row);

            }
            reader.Close();
            cnn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserSearch user = new UserSearch(userId, userName);
            this.Hide();
            user.Show();
        }
    }
}
