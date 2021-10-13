namespace HeChuanDoanBenh
{
    partial class QuanLiLuat
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
            this.btn_xoanode = new System.Windows.Forms.Button();
            this.btn_themnode = new System.Windows.Forms.Button();
            this.IstNode = new System.Windows.Forms.ListBox();
            this.txt_node = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Istrules = new System.Windows.Forms.ListBox();
            this.btn_xoarules = new System.Windows.Forms.Button();
            this.btn_themrules = new System.Windows.Forms.Button();
            this.txt_rules = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_Rulestext = new System.Windows.Forms.TextBox();
            this.btn_xemhuongdan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoanode);
            this.groupBox1.Controls.Add(this.btn_themnode);
            this.groupBox1.Controls.Add(this.IstNode);
            this.groupBox1.Controls.Add(this.txt_node);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý danh sách";
            // 
            // btn_xoanode
            // 
            this.btn_xoanode.ForeColor = System.Drawing.Color.Red;
            this.btn_xoanode.Location = new System.Drawing.Point(454, 25);
            this.btn_xoanode.Name = "btn_xoanode";
            this.btn_xoanode.Size = new System.Drawing.Size(57, 29);
            this.btn_xoanode.TabIndex = 3;
            this.btn_xoanode.Text = "Xóa";
            this.btn_xoanode.UseVisualStyleBackColor = true;
            this.btn_xoanode.Click += new System.EventHandler(this.btn_xoanode_Click);
            // 
            // btn_themnode
            // 
            this.btn_themnode.ForeColor = System.Drawing.Color.Red;
            this.btn_themnode.Location = new System.Drawing.Point(391, 25);
            this.btn_themnode.Name = "btn_themnode";
            this.btn_themnode.Size = new System.Drawing.Size(57, 29);
            this.btn_themnode.TabIndex = 2;
            this.btn_themnode.Text = "Thêm";
            this.btn_themnode.UseVisualStyleBackColor = true;
            this.btn_themnode.Click += new System.EventHandler(this.btn_themnode_Click);
            // 
            // IstNode
            // 
            this.IstNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstNode.FormattingEnabled = true;
            this.IstNode.ItemHeight = 16;
            this.IstNode.Location = new System.Drawing.Point(12, 70);
            this.IstNode.Name = "IstNode";
            this.IstNode.Size = new System.Drawing.Size(499, 116);
            this.IstNode.TabIndex = 4;
            // 
            // txt_node
            // 
            this.txt_node.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_node.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_node.Location = new System.Drawing.Point(100, 25);
            this.txt_node.Multiline = true;
            this.txt_node.Name = "txt_node";
            this.txt_node.Size = new System.Drawing.Size(285, 29);
            this.txt_node.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biểu thức";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Istrules);
            this.groupBox2.Controls.Add(this.btn_xoarules);
            this.groupBox2.Controls.Add(this.btn_themrules);
            this.groupBox2.Controls.Add(this.txt_rules);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý danh sách luật";
            // 
            // Istrules
            // 
            this.Istrules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Istrules.FormattingEnabled = true;
            this.Istrules.ItemHeight = 16;
            this.Istrules.Location = new System.Drawing.Point(6, 75);
            this.Istrules.Name = "Istrules";
            this.Istrules.Size = new System.Drawing.Size(505, 116);
            this.Istrules.TabIndex = 4;
            this.Istrules.SelectedIndexChanged += new System.EventHandler(this.Istrules_SelectedIndexChanged);
            // 
            // btn_xoarules
            // 
            this.btn_xoarules.ForeColor = System.Drawing.Color.Red;
            this.btn_xoarules.Location = new System.Drawing.Point(454, 27);
            this.btn_xoarules.Name = "btn_xoarules";
            this.btn_xoarules.Size = new System.Drawing.Size(57, 27);
            this.btn_xoarules.TabIndex = 3;
            this.btn_xoarules.Text = "Xóa";
            this.btn_xoarules.UseVisualStyleBackColor = true;
            this.btn_xoarules.Click += new System.EventHandler(this.btn_xoarules_Click);
            // 
            // btn_themrules
            // 
            this.btn_themrules.ForeColor = System.Drawing.Color.Red;
            this.btn_themrules.Location = new System.Drawing.Point(391, 27);
            this.btn_themrules.Name = "btn_themrules";
            this.btn_themrules.Size = new System.Drawing.Size(57, 27);
            this.btn_themrules.TabIndex = 2;
            this.btn_themrules.Text = "Thêm";
            this.btn_themrules.UseVisualStyleBackColor = true;
            this.btn_themrules.Click += new System.EventHandler(this.btn_themrules_Click);
            // 
            // txt_rules
            // 
            this.txt_rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rules.Location = new System.Drawing.Point(100, 27);
            this.txt_rules.Multiline = true;
            this.txt_rules.Name = "txt_rules";
            this.txt_rules.Size = new System.Drawing.Size(285, 27);
            this.txt_rules.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biểu thức luật";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(752, 10);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(84, 28);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_Rulestext
            // 
            this.txt_Rulestext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rulestext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rulestext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Rulestext.Location = new System.Drawing.Point(6, 25);
            this.txt_Rulestext.Multiline = true;
            this.txt_Rulestext.Name = "txt_Rulestext";
            this.txt_Rulestext.Size = new System.Drawing.Size(307, 371);
            this.txt_Rulestext.TabIndex = 3;
            // 
            // btn_xemhuongdan
            // 
            this.btn_xemhuongdan.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_xemhuongdan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_xemhuongdan.ForeColor = System.Drawing.Color.Black;
            this.btn_xemhuongdan.Location = new System.Drawing.Point(601, 10);
            this.btn_xemhuongdan.Name = "btn_xemhuongdan";
            this.btn_xemhuongdan.Size = new System.Drawing.Size(136, 28);
            this.btn_xemhuongdan.TabIndex = 4;
            this.btn_xemhuongdan.Text = "Xem Hướng Dẫn";
            this.btn_xemhuongdan.UseVisualStyleBackColor = false;
            this.btn_xemhuongdan.Click += new System.EventHandler(this.btn_xemhuongdan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Rulestext);
            this.groupBox3.Location = new System.Drawing.Point(535, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 404);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diễn tả các luật";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_xemhuongdan);
            this.groupBox4.Controls.Add(this.btn_ok);
            this.groupBox4.Location = new System.Drawing.Point(12, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(842, 48);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // QuanLiLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(866, 480);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "QuanLiLuat";
            this.Text = "QuanLiLuat";
            this.Load += new System.EventHandler(this.QuanLiLuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoanode;
        private System.Windows.Forms.Button btn_themnode;
        private System.Windows.Forms.ListBox IstNode;
        private System.Windows.Forms.TextBox txt_node;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Istrules;
        private System.Windows.Forms.Button btn_xoarules;
        private System.Windows.Forms.Button btn_themrules;
        private System.Windows.Forms.TextBox txt_rules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_Rulestext;
        private System.Windows.Forms.Button btn_xemhuongdan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}