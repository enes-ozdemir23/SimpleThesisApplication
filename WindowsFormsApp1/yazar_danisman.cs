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



namespace WindowsFormsApp1
{
    public partial class yazar_danisman : Form
    {
        SqlConnection conn1 = new SqlConnection(@"Data Source=LAPTOP-SU16M9I9\VT_SQL;Initial Catalog=project;Integrated Security=True");

        public yazar_danisman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM danisman",conn1);
            conn1.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            conn1.Close();
          
            
            SqlCommand cmd1 = new SqlCommand(@"insert into danisman(danisman_id,danisman_adi)
                values(@danisman_id,@danisman_adi)", conn1);


            cmd1.Parameters.AddWithValue("@danisman_id", ++count);
            cmd1.Parameters.AddWithValue("@danisman_adi", txtDanismanEkle.Text);

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();

            MessageBox.Show("ekleme tamam");

            


        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM yazar", conn1);
            conn1.Open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            conn1.Close();


            SqlCommand cmd1 = new SqlCommand(@"insert into yazar(yazar_id,yazar_adi)
                values(@yazar_id,@yazar_adi)", conn1);


            cmd1.Parameters.AddWithValue("@yazar_id", ++count);
            cmd1.Parameters.AddWithValue("@yazar_adi", txtYazarEkle.Text);

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();

            MessageBox.Show("ekleme tamam");

        }

        private void labelYazar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            yazar_danisman yd = new yazar_danisman();
            this.Close();
            Application.Exit();
        }

        private void yazar_danisman_Load(object sender, EventArgs e)
        {

        }
    }
}
