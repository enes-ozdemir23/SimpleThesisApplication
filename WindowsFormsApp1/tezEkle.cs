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
    public partial class tezEkle : Form
    {
        SqlConnection conn1 = new SqlConnection(@"Data Source=LAPTOP-SU16M9I9\VT_SQL;Initial Catalog=project;Integrated Security=True");
    

        public tezEkle()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTezEkle_Click(object sender, EventArgs e)
        {
            //int index = cmbUniversite.SelectedIndex;
            SqlCommand cmd1 = new SqlCommand(@"insert into tez(tez_adi, tez_konu, tez_tarih, tez_dil, tez_tur,
                                                universite_id, fakulte_id, bolum_id, danisman_id, yazar_id) values(
                                                @tez_adi, @tez_konu, @tez_tarih, @tez_dil, @tez_tur,
                                                @universite_id, @fakulte_id, @bolum_id, @danisman_id, @yazar_id)" , conn1);

            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@tez_adi", txtAd.Text);
            cmd1.Parameters.AddWithValue("@tez_konu", txtKonu.Text);
            cmd1.Parameters.AddWithValue("@tez_tarih", dateTimePicker1.Value.Date);
            cmd1.Parameters.AddWithValue("@tez_dil", txtDil.Text);
            cmd1.Parameters.AddWithValue("@tez_tur", txtTur.Text);
            cmd1.Parameters.AddWithValue("@universite_id", cmbUniversite.SelectedIndex+1);
            cmd1.Parameters.AddWithValue("@fakulte_id", cmbFakulte.SelectedIndex+1);
            cmd1.Parameters.AddWithValue("@bolum_id", cmbBolum.SelectedIndex+1);
            cmd1.Parameters.AddWithValue("@danisman_id", cmbDanisman.SelectedIndex+1);
            cmd1.Parameters.AddWithValue("@yazar_id", cmbYazar.SelectedIndex+1
                );

            conn1.Open();

            cmd1.ExecuteNonQuery();

            conn1.Close();

            y_goruntule y = new y_goruntule();
            y.Show();
        }

        private void tezEkle_Load(object sender, EventArgs e)
        {
           

            this.universiteTableAdapter.Fill(this.projectDataSet.universite);
            this.fakulteTableAdapter.Fill(this.projectDataSet.fakulte);
            this.bolumTableAdapter.Fill(this.projectDataSet.bolum);
            this.danismanTableAdapter.Fill(this.projectDataSet.danisman);
            this.yazarTableAdapter.Fill(this.projectDataSet.yazar);



        }
    }
}
