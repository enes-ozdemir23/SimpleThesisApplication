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
    public partial class y_goruntule : Form
    {
        public y_goruntule()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-SU16M9I9\VT_SQL;Initial Catalog=project;Integrated Security=True");
        private int tez_id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void m_goruntule_Load(object sender, EventArgs e)

        {
            // TODO: Bu kod satırı 'projectDataSet.bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumTableAdapter.Fill(this.projectDataSet.bolum);
            // TODO: Bu kod satırı 'projectDataSet.fakulte' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.fakulteTableAdapter.Fill(this.projectDataSet.fakulte);
            // TODO: Bu kod satırı 'projectDataSet.universite' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.universiteTableAdapter.Fill(this.projectDataSet.universite);
            // TODO: Bu kod satırı 'projectDataSet.danisman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.danismanTableAdapter.Fill(this.projectDataSet.danisman);
            // TODO: Bu kod satırı 'projectDataSet.yazar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazarTableAdapter.Fill(this.projectDataSet.yazar);



            SqlCommand cmd = new SqlCommand(@"select tez_id, tez_adi, tez_konu, tez_tarih, tez_dil, tez_tur,
                                            universite_adi, fakulte_adi, bolum_adi, danisman_adi, yazar_adi
                                            from tez t join yazar y on t.yazar_id = y.yazar_id join
                                            danisman d on t.danisman_id = d.danisman_id join
                                            bolum b on t.bolum_id = b.bolum_id join
                                            fakulte f on t.fakulte_id = f.fakulte_id join
                                            universite u on t.universite_id = u.universite_id
                                             ", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tez_id > 0)
            {
                SqlCommand cmd = new SqlCommand(@"delete from tez where tez_id=@tez_id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tez_id", this.tez_id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Başarılı silme işlemi");

            }
            else
                MessageBox.Show("Başarısız silme işlemi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tez_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtKonu.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            txtDil.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tez_id > 0)
            {



                SqlCommand cmd = new SqlCommand(@"update tez set tez_adi=@tez_adi,tez_konu=@tez_konu,tez_tarih=@tez_tarih,tez_dil=@tez_dil,
                                             tez_tur = @tez_tur, universite_id = @universite_id, fakulte_id = @fakulte_id, bolum_id = @bolum_id,
                                             danisman_id = @danisman_id, yazar_id = @yazar_id where tez_id =@tez_id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tez_id", this.tez_id);
                cmd.Parameters.AddWithValue("@tez_adi", txtAd.Text);
                cmd.Parameters.AddWithValue("@tez_konu", txtKonu.Text);
                cmd.Parameters.AddWithValue("@tez_tarih", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@tez_dil", txtDil.Text);
                cmd.Parameters.AddWithValue("@tez_tur", txtTur.Text);
                cmd.Parameters.AddWithValue("@universite_id", ++cmbUniversite.SelectedIndex);
                cmd.Parameters.AddWithValue("@fakulte_id", ++cmbFakulte.SelectedIndex);
                cmd.Parameters.AddWithValue("@bolum_id", ++cmbBolum.SelectedIndex);
                cmd.Parameters.AddWithValue("@danisman_id", ++cmbDanisman.SelectedIndex);
                cmd.Parameters.AddWithValue("@yazar_id", ++cmbYazar.SelectedIndex);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Güncelleme başarılı");


            }
            else
                MessageBox.Show("Güncelleme Hatası");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pdfOp p = new pdfOp();
            p.Show();
        }
    }
}

