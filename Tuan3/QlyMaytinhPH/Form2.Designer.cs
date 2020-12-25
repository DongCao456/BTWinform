namespace QlyMaytinhPH
{
    partial class Form2
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
            this.rdbMP = new System.Windows.Forms.RadioButton();
            this.rdbCPU = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvMayTinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMayTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbMP
            // 
            this.rdbMP.AutoSize = true;
            this.rdbMP.Location = new System.Drawing.Point(55, 44);
            this.rdbMP.Name = "rdbMP";
            this.rdbMP.Size = new System.Drawing.Size(102, 17);
            this.rdbMP.TabIndex = 0;
            this.rdbMP.TabStop = true;
            this.rdbMP.Text = "Theo Mã Phòng";
            this.rdbMP.UseVisualStyleBackColor = true;
            this.rdbMP.CheckedChanged += new System.EventHandler(this.rdbMP_CheckedChanged);
            // 
            // rdbCPU
            // 
            this.rdbCPU.AutoSize = true;
            this.rdbCPU.Location = new System.Drawing.Point(55, 95);
            this.rdbCPU.Name = "rdbCPU";
            this.rdbCPU.Size = new System.Drawing.Size(75, 17);
            this.rdbCPU.TabIndex = 1;
            this.rdbCPU.TabStop = true;
            this.rdbCPU.Text = "Theo CPU";
            this.rdbCPU.UseVisualStyleBackColor = true;
            this.rdbCPU.CheckedChanged += new System.EventHandler(this.rdbCPU_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(167, 44);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(208, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(406, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgvMayTinh
            // 
            this.dtgvMayTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMayTinh.Location = new System.Drawing.Point(24, 141);
            this.dtgvMayTinh.Name = "dtgvMayTinh";
            this.dtgvMayTinh.Size = new System.Drawing.Size(534, 241);
            this.dtgvMayTinh.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.dtgvMayTinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.rdbCPU);
            this.Controls.Add(this.rdbMP);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMayTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMP;
        private System.Windows.Forms.RadioButton rdbCPU;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvMayTinh;
    }
}