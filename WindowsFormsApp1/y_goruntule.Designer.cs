namespace WindowsFormsApp1
{
    partial class y_goruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(y_goruntule));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDil = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.cmbDanisman = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.cmbUniversite = new System.Windows.Forms.ComboBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.projectDataSet = new WindowsFormsApp1.projectDataSet();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.yazarTableAdapter();
            this.danismanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danismanTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.danismanTableAdapter();
            this.universiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universiteTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.universiteTableAdapter();
            this.fKfakulteuniversiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakulteTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.fakulteTableAdapter();
            this.fKbolumfakulteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumTableAdapter = new WindowsFormsApp1.projectDataSetTableAdapters.bolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfakulteuniversiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbolumfakulteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(7, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(9, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDil
            // 
            this.txtDil.Location = new System.Drawing.Point(140, 352);
            this.txtDil.Name = "txtDil";
            this.txtDil.Size = new System.Drawing.Size(247, 20);
            this.txtDil.TabIndex = 47;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(140, 180);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(247, 20);
            this.txtTur.TabIndex = 46;
            // 
            // cmbYazar
            // 
            this.cmbYazar.DataSource = this.yazarBindingSource;
            this.cmbYazar.DisplayMember = "yazar_adi";
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(140, 91);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(247, 21);
            this.cmbYazar.TabIndex = 45;
            // 
            // cmbDanisman
            // 
            this.cmbDanisman.DataSource = this.danismanBindingSource;
            this.cmbDanisman.DisplayMember = "danisman_adi";
            this.cmbDanisman.FormattingEnabled = true;
            this.cmbDanisman.Location = new System.Drawing.Point(140, 137);
            this.cmbDanisman.Name = "cmbDanisman";
            this.cmbDanisman.Size = new System.Drawing.Size(247, 21);
            this.cmbDanisman.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 393);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // cmbBolum
            // 
            this.cmbBolum.DataSource = this.fKbolumfakulteBindingSource;
            this.cmbBolum.DisplayMember = "bolum_adi";
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(140, 306);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(247, 21);
            this.cmbBolum.TabIndex = 42;
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.DataSource = this.fKfakulteuniversiteBindingSource;
            this.cmbFakulte.DisplayMember = "fakulte_adi";
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(140, 266);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(247, 21);
            this.cmbFakulte.TabIndex = 41;
            // 
            // cmbUniversite
            // 
            this.cmbUniversite.DataSource = this.universiteBindingSource;
            this.cmbUniversite.DisplayMember = "universite_adi";
            this.cmbUniversite.FormattingEnabled = true;
            this.cmbUniversite.Location = new System.Drawing.Point(140, 223);
            this.cmbUniversite.Name = "cmbUniversite";
            this.cmbUniversite.Size = new System.Drawing.Size(247, 21);
            this.cmbUniversite.TabIndex = 40;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(140, 49);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(520, 20);
            this.txtKonu.TabIndex = 39;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(520, 20);
            this.txtAd.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 393);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tarih";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 350);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tez Dil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 178);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tez Tür";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 307);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Bölüm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Fakülte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 221);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Üniversite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Danışman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tez Konu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tez Adı";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(1195, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 69);
            this.button3.TabIndex = 49;
            this.button3.Text = "DOSYA AÇ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // danismanBindingSource
            // 
            this.danismanBindingSource.DataMember = "danisman";
            this.danismanBindingSource.DataSource = this.projectDataSet;
            // 
            // danismanTableAdapter
            // 
            this.danismanTableAdapter.ClearBeforeFill = true;
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
            // y_goruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1313, 651);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDil);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.cmbDanisman);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "y_goruntule";
            this.Text = "m_goruntule";
            this.Load += new System.EventHandler(this.m_goruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKfakulteuniversiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbolumfakulteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDil;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.ComboBox cmbDanisman;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.ComboBox cmbUniversite;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private projectDataSetTableAdapters.yazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.BindingSource danismanBindingSource;
        private projectDataSetTableAdapters.danismanTableAdapter danismanTableAdapter;
        private System.Windows.Forms.BindingSource universiteBindingSource;
        private projectDataSetTableAdapters.universiteTableAdapter universiteTableAdapter;
        private System.Windows.Forms.BindingSource fKfakulteuniversiteBindingSource;
        private projectDataSetTableAdapters.fakulteTableAdapter fakulteTableAdapter;
        private System.Windows.Forms.BindingSource fKbolumfakulteBindingSource;
        private projectDataSetTableAdapters.bolumTableAdapter bolumTableAdapter;
    }
}