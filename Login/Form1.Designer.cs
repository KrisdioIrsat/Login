namespace crud
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tombol_Hapus = new System.Windows.Forms.Button();
            this.Tombol_Ubah = new System.Windows.Forms.Button();
            this.Tombol_Simpan = new System.Windows.Forms.Button();
            this.NoHp = new System.Windows.Forms.TextBox();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Jabatan = new System.Windows.Forms.ComboBox();
            this.NamaKaryawan = new System.Windows.Forms.TextBox();
            this.NIK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tombol_Cari = new System.Windows.Forms.Button();
            this.CariData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1203, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Data Karyawan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(6, 21);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(1191, 231);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tombol_Hapus);
            this.groupBox2.Controls.Add(this.Tombol_Ubah);
            this.groupBox2.Controls.Add(this.Tombol_Simpan);
            this.groupBox2.Controls.Add(this.NoHp);
            this.groupBox2.Controls.Add(this.Alamat);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Jabatan);
            this.groupBox2.Controls.Add(this.NamaKaryawan);
            this.groupBox2.Controls.Add(this.NIK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Karyawan";
            // 
            // Tombol_Hapus
            // 
            this.Tombol_Hapus.Location = new System.Drawing.Point(0, 298);
            this.Tombol_Hapus.Name = "Tombol_Hapus";
            this.Tombol_Hapus.Size = new System.Drawing.Size(704, 47);
            this.Tombol_Hapus.TabIndex = 14;
            this.Tombol_Hapus.Text = "Hapus";
            this.Tombol_Hapus.UseVisualStyleBackColor = true;
            // 
            // Tombol_Ubah
            // 
            this.Tombol_Ubah.Location = new System.Drawing.Point(0, 245);
            this.Tombol_Ubah.Name = "Tombol_Ubah";
            this.Tombol_Ubah.Size = new System.Drawing.Size(704, 47);
            this.Tombol_Ubah.TabIndex = 13;
            this.Tombol_Ubah.Text = "Ubah";
            this.Tombol_Ubah.UseVisualStyleBackColor = true;
            // 
            // Tombol_Simpan
            // 
            this.Tombol_Simpan.Location = new System.Drawing.Point(2, 192);
            this.Tombol_Simpan.Name = "Tombol_Simpan";
            this.Tombol_Simpan.Size = new System.Drawing.Size(704, 47);
            this.Tombol_Simpan.TabIndex = 12;
            this.Tombol_Simpan.Text = "Simpan";
            this.Tombol_Simpan.UseVisualStyleBackColor = true;
            // 
            // NoHp
            // 
            this.NoHp.Location = new System.Drawing.Point(519, 135);
            this.NoHp.Name = "NoHp";
            this.NoHp.Size = new System.Drawing.Size(187, 22);
            this.NoHp.TabIndex = 11;
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(519, 35);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(187, 22);
            this.Alamat.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(519, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(187, 22);
            this.Email.TabIndex = 9;
            this.Email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nomor Telepon";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // Jabatan
            // 
            this.Jabatan.FormattingEnabled = true;
            this.Jabatan.Location = new System.Drawing.Point(133, 135);
            this.Jabatan.Name = "Jabatan";
            this.Jabatan.Size = new System.Drawing.Size(187, 24);
            this.Jabatan.TabIndex = 5;
            // 
            // NamaKaryawan
            // 
            this.NamaKaryawan.Location = new System.Drawing.Point(133, 87);
            this.NamaKaryawan.Name = "NamaKaryawan";
            this.NamaKaryawan.Size = new System.Drawing.Size(187, 22);
            this.NamaKaryawan.TabIndex = 4;
            // 
            // NIK
            // 
            this.NIK.Location = new System.Drawing.Point(133, 38);
            this.NIK.Name = "NIK";
            this.NIK.Size = new System.Drawing.Size(187, 22);
            this.NIK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jabatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Karyawan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tombol_Cari);
            this.groupBox3.Controls.Add(this.CariData);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(809, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Tombol_Cari
            // 
            this.Tombol_Cari.Location = new System.Drawing.Point(30, 77);
            this.Tombol_Cari.Name = "Tombol_Cari";
            this.Tombol_Cari.Size = new System.Drawing.Size(355, 42);
            this.Tombol_Cari.TabIndex = 7;
            this.Tombol_Cari.Text = "Cari";
            this.Tombol_Cari.UseVisualStyleBackColor = true;
            // 
            // CariData
            // 
            this.CariData.Location = new System.Drawing.Point(154, 35);
            this.CariData.Name = "CariData";
            this.CariData.Size = new System.Drawing.Size(231, 22);
            this.CariData.TabIndex = 6;
            this.CariData.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cari Data";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 698);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " Crud ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Jabatan;
        private System.Windows.Forms.TextBox NamaKaryawan;
        private System.Windows.Forms.TextBox NIK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoHp;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox CariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button Tombol_Hapus;
        private System.Windows.Forms.Button Tombol_Ubah;
        private System.Windows.Forms.Button Tombol_Simpan;
        private System.Windows.Forms.Button Tombol_Cari;
    }
}

