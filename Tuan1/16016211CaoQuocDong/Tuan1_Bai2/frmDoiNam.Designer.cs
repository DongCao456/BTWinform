namespace Tuan1_Bai2
{
    partial class frmDoiNam
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuonglich = new System.Windows.Forms.TextBox();
            this.txtAmlich = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm Dương Lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm Âm Lịch";
            // 
            // txtDuonglich
            // 
            this.txtDuonglich.Location = new System.Drawing.Point(152, 44);
            this.txtDuonglich.Name = "txtDuonglich";
            this.txtDuonglich.Size = new System.Drawing.Size(100, 20);
            this.txtDuonglich.TabIndex = 1;
            // 
            // txtAmlich
            // 
            this.txtAmlich.Location = new System.Drawing.Point(152, 143);
            this.txtAmlich.Name = "txtAmlich";
            this.txtAmlich.Size = new System.Drawing.Size(100, 20);
            this.txtAmlich.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(152, 91);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(186, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "&Xem &năm â&m &lịch";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmDoiNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 261);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtAmlich);
            this.Controls.Add(this.txtDuonglich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiNam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuonglich;
        private System.Windows.Forms.TextBox txtAmlich;
        private System.Windows.Forms.Button btnXem;
    }
}

