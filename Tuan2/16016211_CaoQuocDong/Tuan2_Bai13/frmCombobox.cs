using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_Bai13
{
    public partial class frmCombobox : Form
    {
        public frmCombobox()
        {
            InitializeComponent();
            cbbds.ResetText();
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtnhapso.Text))
            {
                
                MessageBox.Show("Yêu cầu nhập số");
            }
            else
            {
                cbbds.Items.Add(txtnhapso.Text);
                
                txtnhapso.Clear();
                txtnhapso.Focus();
            }
            
        }

        private void cbbds_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                lbdsus.Items.Add(cbbds.Text);
            
            
            
        }

        private void btntongus_Click(object sender, EventArgs e)
        {
            long t = 0;
            int n = lbdsus.Items.Count;
            for(int i=0;i<n;i++)
            {
                lbdsus.SetSelected(i, true);
                t += int.Parse((string)lbdsus.SelectedItem);
                
            }
            MessageBox.Show("Tổng các ước số là:" + t.ToString());
        }

        private void btnsluschan_Click(object sender, EventArgs e)
        {
            int count = 0;
            int n = lbdsus.Items.Count;
            for(int i=0;i<n;i++)
            {
                lbdsus.SetSelected(i, true);
                if (int.Parse((string)lbdsus.SelectedItem) % 2 == 0)
                    count++;

            }
            MessageBox.Show("Số lượng các ước số chẵn là:" + count.ToString());
        }

        public static bool LaSoNT(int n)
        {
            if(n==1 || n==0)
            {
                return false;
            }
            
                for (int i = 2; i <= n / 2; i++)
                    if (n % i == 0)
                        return false;
                return true;
            
            
        }

        private void btnslusngto_Click(object sender, EventArgs e)
        {
            int tongsont = 0;
            int n = lbdsus.Items.Count;
            for(int i=0;i<n;i++)
            {
                lbdsus.SetSelected(i, true);
                if (LaSoNT(int.Parse((string)lbdsus.SelectedItem)))
                {
                    tongsont++;
                    
                }
                
            }
            MessageBox.Show("Số lượng các ước số nguyên tố là:" + tongsont.ToString());
            
        }
    }
}
