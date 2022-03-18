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
using System.IO;

namespace Cinema_booking_system
{
    public partial class AddMovie : Form
    {

        SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP-M8NM9AS;Initial Catalog = My project;
                    User Id = sa ; Password = A.kazem");
        public AddMovie()
        {
            InitializeComponent();

        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                
            }

        }*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("Add_Movie", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@place", txtPlace.Text);
            cmd.Parameters.AddWithValue("@startdate", dTPSdate.Value);
            cmd.Parameters.AddWithValue("@time", txtTime.Text);
           // cmd.Parameters.AddWithValue("@image", pictureBox1.Image);
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
            cmd.Parameters.AddWithValue("@enddate", dTPEdate.Value);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();
            AdminSearch admin = new AdminSearch();
            this.Hide();
            admin.Show();

        }
      /*  private void button2_Click_2(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);

            }
        }*/
        
    }
}
