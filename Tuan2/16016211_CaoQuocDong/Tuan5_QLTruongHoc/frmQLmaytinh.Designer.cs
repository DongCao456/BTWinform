namespace Tuan5_QLTruongHoc
{
    partial class formQLPhongMay
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.treePhong = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrMayTinh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtHardisk = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtmsMay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMayTinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.treePhong);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 579);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // treePhong
            // 
            this.treePhong.Location = new System.Drawing.Point(3, 3);
            this.treePhong.Name = "treePhong";
            this.treePhong.Size = new System.Drawing.Size(236, 506);
            this.treePhong.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm phòng học";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrMayTinh);
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách máy tính";
            // 
            // dgrMayTinh
            // 
            this.dgrMayTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMayTinh.Location = new System.Drawing.Point(6, 19);
            this.dgrMayTinh.Name = "dgrMayTinh";
            this.dgrMayTinh.Size = new System.Drawing.Size(765, 150);
            this.dgrMayTinh.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.txtMonitor);
            this.groupBox2.Controls.Add(this.txtVGA);
            this.groupBox2.Controls.Add(this.txtRAM);
            this.groupBox2.Controls.Add(this.txtHardisk);
            this.groupBox2.Controls.Add(this.txtCPU);
            this.groupBox2.Controls.Add(this.txtmsMay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(257, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 381);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(483, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(134, 277);
            this.txtPhong.Multiline = true;
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(498, 28);
            this.txtPhong.TabIndex = 5;
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(134, 236);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(498, 28);
            this.txtMonitor.TabIndex = 5;
            // 
            // txtVGA
            // 
            this.txtVGA.Location = new System.Drawing.Point(134, 200);
            this.txtVGA.Multiline = true;
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(498, 28);
            this.txtVGA.TabIndex = 5;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(134, 161);
            this.txtRAM.Multiline = true;
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(498, 28);
            this.txtRAM.TabIndex = 5;
            // 
            // txtHardisk
            // 
            this.txtHardisk.Location = new System.Drawing.Point(134, 121);
            this.txtHardisk.Multiline = true;
            this.txtHardisk.Name = "txtHardisk";
            this.txtHardisk.Size = new System.Drawing.Size(498, 28);
            this.txtHardisk.TabIndex = 5;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(134, 76);
            this.txtCPU.Multiline = true;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(498, 28);
            this.txtCPU.TabIndex = 5;
            // 
            // txtmsMay
            // 
            this.txtmsMay.Location = new System.Drawing.Point(134, 38);
            this.txtmsMay.Multiline = true;
            this.txtmsMay.Name = "txtmsMay";
            this.txtmsMay.Size = new System.Drawing.Size(498, 28);
            this.txtmsMay.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monitor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "VGA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hardisk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số máy:";
            // 
            // imgTree
            // 
            this.imgTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgTree.ImageSize = new System.Drawing.Size(16, 16);
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // formQLPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "formQLPhongMay";
            this.Text = "Quản lý máy tính";
            this.Load += new System.EventHandler(this.formQLPhongMay_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMayTinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TreeView treePhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrMayTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtHardisk;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtmsMay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgTree;
    }
}

