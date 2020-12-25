namespace QlyMaytinhPH
{
    partial class frmQLY
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
            this.trwPhong = new System.Windows.Forms.TreeView();
            this.lvwMay = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcpu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMamay = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtHDisk = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuuMoi = new System.Windows.Forms.Button();
            this.btnLuuSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.imageTree = new System.Windows.Forms.ImageList(this.components);
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trwPhong
            // 
            this.trwPhong.Location = new System.Drawing.Point(12, 30);
            this.trwPhong.Name = "trwPhong";
            this.trwPhong.Size = new System.Drawing.Size(241, 514);
            this.trwPhong.TabIndex = 0;
            this.trwPhong.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trwPhong_AfterSelect);
            // 
            // lvwMay
            // 
            this.lvwMay.HideSelection = false;
            this.lvwMay.Location = new System.Drawing.Point(281, 30);
            this.lvwMay.Name = "lvwMay";
            this.lvwMay.Size = new System.Drawing.Size(862, 165);
            this.lvwMay.TabIndex = 1;
            this.lvwMay.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số máy:";
            // 
            // lbcpu
            // 
            this.lbcpu.AutoSize = true;
            this.lbcpu.Location = new System.Drawing.Point(278, 283);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(32, 13);
            this.lbcpu.TabIndex = 2;
            this.lbcpu.Text = "CPU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harddisk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "VGA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "RAM:";
            // 
            // txtMamay
            // 
            this.txtMamay.Location = new System.Drawing.Point(345, 234);
            this.txtMamay.Multiline = true;
            this.txtMamay.Name = "txtMamay";
            this.txtMamay.Size = new System.Drawing.Size(379, 35);
            this.txtMamay.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 896);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 35);
            this.textBox2.TabIndex = 3;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(344, 276);
            this.txtCPU.Multiline = true;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(379, 35);
            this.txtCPU.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 935);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 35);
            this.textBox4.TabIndex = 3;
            // 
            // txtHDisk
            // 
            this.txtHDisk.Location = new System.Drawing.Point(344, 317);
            this.txtHDisk.Multiline = true;
            this.txtHDisk.Name = "txtHDisk";
            this.txtHDisk.Size = new System.Drawing.Size(379, 35);
            this.txtHDisk.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(281, 976);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(379, 35);
            this.textBox6.TabIndex = 3;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(344, 373);
            this.txtRam.Multiline = true;
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(379, 35);
            this.txtRam.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(281, 1032);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(379, 35);
            this.textBox8.TabIndex = 3;
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(344, 485);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(379, 35);
            this.txtMonitor.TabIndex = 3;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(281, 1144);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(379, 35);
            this.textBox10.TabIndex = 3;
            // 
            // txtVGA
            // 
            this.txtVGA.Location = new System.Drawing.Point(344, 427);
            this.txtVGA.Multiline = true;
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(379, 35);
            this.txtVGA.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(281, 1086);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(379, 35);
            this.textBox12.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(264, 542);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuuMoi
            // 
            this.btnLuuMoi.Location = new System.Drawing.Point(363, 542);
            this.btnLuuMoi.Name = "btnLuuMoi";
            this.btnLuuMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLuuMoi.TabIndex = 4;
            this.btnLuuMoi.Text = "Lưu";
            this.btnLuuMoi.UseVisualStyleBackColor = true;
            this.btnLuuMoi.Click += new System.EventHandler(this.btnLuuMoi_Click);
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.Location = new System.Drawing.Point(468, 542);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSua.TabIndex = 4;
            this.btnLuuSua.Text = "Sửa";
            this.btnLuuSua.UseVisualStyleBackColor = true;
            this.btnLuuSua.Click += new System.EventHandler(this.btnLuuSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(580, 542);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(695, 542);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // imageTree
            // 
            this.imageTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageTree.ImageSize = new System.Drawing.Size(16, 16);
            this.imageTree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(880, 234);
            this.txtPhong.Multiline = true;
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(247, 35);
            this.txtPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MSPhong";
            // 
            // frmQLY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 601);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuSua);
            this.Controls.Add(this.btnLuuMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtVGA);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtHDisk);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtMamay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbcpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwMay);
            this.Controls.Add(this.trwPhong);
            this.Name = "frmQLY";
            this.Text = "frmQLY";
            this.Load += new System.EventHandler(this.frmQLY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trwPhong;
        private System.Windows.Forms.ListView lvwMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMamay;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtHDisk;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuuMoi;
        private System.Windows.Forms.Button btnLuuSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imageTree;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label2;
    }
}

