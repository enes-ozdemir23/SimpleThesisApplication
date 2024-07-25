namespace WindowsFormsApp1
{
    partial class tezEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tezEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.cmbUniversite = new System.Windows.Forms.ComboBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTezEkle = new System.Windows.Forms.Button();
            this.cmbDanisman = new System.Windows.Forms.ComboBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtDil = new System.Windows.Forms.TextBox();
            this.projectDataSet = new WindowsFormsApp1.projectDataSet();
            this.universiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universiteTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.universiteTableAdapter();
            this.fKfakulteuniversiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakulteTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.fakulteTableAdapter();
            this.fKbolumfakulteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.bolumTableAdapter();
            this.danismanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danismanTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.danismanTableAdapter();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.yazarTableAdapter();
            this.danismanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfakulteuniversiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbolumfakulteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tez Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tez Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 106);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 149);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danışman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(-2, 235);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Üniversite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-4, 278);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fakülte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1, 321);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bölüm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1, 192);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tez Tür";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(-4, 364);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tez Dil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1, 407);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tarih";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(133, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(520, 20);
            this.txtAd.TabIndex = 12;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(133, 63);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(520, 20);
            this.txtKonu.TabIndex = 13;
            // 
            // cmbUniversite
            // 
            this.cmbUniversite.DataSource = this.universiteBindingSource;
            this.cmbUniversite.DisplayMember = "universite_adi";
            this.cmbUniversite.FormattingEnabled = true;
            this.cmbUniversite.Location = new System.Drawing.Point(133, 237);
            this.cmbUniversite.Name = "cmbUniversite";
            this.cmbUniversite.Size = new System.Drawing.Size(247, 21);
            this.cmbUniversite.TabIndex = 18;
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.DataSource = this.fKfakulteuniversiteBindingSource;
            this.cmbFakulte.DisplayMember = "fakulte_adi";
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(133, 280);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(247, 21);
            this.cmbFakulte.TabIndex = 19;
            // 
            // cmbBolum
            // 
            this.cmbBolum.DataSource = this.fKbolumfakulteBindingSource;
            this.cmbBolum.DisplayMember = "bolum_adi";
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(133, 320);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(247, 21);
            this.cmbBolum.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 407);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btnTezEkle
            // 
            this.btnTezEkle.BackColor = System.Drawing.Color.Aqua;
            this.btnTezEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTezEkle.Location = new System.Drawing.Point(650, 376);
            this.btnTezEkle.Name = "btnTezEkle";
            this.btnTezEkle.Size = new System.Drawing.Size(190, 51);
            this.btnTezEkle.TabIndex = 22;
            this.btnTezEkle.Text = "TEZ EKLE";
            this.btnTezEkle.UseVisualStyleBackColor = false;
            this.btnTezEkle.Click += new System.EventHandler(this.btnTezEkle_Click);
            // 
            // cmbDanisman
            // 
            this.cmbDanisman.DataSource = this.danismanBindingSource1;
            this.cmbDanisman.DisplayMember = "danisman_adi";
            this.cmbDanisman.FormattingEnabled = true;
            this.cmbDanisman.Location = new System.Drawing.Point(133, 151);
            this.cmbDanisman.Name = "cmbDanisman";
            this.cmbDanisman.Size = new System.Drawing.Size(247, 21);
            this.cmbDanisman.TabIndex = 23;
            // 
            // cmbYazar
            // 
            this.cmbYazar.DataSource = this.yazarBindingSource;
            this.cmbYazar.DisplayMember = "yazar_adi";
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(133, 105);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(247, 21);
            this.cmbYazar.TabIndex = 24;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(133, 194);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(247, 20);
            this.txtTur.TabIndex = 26;
            // 
            // txtDil
            // 
            this.txtDil.Location = new System.Drawing.Point(133, 366);
            this.txtDil.Name = "txtDil";
            this.txtDil.Size = new System.Drawing.Size(247, 20);
            this.txtDil.TabIndex = 27;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universiteBindingSource
            // 
            this.universiteBindingSource.DataMember = "universite";
            this.universiteBindingSource.DataSource = this.projectDataSet;
            // 
            // universiteTableAdapter
            // 
            this.universiteTableAdapter.ClearBeforeFill = true;
            // 
            // fKfakulteuniversiteBindingSource
            // 
            this.fKfakulteuniversiteBindingSource.DataMember = "FK_fakulte_universite";
            this.fKfakulteuniversiteBindingSource.DataSource = this.universiteBindingSource;
            // 
            // fakulteTableAdapter
            // 
            this.fakulteTableAdapter.ClearBeforeFill = true;
            // 
            // fKbolumfakulteBindingSource
            // 
            this.fKbolumfakulteBindingSource.DataMember = "FK_bolum_fakulte";
            this.fKbolumfakulteBindingSource.DataSource = this.fKfakulteuniversiteBindingSource;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // danismanBindingSource
            // 
            this.danismanBindingSource.DataMember = "danisman";
            this.danismanBindingSource.DataSource = this.projectDataSet;
            // 
            // danismanTableAdapter
            // 
            this.danismanTableAdapter.ClearBeforeFill = true;
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataMember = "yazar";
            this.yazarBindingSource.DataSource = this.projectDataSet;
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // danismanBindingSource1
            // 
            this.danismanBindingSource1.DataMember = "danisman";
            this.danismanBindingSource1.DataSource = this.projectDataSet;
            // 
            // tezEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(841, 430);
            this.Controls.Add(this.txtDil);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.cmbDanisman);
            this.Controls.Add(this.btnTezEkle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.cmbFakulte);
            this.Controls.Add(this.cmbUniversite);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tezEkle";
            this.Text = "tezEkle";
            this.Load += new System.EventHandler(this.tezEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfakulteuniversiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbolumfakulteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.ComboBox cmbUniversite;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTezEkle;
        private System.Windows.Forms.ComboBox cmbDanisman;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtDil;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource universiteBindingSource;
        private projectDataSetTableAdapters.universiteTableAdapter universiteTableAdapter;
        private System.Windows.Forms.BindingSource fKfakulteuniversiteBindingSource;
        private projectDataSetTableAdapters.fakulteTableAdapter fakulteTableAdapter;
        private System.Windows.Forms.BindingSource fKbolumfakulteBindingSource;
        private projectDataSetTableAdapters.bolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.BindingSource danismanBindingSource;
        private projectDataSetTableAdapters.danismanTableAdapter danismanTableAdapter;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private projectDataSetTableAdapters.yazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.BindingSource danismanBindingSource1;
    }
}