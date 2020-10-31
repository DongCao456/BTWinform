using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_Doitien
{
    public partial class frmDoitien : Form
    {
        public frmDoitien()
        {
            InitializeComponent();
        }

        private void frmDoitien_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVtU_Click(object sender, EventArgs e)
        {
            float s ;
            string a = txtTiendoi.Text;

            s =  float.Parse(a) / 17861;
            double rounded = Math.Round(s,2);
            txtKetQua.Text = rounded.ToString();
            
        }

        private void btnVtE_Click(object sender, EventArgs e)
        {
            float s;
            string a = txtTiendoi.Text;

            s =  float.Parse(a) / 27043;
            double rounded = Math.Round(s,2);
            txtKetQua.Text = s.ToString();
        }

        private void btnUtV_Click(object sender, EventArgs e)
        {
            float s;
            string a = txtTiendoi.Text;

            s = float.Parse(a) * 17861;
            double rounded = Math.Round(s,2);
            txtKetQua.Text = s.ToString();
        }

        private void btnEtV_Click(object sender, EventArgs e)
        {
            float s;
            string a = txtTiendoi.Text;

            s = float.Parse(a) * 27043;
            double rounded = Math.Round(s,2);
            txtKetQua.Text = s.ToString();
        }
    }
}
