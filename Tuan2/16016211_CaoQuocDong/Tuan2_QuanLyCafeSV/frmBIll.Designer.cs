namespace Tuan2_QuanLyCafeSV
{
    partial class frmBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cbSinhvien = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTongKhach = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.rdcafeDen = new System.Windows.Forms.RadioButton();
            this.rdcafeDa = new System.Windows.Forms.RadioButton();
            this.rdcafeSua = new System.Windows.Forms.RadioButton();
            this.rdcafeKem = new System.Windows.Forms.RadioButton();
            this.rdcafeSuaDa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSTongKhach = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSTongTien = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(37, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 73);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(247, 90);
            this.txtTenKhach.Multiline = true;
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(285, 30);
            this.txtTenKhach.TabIndex = 3;
            this.txtTenKhach.TextChanged += new System.EventHandler(this.txtTenKhach_TextChanged);
            // 
            // cbSinhvien
            // 
            this.cbSinhvien.AutoSize = true;
            this.cbSinhvien.Location = new System.Drawing.Point(247, 135);
            this.cbSinhvien.Name = "cbSinhvien";
            this.cbSinhvien.Size = new System.Drawing.Size(79, 17);
            this.cbSinhvien.TabIndex = 4;
            this.cbSinhvien.Text = "Sinh viên ?";
            this.cbSinhvien.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(120, 14);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(110, 29);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.txtTongKhach);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnNhapLai);
            this.panel2.Location = new System.Drawing.Point(2, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 144);
            this.panel2.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(572, 14);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 29);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(276, 100);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(285, 30);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTenKhach_TextChanged);
            // 
            // txtTongKhach
            // 
            this.txtTongKhach.Location = new System.Drawing.Point(276, 57);
            this.txtTongKhach.Multiline = true;
            this.txtTongKhach.Name = "txtTongKhach";
            this.txtTongKhach.Size = new System.Drawing.Size(285, 30);
            this.txtTongKhach.TabIndex = 3;
            this.txtTongKhach.TextChanged += new System.EventHandler(this.txtTenKhach_TextChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(420, 14);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 29);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng Tiền Thanh Toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Khách Hàng:";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(273, 14);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(110, 29);
            this.btnNhapLai.TabIndex = 6;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // rdcafeDen
            // 
            this.rdcafeDen.AutoSize = true;
            this.rdcafeDen.Location = new System.Drawing.Point(24, 19);
            this.rdcafeDen.Name = "rdcafeDen";
            this.rdcafeDen.Size = new System.Drawing.Size(70, 17);
            this.rdcafeDen.TabIndex = 0;
            this.rdcafeDen.TabStop = true;
            this.rdcafeDen.Text = "Cafe Đen";
            this.rdcafeDen.UseVisualStyleBackColor = true;
            this.rdcafeDen.CheckedChanged += new System.EventHandler(this.rdcafeDen_CheckedChanged);
            // 
            // rdcafeDa
            // 
            this.rdcafeDa.AutoSize = true;
            this.rdcafeDa.Location = new System.Drawing.Point(218, 19);
            this.rdcafeDa.Name = "rdcafeDa";
            this.rdcafeDa.Size = new System.Drawing.Size(64, 17);
            this.rdcafeDa.TabIndex = 0;
            this.rdcafeDa.TabStop = true;
            this.rdcafeDa.Text = "Cafe Đá";
            this.rdcafeDa.UseVisualStyleBackColor = true;
            this.rdcafeDa.CheckedChanged += new System.EventHandler(this.rdcafeDa_CheckedChanged);
            // 
            // rdcafeSua
            // 
            this.rdcafeSua.AutoSize = true;
            this.rdcafeSua.Location = new System.Drawing.Point(25, 55);
            this.rdcafeSua.Name = "rdcafeSua";
            this.rdcafeSua.Size = new System.Drawing.Size(69, 17);
            this.rdcafeSua.TabIndex = 0;
            this.rdcafeSua.TabStop = true;
            this.rdcafeSua.Text = "Cafe Sữa";
            this.rdcafeSua.UseVisualStyleBackColor = true;
            this.rdcafeSua.CheckedChanged += new System.EventHandler(this.rdcafeSua_CheckedChanged);
            // 
            // rdcafeKem
            // 
            this.rdcafeKem.AutoSize = true;
            this.rdcafeKem.Location = new System.Drawing.Point(218, 55);
            this.rdcafeKem.Name = "rdcafeKem";
            this.rdcafeKem.Size = new System.Drawing.Size(71, 17);
            this.rdcafeKem.TabIndex = 0;
            this.rdcafeKem.TabStop = true;
            this.rdcafeKem.Text = "Cafe Kem";
            this.rdcafeKem.UseVisualStyleBackColor = true;
            this.rdcafeKem.CheckedChanged += new System.EventHandler(this.rdcafeKem_CheckedChanged);
            // 
            // rdcafeSuaDa
            // 
            this.rdcafeSuaDa.AutoSize = true;
            this.rdcafeSuaDa.Location = new System.Drawing.Point(24, 92);
            this.rdcafeSuaDa.Name = "rdcafeSuaDa";
            this.rdcafeSuaDa.Size = new System.Drawing.Size(86, 17);
            this.rdcafeSuaDa.TabIndex = 0;
            this.rdcafeSuaDa.TabStop = true;
            this.rdcafeSuaDa.Text = "Cafe Sữa Đá";
            this.rdcafeSuaDa.UseVisualStyleBackColor = true;
            this.rdcafeSuaDa.CheckedChanged += new System.EventHandler(this.rdcafeSuaDa_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTien);
            this.groupBox1.Controls.Add(this.rdcafeDa);
            this.groupBox1.Controls.Add(this.rdcafeSuaDa);
            this.groupBox1.Controls.Add(this.rdcafeKem);
            this.groupBox1.Controls.Add(this.rdcafeDen);
            this.groupBox1.Controls.Add(this.rdcafeSua);
            this.groupBox1.Location = new System.Drawing.Point(232, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại Cafe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tSTongKhach,
            this.toolStripStatusLabel3,
            this.tSTongTien});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "Tổng Khách:";
            // 
            // tSTongKhach
            // 
            this.tSTongKhach.Name = "tSTongKhach";
            this.tSTongKhach.Size = new System.Drawing.Size(13, 17);
            this.tSTongKhach.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "Tổng Tiền";
            // 
            // tSTongTien
            // 
            this.tSTongTien.Name = "tSTongTien";
            this.tSTongTien.Size = new System.Drawing.Size(13, 17);
            this.tSTongTien.Text = "0";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(22, 149);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(13, 13);
            this.lblTien.TabIndex = 8;
            this.lblTien.Text = "0";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbSinhvien);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.CheckBox cbSinhvien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTongKhach;
        private System.Windows.Forms.RadioButton rdcafeDen;
        private System.Windows.Forms.RadioButton rdcafeDa;
        private System.Windows.Forms.RadioButton rdcafeSua;
        private System.Windows.Forms.RadioButton rdcafeKem;
        private System.Windows.Forms.RadioButton rdcafeSuaDa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSTongKhach;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tSTongTien;
        private System.Windows.Forms.Label lblTien;
    }
}

