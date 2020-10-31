using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_QuanlyCD
{
    public partial class frmQLCD : Form
    {
        public frmQLCD()
        {
            InitializeComponent();
        }
        DanhSachKhachThue objdansach = new DanhSachKhachThue();
        int vitrihientai = 0;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQLCD_Load(object sender, EventArgs e)
        {
            
            lsvDS.View = View.Details;
            lsvDS.GridLines = true;
            lsvDS.FullRowSelect = true;

            
            lsvDS.Columns.Add("Mã");
            lsvDS.Columns.Add("Tên");
            lsvDS.Columns.Add("Số lượng");
            lsvDS.Columns.Add("Đơn giá");
            lsvDS.Columns.Add("Giảm giá");
            lsvDS.Columns.Add("Thành tiền");

            txtmaKH.Text = "11";
            txthotenKH1.Text = "Đông";
            txtdongiatien.Text = "10000";
            cbbsl.Text = "1";
            //Combobox đơn giá
            for(int i=1;i<=100;i++)
            {
                cbbsl.Items.Add(i);
            }
            

            rd3p.Checked = true;
        }

        

        private void btntongtien_Click(object sender, EventArgs e)
        {

        }

        private void btntinhthue_Click(object sender, EventArgs e)
        {
            try
            {
                Khachthue khach = new Khachthue();
                
                khach.Maso = Convert.ToInt32(txtmaKH.Text);
                khach.Hoten = txthotenKH1.Text;
                khach.Soluong = Convert.ToInt32(cbbsl.Text);
                khach.Dongia = Convert.ToInt32(txtdongiatien.Text);
                if (rd3p.Checked)
                    khach.Trangthai = true;
                else
                    khach.Trangthai = false;
                if (objdansach.ThemKhachThue(khach))
                {
                    lsvDS.Items.Clear();
                    LoadToanDSLV(objdansach.GetAllKhachThue());
                }
                else
                {
                    MessageBox.Show("Trùng mã");
                }
                
			}

			catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        void LoadToanDSLV(ArrayList AllDS)
        {
            ListViewItem lvwItem;
            foreach (Khachthue item in AllDS)
            {
                lvwItem = new ListViewItem(item.Maso.ToString());
                lvwItem.SubItems.Add(item.Hoten);
                lvwItem.SubItems.Add(item.Soluong.ToString());
                lvwItem.SubItems.Add(item.Dongia.ToString());
                lvwItem.SubItems.Add(item.Thuongphat().ToString());
                lvwItem.SubItems.Add(item.Thanhtien().ToString("#,##0.0"));
                lvwItem.ImageIndex = 0;
                lvwItem.Tag = item;
                lsvDS.Items.Add(lvwItem);
            }
        }
        void XoaitemDangchon(ListView lvw)
        {
            Khachthue khachDeXoa = null;
            foreach (ListViewItem item in lsvDS.SelectedItems)
            {
                khachDeXoa = (Khachthue)item.Tag;
                objdansach.Xoakhach(khachDeXoa);
            }
        }

		

        void LoadObjToText(Khachthue objKhach)
        {
            txtmaKH.Text = objKhach.Maso.ToString();
            txthotenKH1.Text = objKhach.Hoten;
            txtdongiatien.Text = objKhach.Dongia.ToString();
            
            


        }
        private void lsvDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDS.SelectedItems.Count > 0)
            {
                btnthoat.Enabled = true;
                vitrihientai = Convert.ToInt32(lsvDS.SelectedIndices[0].ToString());
                Khachthue objkhach = (Khachthue)lsvDS.Items[vitrihientai].Tag;
                LoadObjToText(objkhach);
                vitrihientai += 1;
                txtThongtin.Text = vitrihientai.ToString() +"/"+lsvDS.Items.Count.ToString();
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
		{
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                XoaitemDangchon(lsvDS);
                btnxoa.Enabled = false;
                lsvDS.Items.Clear();
                LoadToanDSLV(objdansach.GetAllKhachThue());
            }
		}

		private void btncapnhat_Click(object sender, EventArgs e)
		{
            Khachthue khach = new Khachthue();

            khach.Maso = Convert.ToInt32(txtmaKH.Text);
            khach.Hoten = txthotenKH1.Text;
            khach.Soluong = Convert.ToInt32(cbbsl.Text);
            khach.Dongia = Convert.ToInt32(txtdongiatien.Text);
            if (rd3p.Checked)
                khach.Trangthai = true;
            else
                khach.Trangthai = false;

            objdansach.SuaThongTinKhach(khach);
                lsvDS.Items.Clear();
                LoadToanDSLV(objdansach.GetAllKhachThue());
            
            
        }

		private void btnnext_Click(object sender, EventArgs e)
		{
            if (vitrihientai < lsvDS.Items.Count)
            {
                lsvDS.Items[vitrihientai - 1].Selected = false;
                vitrihientai += 1;
                txtThongtin.Text = vitrihientai.ToString() + "/" + lsvDS.Items.Count.ToString();
                lsvDS.Items[vitrihientai - 1].Selected = false;
                lsvDS.Focus();
            }
            else if (vitrihientai != 0)
            {
                lsvDS.Items[vitrihientai - 1].Selected = false;
               
                lsvDS.Items[0].Selected = true;
                lsvDS.Focus();
            }

        }

		private void button6_Click(object sender, EventArgs e)
		{
            if (vitrihientai >1)
            {
                lsvDS.Items[vitrihientai - 1].Selected = false;
                vitrihientai -= 1;
                txtThongtin.Text = vitrihientai.ToString() + "/" + lsvDS.Items.Count.ToString();
                lsvDS.Items[vitrihientai - 1].Selected = true;
                lsvDS.Focus();
            }
        }
	}
}
