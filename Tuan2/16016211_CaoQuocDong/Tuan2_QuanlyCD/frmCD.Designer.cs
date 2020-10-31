namespace Tuan2_QuanlyCD
{
    partial class frmQLCD
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rd3p = new System.Windows.Forms.RadioButton();
			this.cbbsl = new System.Windows.Forms.ComboBox();
			this.btnthoat = new System.Windows.Forms.Button();
			this.btntongtien = new System.Windows.Forms.Button();
			this.btnxoa = new System.Windows.Forms.Button();
			this.btntinhthue = new System.Windows.Forms.Button();
			this.txtdongiatien = new System.Windows.Forms.TextBox();
			this.txthotenKH1 = new System.Windows.Forms.TextBox();
			this.txtmaKH = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtdongia = new System.Windows.Forms.Label();
			this.txtslCD = new System.Windows.Forms.Label();
			this.txthotenKH = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.btnnext = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.txtThongtin = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lsvDS = new System.Windows.Forms.ListView();
			this.rd5p = new System.Windows.Forms.RadioButton();
			this.btncapnhat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(143, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÝ THUÊ CD";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rd5p);
			this.groupBox1.Controls.Add(this.rd3p);
			this.groupBox1.Controls.Add(this.cbbsl);
			this.groupBox1.Controls.Add(this.btncapnhat);
			this.groupBox1.Controls.Add(this.btnthoat);
			this.groupBox1.Controls.Add(this.btntongtien);
			this.groupBox1.Controls.Add(this.btnxoa);
			this.groupBox1.Controls.Add(this.btntinhthue);
			this.groupBox1.Controls.Add(this.txtdongiatien);
			this.groupBox1.Controls.Add(this.txthotenKH1);
			this.groupBox1.Controls.Add(this.txtmaKH);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtdongia);
			this.groupBox1.Controls.Add(this.txtslCD);
			this.groupBox1.Controls.Add(this.txthotenKH);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 234);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin KH";
			// 
			// rd3p
			// 
			this.rd3p.AutoSize = true;
			this.rd3p.Location = new System.Drawing.Point(134, 180);
			this.rd3p.Name = "rd3p";
			this.rd3p.Size = new System.Drawing.Size(66, 17);
			this.rd3p.TabIndex = 12;
			this.rd3p.TabStop = true;
			this.rd3p.Text = "Giảm 3%";
			this.rd3p.UseVisualStyleBackColor = true;
			// 
			// cbbsl
			// 
			this.cbbsl.FormattingEnabled = true;
			this.cbbsl.Location = new System.Drawing.Point(134, 108);
			this.cbbsl.Name = "cbbsl";
			this.cbbsl.Size = new System.Drawing.Size(44, 21);
			this.cbbsl.TabIndex = 11;
			// 
			// btnthoat
			// 
			this.btnthoat.Location = new System.Drawing.Point(358, 143);
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(116, 23);
			this.btnthoat.TabIndex = 10;
			this.btnthoat.Text = "Thoát";
			this.btnthoat.UseVisualStyleBackColor = true;
			// 
			// btntongtien
			// 
			this.btntongtien.Location = new System.Drawing.Point(358, 108);
			this.btntongtien.Name = "btntongtien";
			this.btntongtien.Size = new System.Drawing.Size(116, 23);
			this.btntongtien.TabIndex = 9;
			this.btntongtien.Text = "Tổng tiền";
			this.btntongtien.UseVisualStyleBackColor = true;
			this.btntongtien.Click += new System.EventHandler(this.btntongtien_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Enabled = false;
			this.btnxoa.Location = new System.Drawing.Point(358, 70);
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(116, 23);
			this.btnxoa.TabIndex = 8;
			this.btnxoa.Text = "Xóa";
			this.btnxoa.UseVisualStyleBackColor = true;
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btntinhthue
			// 
			this.btntinhthue.Location = new System.Drawing.Point(358, 37);
			this.btntinhthue.Name = "btntinhthue";
			this.btntinhthue.Size = new System.Drawing.Size(116, 23);
			this.btntinhthue.TabIndex = 7;
			this.btntinhthue.Text = "Tính thuê";
			this.btntinhthue.UseVisualStyleBackColor = true;
			this.btntinhthue.Click += new System.EventHandler(this.btntinhthue_Click);
			// 
			// txtdongiatien
			// 
			this.txtdongiatien.Location = new System.Drawing.Point(134, 146);
			this.txtdongiatien.Name = "txtdongiatien";
			this.txtdongiatien.Size = new System.Drawing.Size(218, 20);
			this.txtdongiatien.TabIndex = 4;
			this.txtdongiatien.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// txthotenKH1
			// 
			this.txthotenKH1.Location = new System.Drawing.Point(134, 73);
			this.txthotenKH1.Name = "txthotenKH1";
			this.txthotenKH1.Size = new System.Drawing.Size(218, 20);
			this.txthotenKH1.TabIndex = 2;
			// 
			// txtmaKH
			// 
			this.txtmaKH.Location = new System.Drawing.Point(134, 39);
			this.txtmaKH.Name = "txtmaKH";
			this.txtmaKH.Size = new System.Drawing.Size(218, 20);
			this.txtmaKH.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(33, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Trả trễ hạn";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Trả đúng hạn";
			// 
			// txtdongia
			// 
			this.txtdongia.AutoSize = true;
			this.txtdongia.Location = new System.Drawing.Point(33, 149);
			this.txtdongia.Name = "txtdongia";
			this.txtdongia.Size = new System.Drawing.Size(44, 13);
			this.txtdongia.TabIndex = 0;
			this.txtdongia.Text = "Đơn giá";
			// 
			// txtslCD
			// 
			this.txtslCD.AutoSize = true;
			this.txtslCD.Location = new System.Drawing.Point(33, 113);
			this.txtslCD.Name = "txtslCD";
			this.txtslCD.Size = new System.Drawing.Size(91, 13);
			this.txtslCD.TabIndex = 0;
			this.txtslCD.Text = "Số lượng CD thuê";
			// 
			// txthotenKH
			// 
			this.txthotenKH.AutoSize = true;
			this.txthotenKH.Location = new System.Drawing.Point(33, 76);
			this.txthotenKH.Name = "txthotenKH";
			this.txthotenKH.Size = new System.Drawing.Size(99, 13);
			this.txthotenKH.TabIndex = 0;
			this.txthotenKH.Text = "Họ tên khách hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã KH";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 277);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "|<<";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(93, 277);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 2;
			this.button6.Text = "<";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnnext
			// 
			this.btnnext.Location = new System.Drawing.Point(174, 277);
			this.btnnext.Name = "btnnext";
			this.btnnext.Size = new System.Drawing.Size(75, 23);
			this.btnnext.TabIndex = 3;
			this.btnnext.Text = ">";
			this.btnnext.UseVisualStyleBackColor = true;
			this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(255, 277);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 4;
			this.button8.Text = ">>|";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// txtThongtin
			// 
			this.txtThongtin.Location = new System.Drawing.Point(345, 280);
			this.txtThongtin.Name = "txtThongtin";
			this.txtThongtin.Size = new System.Drawing.Size(126, 20);
			this.txtThongtin.TabIndex = 1;
			this.txtThongtin.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lsvDS);
			this.groupBox2.Location = new System.Drawing.Point(12, 319);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 130);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thống kê";
			// 
			// lsvDS
			// 
			this.lsvDS.HideSelection = false;
			this.lsvDS.Location = new System.Drawing.Point(6, 19);
			this.lsvDS.Name = "lsvDS";
			this.lsvDS.Size = new System.Drawing.Size(468, 97);
			this.lsvDS.TabIndex = 0;
			this.lsvDS.UseCompatibleStateImageBehavior = false;
			this.lsvDS.SelectedIndexChanged += new System.EventHandler(this.lsvDS_SelectedIndexChanged);
			// 
			// rd5p
			// 
			this.rd5p.AutoSize = true;
			this.rd5p.Location = new System.Drawing.Point(134, 209);
			this.rd5p.Name = "rd5p";
			this.rd5p.Size = new System.Drawing.Size(67, 17);
			this.rd5p.TabIndex = 12;
			this.rd5p.TabStop = true;
			this.rd5p.Text = "Tăng 5%";
			this.rd5p.UseVisualStyleBackColor = true;
			// 
			// btncapnhat
			// 
			this.btncapnhat.Location = new System.Drawing.Point(358, 172);
			this.btncapnhat.Name = "btncapnhat";
			this.btncapnhat.Size = new System.Drawing.Size(116, 23);
			this.btncapnhat.TabIndex = 10;
			this.btncapnhat.Text = "Cập nhật";
			this.btncapnhat.UseVisualStyleBackColor = true;
			this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
			// 
			// frmQLCD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 452);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.btnnext);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtThongtin);
			this.Name = "frmQLCD";
			this.Text = "Quản lý thuê CD";
			this.Load += new System.EventHandler(this.frmQLCD_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntongtien;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntinhthue;
        private System.Windows.Forms.TextBox txtdongiatien;
        private System.Windows.Forms.TextBox txthotenKH1;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtdongia;
        private System.Windows.Forms.Label txtslCD;
        private System.Windows.Forms.Label txthotenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtThongtin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDS;
        private System.Windows.Forms.ComboBox cbbsl;
		private System.Windows.Forms.RadioButton rd3p;
		private System.Windows.Forms.RadioButton rd5p;
		private System.Windows.Forms.Button btncapnhat;
	}
}

