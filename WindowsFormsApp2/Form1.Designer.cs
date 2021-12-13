namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.txtsoyadı = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.lnkSözleşme = new System.Windows.Forms.LinkLabel();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.chSözleşme = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nmkilo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmkilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.AutoSize = true;
            this.txtad.Location = new System.Drawing.Point(455, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(22, 13);
            this.txtad.TabIndex = 0;
            this.txtad.Text = "Adı";
            this.txtad.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.AutoSize = true;
            this.txtsoyad.Location = new System.Drawing.Point(446, 90);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(39, 13);
            this.txtsoyad.TabIndex = 1;
            this.txtsoyad.Text = "Soyadı";
            this.txtsoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Memleket";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre";
            this.label5.UseCompatibleTextRendering = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtadı
            // 
            this.txtadı.Location = new System.Drawing.Point(499, 57);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(100, 20);
            this.txtadı.TabIndex = 5;
            this.txtadı.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtsoyadı
            // 
            this.txtsoyadı.Location = new System.Drawing.Point(499, 87);
            this.txtsoyadı.Name = "txtsoyadı";
            this.txtsoyadı.Size = new System.Drawing.Size(100, 20);
            this.txtsoyadı.TabIndex = 6;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(499, 118);
            this.txttelefon.Mask = "(599) 000-0000";
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(100, 20);
            this.txttelefon.TabIndex = 7;
            // 
            // txtsehir
            // 
            this.txtsehir.AutoCompleteCustomSource.AddRange(new string[] {
            "Bartın",
            "Ankara",
            "Bolu",
            "Van",
            "İzmir",
            "Hakkari",
            "Şırnak"});
            this.txtsehir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsehir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsehir.Location = new System.Drawing.Point(499, 149);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(100, 20);
            this.txtsehir.TabIndex = 8;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(499, 184);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '$';
            this.txtŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtŞifre.TabIndex = 9;
            // 
            // lnkSözleşme
            // 
            this.lnkSözleşme.AutoSize = true;
            this.lnkSözleşme.LinkColor = System.Drawing.Color.Red;
            this.lnkSözleşme.Location = new System.Drawing.Point(446, 280);
            this.lnkSözleşme.Name = "lnkSözleşme";
            this.lnkSözleşme.Size = new System.Drawing.Size(198, 13);
            this.lnkSözleşme.TabIndex = 10;
            this.lnkSözleşme.TabStop = true;
            this.lnkSözleşme.Text = "Sözleşme Metnini Okumak İçin Tıklayınız";
            this.lnkSözleşme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SözleşmeMetniOku);
            // 
            // btnTamam
            // 
            this.btnTamam.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnTamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamam.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTamam.Image = global::WindowsFormsApp2.Properties.Resources.bü_logo;
            this.btnTamam.Location = new System.Drawing.Point(573, 352);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(90, 55);
            this.btnTamam.TabIndex = 12;
            this.btnTamam.Text = "Anlaşmayı Kabul Ediyorum";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btntamam_click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.PeachPuff;
            this.btniptal.Cursor = System.Windows.Forms.Cursors.No;
            this.btniptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniptal.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btniptal.Image = global::WindowsFormsApp2.Properties.Resources.bü_logo;
            this.btniptal.Location = new System.Drawing.Point(439, 352);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(88, 55);
            this.btniptal.TabIndex = 11;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = false;
            // 
            // chSözleşme
            // 
            this.chSözleşme.AutoSize = true;
            this.chSözleşme.Location = new System.Drawing.Point(458, 305);
            this.chSözleşme.Name = "chSözleşme";
            this.chSözleşme.Size = new System.Drawing.Size(149, 17);
            this.chSözleşme.TabIndex = 13;
            this.chSözleşme.Text = "Anlaşmayı Kabul Ediyorum";
            this.chSözleşme.UseVisualStyleBackColor = true;
            this.chSözleşme.CheckedChanged += new System.EventHandler(this.SözleşmeKabul);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 178);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.kuş;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Resim Eklemek İçin Tıklayınız";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(33, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 57);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bay";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(99, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bayan";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 352);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // nmkilo
            // 
            this.nmkilo.Location = new System.Drawing.Point(89, 376);
            this.nmkilo.Name = "nmkilo";
            this.nmkilo.Size = new System.Drawing.Size(45, 20);
            this.nmkilo.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(89, 402);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Boy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ağırlık";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kardeş Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "cm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "kg";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(499, 218);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 20);
            this.dttarih.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Doğum Tarihi";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.nmkilo);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chSözleşme);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.lnkSözleşme);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtsehir);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtsoyadı);
            this.Controls.Add(this.txtadı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmkilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtad;
        private System.Windows.Forms.Label txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.TextBox txtsoyadı;
        private System.Windows.Forms.MaskedTextBox txttelefon;
        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.LinkLabel lnkSözleşme;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.CheckBox chSözleşme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nmkilo;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

