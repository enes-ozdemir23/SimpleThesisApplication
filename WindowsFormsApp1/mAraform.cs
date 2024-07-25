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
    public partial class mAraform : Form
    {
        public mAraform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            detayliAra d = new detayliAra();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            arama a = new arama();
            a.Show();
        }
    }
}
