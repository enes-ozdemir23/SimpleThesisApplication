using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class pdfOp : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public pdfOp()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
        }

        private void pdfOp_Load(object sender, EventArgs e)
        {

        }

        private void dosyaİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                openfile(dialog.FileName);
            }

        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pd = PdfDocument.Load(stream);
            pdf.Document = pd;

        }
    }
}
