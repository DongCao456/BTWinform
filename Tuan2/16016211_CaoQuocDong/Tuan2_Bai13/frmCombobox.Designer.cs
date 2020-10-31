namespace Tuan2_Bai13
{
    partial class frmCombobox
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
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnslusngto = new System.Windows.Forms.Button();
            this.btnsluschan = new System.Windows.Forms.Button();
            this.btntongus = new System.Windows.Forms.Button();
            this.cbbds = new System.Windows.Forms.ComboBox();
            this.lbdsus = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(39, 58);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(100, 20);
            this.txtnhapso.TabIndex = 1;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(159, 56);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(159, 330);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnslusngto
            // 
            this.btnslusngto.Location = new System.Drawing.Point(259, 330);
            this.btnslusngto.Name = "btnslusngto";
            this.btnslusngto.Size = new System.Drawing.Size(227, 23);
            this.btnslusngto.TabIndex = 2;
            this.btnslusngto.Text = "Số lượng các ước số nguyên tố";
            this.btnslusngto.UseVisualStyleBackColor = true;
            this.btnslusngto.Click += new System.EventHandler(this.btnslusngto_Click);
            // 
            // btnsluschan
            // 
            this.btnsluschan.Location = new System.Drawing.Point(259, 288);
            this.btnsluschan.Name = "btnsluschan";
            this.btnsluschan.Size = new System.Drawing.Size(227, 23);
            this.btnsluschan.TabIndex = 2;
            this.btnsluschan.Text = "Số lượng các ước số chẵn";
            this.btnsluschan.UseVisualStyleBackColor = true;
            this.btnsluschan.Click += new System.EventHandler(this.btnsluschan_Click);
            // 
            // btntongus
            // 
            this.btntongus.Location = new System.Drawing.Point(259, 242);
            this.btntongus.Name = "btntongus";
            this.btntongus.Size = new System.Drawing.Size(227, 23);
            this.btntongus.TabIndex = 2;
            this.btntongus.Text = "Tổng các ước số";
            this.btntongus.UseVisualStyleBackColor = true;
            this.btntongus.Click += new System.EventHandler(this.btntongus_Click);
            // 
            // cbbds
            // 
            this.cbbds.FormattingEnabled = true;
            this.cbbds.Location = new System.Drawing.Point(39, 107);
            this.cbbds.Name = "cbbds";
            this.cbbds.Size = new System.Drawing.Size(195, 21);
            this.cbbds.TabIndex = 3;
            this.cbbds.Text = "d";
            this.cbbds.SelectedIndexChanged += new System.EventHandler(this.cbbds_SelectedIndexChanged);
            // 
            // lbdsus
            // 
            this.lbdsus.FormattingEnabled = true;
            this.lbdsus.Location = new System.Drawing.Point(302, 58);
            this.lbdsus.Name = "lbdsus";
            this.lbdsus.Size = new System.Drawing.Size(120, 95);
            this.lbdsus.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(274, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // frmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 401);
            this.Controls.Add(this.lbdsus);
            this.Controls.Add(this.cbbds);
            this.Controls.Add(this.btntongus);
            this.Controls.Add(this.btnsluschan);
            this.Controls.Add(this.btnslusngto);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.txtnhapso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCombobox";
            this.Text = "Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnslusngto;
        private System.Windows.Forms.Button btnsluschan;
        private System.Windows.Forms.Button btntongus;
        private System.Windows.Forms.ComboBox cbbds;
        private System.Windows.Forms.ListBox lbdsus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

