using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_QuanLyCafeSV
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
            txtTenKhach.Text = "Đông";
            txtTongTien.Text = "0";
            lblTien.Hide();
            btnThanhToan.Enabled = false;
            btnNhapLai.Enabled = false;
            
        }
        int vitrihientai = 0;
        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {

        }
        int tien1, tien2, tien3, tien4, tien5;

        private void rdcafeSuaDa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcafeSuaDa.Checked == true)
                tien5 = 30000;
            else
                tien5 = 0;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tienchon = 0;
           
            
            if(txtTenKhach.Text.Trim().Length==0)
            {
                MessageBox.Show("Phải Nhập Tên Khách");
            }
            else
            {               
                vitrihientai += 1;
                txtTongKhach.Text = Convert.ToString(vitrihientai);
                tienchon = tinhtien();
                MessageBox.Show("Số Tiền:" + tienchon);
                lblTien.Text = tienchon.ToString();
                txtTongTien.Text = Convert.ToString(Convert.ToInt32(txtTongTien.Text) + Convert.ToInt32(lblTien.Text));
                btnNhapLai.Enabled = true;
                btnThanhToan.Enabled = true;
                txtTenKhach.Clear();

            }
        }
        private int tinhtien()
        {
            int tien = 0;
            int tong = 0;
            if (cbSinhvien.Checked == false)
            {
                tien = tien1 + tien2 + tien3 + tien4 + tien5;
            }
            else
            {
                tien = Convert.ToInt32((tien1 + tien2 + tien3 + tien4 + tien5) * 0.8);
                
            }
            
            
            return tien;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            vitrihientai = 0;
            txtTongKhach.Text = Convert.ToString(vitrihientai);
            txtTongTien.Text = "0";
            btnThanhToan.Enabled = false;
            btnNhapLai.Enabled = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           tSTongKhach.Text= Convert.ToString(Convert.ToInt32(tSTongKhach.Text) + Convert.ToInt32(txtTongKhach.Text));
            tSTongTien.Text= Convert.ToString(Convert.ToInt32(tSTongTien.Text) + Convert.ToInt32(txtTongTien.Text));
            txtTenKhach.Clear();
            vitrihientai = 0;
            txtTongKhach.Text = Convert.ToString(vitrihientai);
            txtTongTien.Text = "0";
            btnThanhToan.Enabled = false;
            btnNhapLai.Enabled = false;
        }

        private void rdcafeKem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcafeKem.Checked == true)
                tien4 = 35000;
            else
                tien4 = 0;
        }

        private void rdcafeDa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcafeDa.Checked == true)
                tien3 = 25000;
            else
                tien3 = 0;
        }

        private void rdcafeSua_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcafeSua.Checked == true)
                tien2 = 25000;
            else
                tien2 = 0;
        }

        private void rdcafeDen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcafeDen.Checked == true)
                tien1 = 20000;
            else
                tien1 = 0;
        }
    }
}
