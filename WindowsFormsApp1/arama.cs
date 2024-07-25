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
    public partial class arama : Form
    {
        SqlConnection conn1 = new SqlConnection(@"Data Source=LAPTOP-SU16M9I9\VT_SQL;Initial Catalog=project;Integrated Security=True");
        public arama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"select tez_id, tez_adi, tez_konu, tez_tarih, tez_dil, tez_tur,
                                            universite_adi, fakulte_adi, bolum_adi, danisman_adi, yazar_adi
                                            from tez t join yazar y on t.yazar_id = y.yazar_id join
                                            danisman d on t.danisman_id = d.danisman_id join 
                                            bolum b on t.bolum_id = b.bolum_id join
                                            fakulte f on t.fakulte_id = f.fakulte_id join
                                            universite u on t.universite_id = u.universite_id 
                                             where tez_adi like '%' + @a + '%' and
                                             universite_adi like '%' + @b + '%' and
                                             bolum_adi like '%' + @c + '%' and
                                             tez_tur like '%' + @d + '%'
                                             ", conn1);
          

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@a", textAd.Text);
            cmd.Parameters.AddWithValue("@b", textUniversite.Text);
            cmd.Parameters.AddWithValue("@c", textBolum.Text);
            cmd.Parameters.AddWithValue("@d", textTur.Text);

            DataTable dt = new DataTable();

            conn1.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            conn1.Close();
            dataGridView1.DataSource = dt;

          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pdfOp p = new pdfOp();
            p.Show();
        }

        private void arama_Load(object sender, EventArgs e)
        {

        }
    }
}
