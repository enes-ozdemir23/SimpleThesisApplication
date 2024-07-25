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
    public partial class AramaAraForm : Form
    {
        public AramaAraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k_detayli k = new k_detayli();
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k_arama k = new k_arama();
            k.Show();

        }
    }
}
