namespace PointOfSales
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
            this.tb_namakonsumen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_kendaraan = new System.Windows.Forms.ComboBox();
            this.rb_tunai = new System.Windows.Forms.RadioButton();
            this.rb_kredit = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lv_datapenjualan = new System.Windows.Forms.ListView();
            this.ch_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_tglpenjualan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_namakonsumen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_merk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_diskon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_hargajual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_tgl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_namakonsumen
            // 
            this.tb_namakonsumen.Location = new System.Drawing.Point(129, 34);
            this.tb_namakonsumen.Name = "tb_namakonsumen";
            this.tb_namakonsumen.Size = new System.Drawing.Size(150, 20);
            this.tb_namakonsumen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Konsumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Penjualan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input Penjualan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kendaraan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jenis Pembayaran";
            // 
            // cmb_kendaraan
            // 
            this.cmb_kendaraan.FormattingEnabled = true;
            this.cmb_kendaraan.Location = new System.Drawing.Point(129, 109);
            this.cmb_kendaraan.Name = "cmb_kendaraan";
            this.cmb_kendaraan.Size = new System.Drawing.Size(150, 21);
            this.cmb_kendaraan.TabIndex = 6;
            // 
            // rb_tunai
            // 
            this.rb_tunai.AutoSize = true;
            this.rb_tunai.Location = new System.Drawing.Point(129, 144);
            this.rb_tunai.Name = "rb_tunai";
            this.rb_tunai.Size = new System.Drawing.Size(52, 17);
            this.rb_tunai.TabIndex = 7;
            this.rb_tunai.TabStop = true;
            this.rb_tunai.Text = "Tunai";
            this.rb_tunai.UseVisualStyleBackColor = true;
            // 
            // rb_kredit
            // 
            this.rb_kredit.AutoSize = true;
            this.rb_kredit.Location = new System.Drawing.Point(209, 144);
            this.rb_kredit.Name = "rb_kredit";
            this.rb_kredit.Size = new System.Drawing.Size(52, 17);
            this.rb_kredit.TabIndex = 8;
            this.rb_kredit.TabStop = true;
            this.rb_kredit.Text = "Kredit";
            this.rb_kredit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data Penjualan";
            // 
            // lv_datapenjualan
            // 
            this.lv_datapenjualan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_no,
            this.ch_tglpenjualan,
            this.ch_namakonsumen,
            this.ch_merk,
            this.ch_harga,
            this.ch_diskon,
            this.ch_hargajual});
            this.lv_datapenjualan.Location = new System.Drawing.Point(2, 236);
            this.lv_datapenjualan.Name = "lv_datapenjualan";
            this.lv_datapenjualan.Size = new System.Drawing.Size(659, 96);
            this.lv_datapenjualan.TabIndex = 10;
            this.lv_datapenjualan.UseCompatibleStateImageBehavior = false;
            this.lv_datapenjualan.View = System.Windows.Forms.View.Details;
            // 
            // ch_no
            // 
            this.ch_no.Text = "No";
            this.ch_no.Width = 42;
            // 
            // ch_tglpenjualan
            // 
            this.ch_tglpenjualan.Text = "Tanggal Penjualan";
            this.ch_tglpenjualan.Width = 114;
            // 
            // ch_namakonsumen
            // 
            this.ch_namakonsumen.Text = "Nama Konsumen";
            this.ch_namakonsumen.Width = 106;
            // 
            // ch_merk
            // 
            this.ch_merk.Text = "Merk";
            this.ch_merk.Width = 82;
            // 
            // ch_harga
            // 
            this.ch_harga.Text = "Harga";
            this.ch_harga.Width = 85;
            // 
            // ch_diskon
            // 
            this.ch_diskon.Text = "Diskon";
            this.ch_diskon.Width = 90;
            // 
            // ch_hargajual
            // 
            this.ch_hargajual.Text = "Harga Jual";
            this.ch_hargajual.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(351, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identitas Diri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Npm : 141524011";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nama : Tuliskan Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email : ifan.dhani.tif414@polban.ac.id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_tgl
            // 
            this.tb_tgl.Location = new System.Drawing.Point(129, 72);
            this.tb_tgl.Name = "tb_tgl";
            this.tb_tgl.Size = new System.Drawing.Size(150, 20);
            this.tb_tgl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 336);
            this.Controls.Add(this.tb_tgl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv_datapenjualan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_kredit);
            this.Controls.Add(this.rb_tunai);
            this.Controls.Add(this.cmb_kendaraan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_namakonsumen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_namakonsumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_kendaraan;
        private System.Windows.Forms.RadioButton rb_tunai;
        private System.Windows.Forms.RadioButton rb_kredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lv_datapenjualan;
        private System.Windows.Forms.ColumnHeader ch_no;
        private System.Windows.Forms.ColumnHeader ch_tglpenjualan;
        private System.Windows.Forms.ColumnHeader ch_namakonsumen;
        private System.Windows.Forms.ColumnHeader ch_merk;
        private System.Windows.Forms.ColumnHeader ch_harga;
        private System.Windows.Forms.ColumnHeader ch_diskon;
        private System.Windows.Forms.ColumnHeader ch_hargajual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_tgl;
    }
}

