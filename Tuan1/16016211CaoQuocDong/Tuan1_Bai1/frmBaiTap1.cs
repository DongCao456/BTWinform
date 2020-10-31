using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_Bai1
{
    public partial class frmBaitap1 : Form
    {
        public frmBaitap1()
        {
            InitializeComponent();
        }

        

        

        
        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            else
                this.errorProvider1.Clear();
        }

        private void frmBaitap1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My Name Is:" + txtHoten.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtNamsinh.Text);
            s = s + "Age:" + age.ToString();
            MessageBox.Show(s);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoten.Clear();
            txtNamsinh.Clear();
            txtHoten.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaitap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you really want to close", "Ex1", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
