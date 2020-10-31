using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_Bai2
{
    public partial class frmDoiNam : Form
    {
        int namduong;
        string strcan;
        string strchi;
        public frmDoiNam()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            namduong = Convert.ToInt32(txtDuonglich.Text);
            switch(namduong%10)
            {
                case 0:
                    strcan = "Canh";
                    break;
                case 1:
                    strcan = "Tân";
                    break;
                case 2:
                    strcan = "Nhâm";
                    break;
                case 3:
                    strcan = "Quý";
                    break;
                case 4:
                    strcan = "Giáp";
                    break;
                case 5:
                    strcan = "Ất";
                    break;
                case 6:
                    strcan = "Bính";
                    break;
                case 7:
                    strcan = "Đinh";
                    break;
                case 8:
                    strcan = "Mậu";
                    break;
                case 9:
                    strcan = "Ký";
                    break;
            }
            switch(namduong%12)
            {
                case 0:
                    strchi = "Thân";
                    break;
                case 1:
                    strchi = "Dậu";
                    break;
                case 2:
                    strchi = "Tuất";
                    break;
                case 3:
                    strchi = "Hợi";
                    break;
                case 4:
                    strchi = "Tý";
                    break;
                case 5:
                    strchi = "Sửu";
                    break;
                case 6:
                    strchi = "Dần";
                    break;
                case 7:
                    strchi = "Mẹo";
                    break;
                case 8:
                    strchi = "Thìn";
                    break;
                case 9:
                    strchi = "Tỵ";
                    break;
                case 10:
                    strchi = "Ngọ";
                    break;
                case 11:
                    strchi = "Mùi";
                    break;
            }
            txtAmlich.Text = strcan + " " + strchi;
        }
    }
}
