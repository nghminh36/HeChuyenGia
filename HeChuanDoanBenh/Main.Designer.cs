namespace HeChuanDoanBenh
{
    partial class Main
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
            this.txt_cauhoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_batdau = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_huongdan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_quanliluat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.btn_giaithich = new System.Windows.Forms.Button();
            this.btn_tieptheo = new System.Windows.Forms.Button();
            this.rdb_khong = new System.Windows.Forms.RadioButton();
            this.rdb_co = new System.Windows.Forms.RadioButton();
            this.btn_xemhinh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_chuongtrinh = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbb_luachon = new System.Windows.Forms.ComboBox();
            this.txt_chuatri = new System.Windows.Forms.TextBox();
            this.btn_chuatri = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cauhoi
            // 
            this.txt_cauhoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cauhoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_cauhoi.Location = new System.Drawing.Point(16, 59);
            this.txt_cauhoi.Multiline = true;
            this.txt_cauhoi.Name = "txt_cauhoi";
            this.txt_cauhoi.Size = new System.Drawing.Size(503, 111);
            this.txt_cauhoi.TabIndex = 0;
            this.txt_cauhoi.TextChanged += new System.EventHandler(this.txt_cauhoi_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_batdau);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_cauhoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(478, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn gặp các triệu chứng nào sau đây?";
            // 
            // btn_batdau
            // 
            this.btn_batdau.Location = new System.Drawing.Point(16, 6);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.Size = new System.Drawing.Size(102, 34);
            this.btn_batdau.TabIndex = 3;
            this.btn_batdau.Text = "Bắt đầu ";
            this.btn_batdau.UseVisualStyleBackColor = true;
            this.btn_batdau.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_huongdan);
            this.groupBox3.Controls.Add(this.btn_thoat);
            this.groupBox3.Controls.Add(this.btn_quanliluat);
            this.groupBox3.Location = new System.Drawing.Point(16, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản Lí";
            // 
            // btn_huongdan
            // 
            this.btn_huongdan.Location = new System.Drawing.Point(309, 19);
            this.btn_huongdan.Name = "btn_huongdan";
            this.btn_huongdan.Size = new System.Drawing.Size(81, 37);
            this.btn_huongdan.TabIndex = 3;
            this.btn_huongdan.Text = "Hướng Dẫn";
            this.btn_huongdan.UseVisualStyleBackColor = true;
            this.btn_huongdan.Click += new System.EventHandler(this.btn_huongdan_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(406, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 37);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_quanliluat
            // 
            this.btn_quanliluat.Location = new System.Drawing.Point(212, 19);
            this.btn_quanliluat.Name = "btn_quanliluat";
            this.btn_quanliluat.Size = new System.Drawing.Size(81, 37);
            this.btn_quanliluat.TabIndex = 0;
            this.btn_quanliluat.Text = "Quản Lí Luật";
            this.btn_quanliluat.UseVisualStyleBackColor = true;
            this.btn_quanliluat.Click += new System.EventHandler(this.btn_quanliluat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lamlai);
            this.groupBox2.Controls.Add(this.btn_giaithich);
            this.groupBox2.Controls.Add(this.btn_tieptheo);
            this.groupBox2.Controls.Add(this.rdb_khong);
            this.groupBox2.Controls.Add(this.rdb_co);
            this.groupBox2.Location = new System.Drawing.Point(16, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn trả lời";
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.Location = new System.Drawing.Point(406, 28);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(81, 40);
            this.btn_lamlai.TabIndex = 4;
            this.btn_lamlai.Text = "Làm lại";
            this.btn_lamlai.UseVisualStyleBackColor = true;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // btn_giaithich
            // 
            this.btn_giaithich.Location = new System.Drawing.Point(309, 28);
            this.btn_giaithich.Name = "btn_giaithich";
            this.btn_giaithich.Size = new System.Drawing.Size(81, 40);
            this.btn_giaithich.TabIndex = 3;
            this.btn_giaithich.Text = "Giải thích";
            this.btn_giaithich.UseVisualStyleBackColor = true;
            this.btn_giaithich.Click += new System.EventHandler(this.btn_giaithich_Click);
            // 
            // btn_tieptheo
            // 
            this.btn_tieptheo.Location = new System.Drawing.Point(212, 28);
            this.btn_tieptheo.Name = "btn_tieptheo";
            this.btn_tieptheo.Size = new System.Drawing.Size(81, 40);
            this.btn_tieptheo.TabIndex = 2;
            this.btn_tieptheo.Text = "Tiếp theo";
            this.btn_tieptheo.UseVisualStyleBackColor = true;
            this.btn_tieptheo.Click += new System.EventHandler(this.btn_tieptheo_Click);
            // 
            // rdb_khong
            // 
            this.rdb_khong.AutoSize = true;
            this.rdb_khong.Location = new System.Drawing.Point(21, 51);
            this.rdb_khong.Name = "rdb_khong";
            this.rdb_khong.Size = new System.Drawing.Size(61, 17);
            this.rdb_khong.TabIndex = 1;
            this.rdb_khong.TabStop = true;
            this.rdb_khong.Text = "Không";
            this.rdb_khong.UseVisualStyleBackColor = true;
            // 
            // rdb_co
            // 
            this.rdb_co.AutoSize = true;
            this.rdb_co.Location = new System.Drawing.Point(21, 28);
            this.rdb_co.Name = "rdb_co";
            this.rdb_co.Size = new System.Drawing.Size(40, 17);
            this.rdb_co.TabIndex = 0;
            this.rdb_co.TabStop = true;
            this.rdb_co.Text = "Có\r\n";
            this.rdb_co.UseVisualStyleBackColor = true;
            // 
            // btn_xemhinh
            // 
            this.btn_xemhinh.Location = new System.Drawing.Point(373, 513);
            this.btn_xemhinh.Name = "btn_xemhinh";
            this.btn_xemhinh.Size = new System.Drawing.Size(81, 21);
            this.btn_xemhinh.TabIndex = 1;
            this.btn_xemhinh.Text = "Xem Hình";
            this.btn_xemhinh.UseVisualStyleBackColor = true;
            this.btn_xemhinh.Click += new System.EventHandler(this.btn_xemhinh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.thoátToolStripMenuItem.Text = "&Thoát     -   Alt + F4";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.thôngTinToolStripMenuItem.Text = "&Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Lavender;
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lab_chuongtrinh);
            this.groupBox5.Location = new System.Drawing.Point(12, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH CHUẨN ĐOÁN BỆNH";
            // 
            // lab_chuongtrinh
            // 
            this.lab_chuongtrinh.AutoSize = true;
            this.lab_chuongtrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_chuongtrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_chuongtrinh.Location = new System.Drawing.Point(139, 53);
            this.lab_chuongtrinh.Name = "lab_chuongtrinh";
            this.lab_chuongtrinh.Size = new System.Drawing.Size(0, 24);
            this.lab_chuongtrinh.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Lavender;
            this.groupBox6.Controls.Add(this.cbb_luachon);
            this.groupBox6.Controls.Add(this.txt_chuatri);
            this.groupBox6.Controls.Add(this.btn_xemhinh);
            this.groupBox6.Controls.Add(this.btn_chuatri);
            this.groupBox6.Location = new System.Drawing.Point(12, 128);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(460, 540);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tra Cứu cách chữa trị";
            // 
            // cbb_luachon
            // 
            this.cbb_luachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_luachon.FormattingEnabled = true;
            this.cbb_luachon.Items.AddRange(new object[] {
            "Chọn tên bệnh",
            " Bệnh sốt phát ban.",
            " Bệnh cảm lạnh.",
            " Bệnh cảm cúm.",
            " Bệnh sởi."});
            this.cbb_luachon.Location = new System.Drawing.Point(6, 19);
            this.cbb_luachon.Name = "cbb_luachon";
            this.cbb_luachon.Size = new System.Drawing.Size(361, 21);
            this.cbb_luachon.TabIndex = 2;
            // 
            // txt_chuatri
            // 
            this.txt_chuatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chuatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuatri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_chuatri.Location = new System.Drawing.Point(6, 48);
            this.txt_chuatri.Multiline = true;
            this.txt_chuatri.Name = "txt_chuatri";
            this.txt_chuatri.Size = new System.Drawing.Size(448, 459);
            this.txt_chuatri.TabIndex = 1;
            // 
            // btn_chuatri
            // 
            this.btn_chuatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuatri.Location = new System.Drawing.Point(373, 19);
            this.btn_chuatri.Name = "btn_chuatri";
            this.btn_chuatri.Size = new System.Drawing.Size(81, 23);
            this.btn_chuatri.TabIndex = 0;
            this.btn_chuatri.Text = "Tra cứu\r\n";
            this.btn_chuatri.UseVisualStyleBackColor = true;
            this.btn_chuatri.Click += new System.EventHandler(this.btn_chuatri_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(478, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 276);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 251);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1034, 680);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Hệ Chuẩn Đoán Bệnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cauhoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_tieptheo;
        private System.Windows.Forms.RadioButton rdb_khong;
        private System.Windows.Forms.RadioButton rdb_co;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Button btn_xemhinh;
        private System.Windows.Forms.Button btn_quanliluat;
        private System.Windows.Forms.Button btn_lamlai;
        private System.Windows.Forms.Button btn_giaithich;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_huongdan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_chuatri;
        private System.Windows.Forms.Button btn_batdau;
        private System.Windows.Forms.Label lab_chuongtrinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_luachon;
        private System.Windows.Forms.TextBox txt_chuatri;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

