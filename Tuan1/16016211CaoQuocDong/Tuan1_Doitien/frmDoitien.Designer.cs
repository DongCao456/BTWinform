namespace Tuan1_Doitien
{
    partial class frmDoitien
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
            this.txtTiendoi = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnVtU = new System.Windows.Forms.Button();
            this.btnVtE = new System.Windows.Forms.Button();
            this.btnUtV = new System.Windows.Forms.Button();
            this.btnEtV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền qui đổi:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTiendoi
            // 
            this.txtTiendoi.Location = new System.Drawing.Point(123, 39);
            this.txtTiendoi.Name = "txtTiendoi";
            this.txtTiendoi.Size = new System.Drawing.Size(100, 20);
            this.txtTiendoi.TabIndex = 1;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(123, 174);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(100, 20);
            this.txtKetQua.TabIndex = 1;
            // 
            // btnVtU
            // 
            this.btnVtU.Location = new System.Drawing.Point(34, 110);
            this.btnVtU.Name = "btnVtU";
            this.btnVtU.Size = new System.Drawing.Size(95, 29);
            this.btnVtU.TabIndex = 2;
            this.btnVtU.Text = "VND TO USD";
            this.btnVtU.UseVisualStyleBackColor = true;
            this.btnVtU.Click += new System.EventHandler(this.btnVtU_Click);
            // 
            // btnVtE
            // 
            this.btnVtE.Location = new System.Drawing.Point(167, 110);
            this.btnVtE.Name = "btnVtE";
            this.btnVtE.Size = new System.Drawing.Size(93, 29);
            this.btnVtE.TabIndex = 2;
            this.btnVtE.Text = "VND TO EURO";
            this.btnVtE.UseVisualStyleBackColor = true;
            this.btnVtE.Click += new System.EventHandler(this.btnVtE_Click);
            // 
            // btnUtV
            // 
            this.btnUtV.Location = new System.Drawing.Point(289, 110);
            this.btnUtV.Name = "btnUtV";
            this.btnUtV.Size = new System.Drawing.Size(88, 29);
            this.btnUtV.TabIndex = 2;
            this.btnUtV.Text = "USD TO VND";
            this.btnUtV.UseVisualStyleBackColor = true;
            this.btnUtV.Click += new System.EventHandler(this.btnUtV_Click);
            // 
            // btnEtV
            // 
            this.btnEtV.Location = new System.Drawing.Point(420, 110);
            this.btnEtV.Name = "btnEtV";
            this.btnEtV.Size = new System.Drawing.Size(93, 29);
            this.btnEtV.TabIndex = 2;
            this.btnEtV.Text = "EURO TO VND";
            this.btnEtV.UseVisualStyleBackColor = true;
            this.btnEtV.Click += new System.EventHandler(this.btnEtV_Click);
            // 
            // frmDoitien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.btnEtV);
            this.Controls.Add(this.btnUtV);
            this.Controls.Add(this.btnVtE);
            this.Controls.Add(this.btnVtU);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtTiendoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoitien";
            this.Text = "Change Money";
            this.Load += new System.EventHandler(this.frmDoitien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTiendoi;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnVtU;
        private System.Windows.Forms.Button btnVtE;
        private System.Windows.Forms.Button btnUtV;
        private System.Windows.Forms.Button btnEtV;
    }
}

