namespace WindowsFormsApp1
{
    partial class yazar_danisman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yazar_danisman));
            this.btnDanismanEkle = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.txtDanismanEkle = new System.Windows.Forms.TextBox();
            this.txtYazarEkle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDanismanEkle
            // 
            this.btnDanismanEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnDanismanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDanismanEkle.Location = new System.Drawing.Point(677, 28);
            this.btnDanismanEkle.Name = "btnDanismanEkle";
            this.btnDanismanEkle.Size = new System.Drawing.Size(125, 58);
            this.btnDanismanEkle.TabIndex = 0;
            this.btnDanismanEkle.Text = "Danisman Ekle";
            this.btnDanismanEkle.UseVisualStyleBackColor = false;
            this.btnDanismanEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnYazarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarEkle.Location = new System.Drawing.Point(677, 182);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(125, 67);
            this.btnYazarEkle.TabIndex = 1;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = false;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // txtDanismanEkle
            // 
            this.txtDanismanEkle.Location = new System.Drawing.Point(79, 85);
            this.txtDanismanEkle.Name = "txtDanismanEkle";
            this.txtDanismanEkle.Size = new System.Drawing.Size(235, 20);
            this.txtDanismanEkle.TabIndex = 2;
            // 
            // txtYazarEkle
            // 
            this.txtYazarEkle.Location = new System.Drawing.Point(79, 312);
            this.txtYazarEkle.Name = "txtYazarEkle";
            this.txtYazarEkle.Size = new System.Drawing.Size(235, 20);
            this.txtYazarEkle.TabIndex = 3;
            // 
            // yazar_danisman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYazarEkle);
            this.Controls.Add(this.txtDanismanEkle);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.btnDanismanEkle);
            this.Name = "yazar_danisman";
            this.Text = "yazar_danisman";
            this.Load += new System.EventHandler(this.yazar_danisman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDanismanEkle;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.TextBox txtDanismanEkle;
        private System.Windows.Forms.TextBox txtYazarEkle;
    }
}