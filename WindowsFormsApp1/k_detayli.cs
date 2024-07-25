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
    public partial class k_detayli : Form
    {
        SqlConnection conn1 = new SqlConnection(@"Data Source=LAPTOP-SU16M9I9\VT_SQL;Initial Catalog=project;Integrated Security=True");

        public k_detayli()
        {
            InitializeComponent();
        }

        private void k_detayli_Load(object sender, EventArgs e)
        {

        }

        private void ARA_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select tez_id, tez_adi, tez_konu, tez_tarih, tez_dil, tez_tur,
                                            universite_adi, fakulte_adi, bolum_adi, danisman_adi, yazar_adi
                                            from tez t join yazar y on t.yazar_id = y.yazar_id join
                                            danisman d on t.danisman_id = d.danisman_id join 
                                            bolum b on t.bolum_id = b.bolum_id join
                                            fakulte f on t.fakulte_id = f.fakulte_id join
                                            universite u on t.universite_id = u.universite_id 
                                             where tez_adi like '%' + @a + '%' or
                                             universite_adi like '%' + @b + '%' or
                                             bolum_adi like '%' + @c + '%' or 
                                             tez_tur like '%' + @d + '%' or
                                             yazar_adi like '%' + @e + '%' or
                                             danisman_adi like '%' + @f + '%' or
                                             tez_konu like '%' + @g + '%' or
                                             fakulte_adi like '%' + @h + '%' 
                                             ", conn1);


            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@a", tadi.Text);
            cmd.Parameters.AddWithValue("@b", tuni.Text);
            cmd.Parameters.AddWithValue("@c", tbolum.Text);
            cmd.Parameters.AddWithValue("@d", ttur.Text);
            cmd.Parameters.AddWithValue("@e", tyazar.Text);
            cmd.Parameters.AddWithValue("@f", tdanisman.Text);
            cmd.Parameters.AddWithValue("@g", tkonu.Text);
            cmd.Parameters.AddWithValue("@h", tfakulte.Text);

            DataTable dt = new DataTable();

            conn1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            conn1.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pdfOp p = new pdfOp();
            p.Show();
        }
    }
}
