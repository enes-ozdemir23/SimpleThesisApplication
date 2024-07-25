using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class yAraform : Form
    {
        public yAraform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tezEkle t = new tezEkle();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            y_goruntule y = new y_goruntule();
            y.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yazar_danisman yd = new yazar_danisman();
            yd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AramaAraForm a = new AramaAraForm();
            a.Show();
        }
    }
}
