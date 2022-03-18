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
    public partial class UserSearch : Form
    {

        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-M8NM9AS;Initial Catalog = My project;
                    User Id = sa ; Password = A.kazem");
        public Int16 userId;
        public string userName;
        public UserSearch(Int16 User_Id, string User_Name)
        {
            userId = User_Id;
            userName = User_Name;
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            User_sBooking user_S = new User_sBooking(userId, userName);
            this.Hide();
            user_S.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            cnn.Open();
            SqlParameter isExist= new SqlParameter("@Mname",SqlDbType.Int);
            isExist.Direction= ParameterDirection.Output;
            SqlCommand com = new SqlCommand("Search_Movie",cnn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", search_box.Text);
            com.Parameters.Add(isExist);
            com.ExecuteScalar();
            Int16 Is_Exist =Convert.ToInt16 (isExist.Value);
            
           if (Is_Exist == 1)
            {
                SqlParameter id = new SqlParameter("@Mid", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
                SqlCommand command = new SqlCommand("Read_id", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@moviename", search_box.Text);
                command.Parameters.Add(id);
                command.ExecuteScalar();
               
                Int16 id_sent = Convert.ToInt16 (id.Value);
                //Ali's form
                Mforuser mforuser = new Mforuser(id_sent, userName, userId);
                this.Hide();
                mforuser.Show();
            }
            else
                MessageBox.Show("Enter correct Name");

            cnn.Close();
    
        }
    }
}
