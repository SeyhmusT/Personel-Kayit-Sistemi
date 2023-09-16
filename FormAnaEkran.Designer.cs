namespace Personel_Kayit
{
    partial class FormAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaEkran));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbsehirler = new System.Windows.Forms.ComboBox();
            this.button_evli = new System.Windows.Forms.RadioButton();
            this.button_bekar = new System.Windows.Forms.RadioButton();
            this.mskmaas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmeslek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbsehirler);
            this.groupBox1.Controls.Add(this.button_evli);
            this.groupBox1.Controls.Add(this.button_bekar);
            this.groupBox1.Controls.Add(this.mskmaas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 384);
            this.groupBox1.TabIndex = 4545;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(132, 334);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(148, 29);
            this.txtmeslek.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Meslek:";
            // 
            // cmbsehirler
            // 
            this.cmbsehirler.FormattingEnabled = true;
            this.cmbsehirler.Location = new System.Drawing.Point(132, 194);
            this.cmbsehirler.Name = "cmbsehirler";
            this.cmbsehirler.Size = new System.Drawing.Size(148, 31);
            this.cmbsehirler.TabIndex = 4;
            // 
            // button_evli
            // 
            this.button_evli.AutoSize = true;
            this.button_evli.Location = new System.Drawing.Point(132, 294);
            this.button_evli.Name = "button_evli";
            this.button_evli.Size = new System.Drawing.Size(60, 27);
            this.button_evli.TabIndex = 6;
            this.button_evli.TabStop = true;
            this.button_evli.Text = "Evli";
            this.button_evli.UseVisualStyleBackColor = true;
            this.button_evli.CheckedChanged += new System.EventHandler(this.button_evli_CheckedChanged);
            // 
            // button_bekar
            // 
            this.button_bekar.AutoSize = true;
            this.button_bekar.Location = new System.Drawing.Point(206, 294);
            this.button_bekar.Name = "button_bekar";
            this.button_bekar.Size = new System.Drawing.Size(77, 27);
            this.button_bekar.TabIndex = 7;
            this.button_bekar.TabStop = true;
            this.button_bekar.Text = "Bekar";
            this.button_bekar.UseVisualStyleBackColor = true;
            this.button_bekar.CheckedChanged += new System.EventHandler(this.button_bekar_CheckedChanged);
            // 
            // mskmaas
            // 
            this.mskmaas.Location = new System.Drawing.Point(132, 244);
            this.mskmaas.Mask = "0000";
            this.mskmaas.Name = "mskmaas";
            this.mskmaas.Size = new System.Drawing.Size(148, 29);
            this.mskmaas.TabIndex = 5;
            this.mskmaas.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personel Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel İd:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(132, 150);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(148, 29);
            this.txtsoyad.TabIndex = 3;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(132, 109);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(148, 29);
            this.txtad.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(132, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 29);
            this.txtid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(74, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 282);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(132, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 255);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(132, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngrafikler);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 384);
            this.groupBox2.TabIndex = 222222;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btngrafikler
            // 
            this.btngrafikler.Location = new System.Drawing.Point(41, 323);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(159, 37);
            this.btngrafikler.TabIndex = 6;
            this.btngrafikler.Text = "Grafikler";
            this.btngrafikler.UseVisualStyleBackColor = true;
            this.btngrafikler.Click += new System.EventHandler(this.btngrafikler_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(41, 236);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(159, 37);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(41, 101);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(159, 37);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(41, 280);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(159, 37);
            this.btnistatistik.TabIndex = 5;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(41, 146);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(159, 37);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(41, 190);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(159, 37);
            this.btnguncelle.TabIndex = 2222;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(41, 58);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(159, 37);
            this.btnlistele.TabIndex = 222;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Location = new System.Drawing.Point(12, 402);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(937, 255);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 227);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(74, 390);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(305, 282);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(132, 390);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(182, 255);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(132, 390);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(182, 255);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(790, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 222223;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FormAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(961, 644);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormAnaEkran";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbsehirler;
        private System.Windows.Forms.RadioButton button_evli;
        private System.Windows.Forms.RadioButton button_bekar;
        private System.Windows.Forms.MaskedTextBox mskmaas;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

