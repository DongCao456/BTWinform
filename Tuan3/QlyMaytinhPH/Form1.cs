using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyMaytinhPH
{
    public partial class frmQLY : Form
    {
        public frmQLY()
        {
            InitializeComponent();
        }
        TreeNode nGoc=null;
        MayTinh mt = new MayTinh();
        PhongHoc ph = new PhongHoc();

        void TaoNutMayThuocPhong(TreeNode nPhong,IEnumerable<tblMaytinh> dsMayTinh)
        {
            TreeNode nmay;
            foreach(tblMaytinh mt in dsMayTinh)
            {
                nmay = new TreeNode();
                nmay.Text = "Máy tính có CPU" + mt.CPU;
                nmay.Tag = mt;
                nPhong.Nodes.Add(nmay);
            }
        }

        void LoadTree(TreeView tre)
        {
            trwPhong.Nodes.Clear();
            IEnumerable<tblPhonghoc> dsP = ph.GetPhonghocs();
            string masoPhong;
            tre.Nodes.Clear();
            TreeNode nPhong;
            IEnumerable<tblMaytinh> getMayThuocPhong;
            foreach(tblPhonghoc phong in dsP)
            {
                nPhong = new TreeNode();
                nPhong.Text = "Phòng" + phong.tenPhong.ToString();
                nPhong.Tag = phong.msPhong;
                masoPhong = phong.msPhong;
                getMayThuocPhong = mt.GetMaytinhsThuocPhong(masoPhong);
                TaoNutMayThuocPhong(nPhong, getMayThuocPhong);
               nGoc.Nodes.Add(nPhong);
            }
            tre.Nodes.Add(nGoc);
            tre.ExpandAll();
        }

        private void frmQLY_Load(object sender, EventArgs e)
        {
            trwPhong.ImageList = imageTree;
            trwPhong.ImageIndex = 0;
            trwPhong.SelectedImageIndex = 1;
            nGoc = new TreeNode("Danh Sách Phòng Máy");
            LoadTree(trwPhong);
            CreateColumn(lvwMay);
            btnLuuMoi.Enabled = false;
        }

        void  CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.FullRowSelect = true;
            lvw.GridLines = true;
            lvw.Columns.Add("Mã số máy", 80);
            lvw.Columns.Add("CPU", 150);
            lvw.Columns.Add("HardDisk", 150);
            lvw.Columns.Add("RAM", 150);
            lvw.Columns.Add("VGA", 80);
            lvw.Columns.Add("Monitor", 80);
            lvw.Columns.Add("Phòng", 80);
        }

        void LoadMayTinh(ListView lvw,IEnumerable<tblMaytinh> dsMaytinhs)
        {
            lvw.Items.Clear();
            
            foreach (tblMaytinh mt in dsMaytinhs)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = mt.msMay;
                listViewItem.SubItems.Add(mt.CPU);
                listViewItem.SubItems.Add(mt.HardDisk);
                listViewItem.SubItems.Add(mt.RAM);
                listViewItem.SubItems.Add(mt.VGA);
                listViewItem.SubItems.Add(mt.Monitor);
                listViewItem.SubItems.Add(mt.msPhong);
                
                listViewItem.Tag = mt;
                lvw.Items.Add(listViewItem);
            }
        }

        void GanObjectToField(tblMaytinh mt)
        {
            txtMamay.Text = mt.msMay;
            txtCPU.Text = mt.CPU;
            txtHDisk.Text = mt.HardDisk;
            txtRam.Text = mt.RAM;
            txtVGA.Text = mt.VGA;
            txtMonitor.Text = mt.Monitor;
            txtPhong.Text = mt.msPhong;
        }

        void GanObjectToField1(tblMaytinh mt)
        {
            
            txtPhong.Text = mt.msPhong;
        }

        private void trwPhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            string msPhong;
            IEnumerable<tblMaytinh> dsMaytinhs;
            if(trwPhong.SelectedNode!=null)
            {
                if(trwPhong.SelectedNode.Level == 1)
                {
                    
                    msPhong = trwPhong.SelectedNode.Tag.ToString();
                    txtPhong.Text = msPhong;
                    dsMaytinhs = mt.GetMaytinhsThuocPhong(msPhong);
                    
                    LoadMayTinh(lvwMay, dsMaytinhs);

                }
                else if(trwPhong.SelectedNode.Level == 2)
                {
                    tblMaytinh mtinh = null;
                    mtinh = (tblMaytinh)trwPhong.SelectedNode.Tag;
                    GanObjectToField(mtinh);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text.Equals("Thêm"))
            {
                btnThem.Text = "Hủy";
                btnLuuMoi.Text = "Lưu Mới";
                btnLuuMoi.Enabled = true;
                btnLuuSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Text = "Thêm";
                btnLuuMoi.Enabled = false;
                btnLuuSua.Enabled = true;
                btnXoa.Enabled = true;
                ClearText();
            }
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            if(btnLuuSua.Text.Equals("Sửa"))
            {
                btnLuuSua.Text = "Hủy";
                btnLuuMoi.Text = "Lưu Sửa";
                btnLuuMoi.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnLuuSua.Text = "Sửa";
                btnLuuMoi.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                ClearText();
            }
        }

        tblMaytinh GanDoiTuong()
        {
            tblMaytinh mt = new tblMaytinh();
            mt.msMay = txtMamay.Text.Trim();
            mt.CPU = txtCPU.Text;
            mt.HardDisk = txtHDisk.Text;
            mt.RAM = txtRam.Text;
            mt.VGA = txtVGA.Text;
            mt.Monitor = txtMonitor.Text;
            mt.msPhong = trwPhong.SelectedNode.Tag.ToString();
            return mt;
        }

        void ClearText()
        {
            txtMamay.Text = " ";
            txtCPU.Text = " ";
            txtHDisk.Text = " ";
            txtRam.Text = " ";
            txtVGA.Text = " ";
            txtMonitor.Text = " ";
            txtPhong.Text = " ";
        }
        private void btnLuuMoi_Click(object sender, EventArgs e)
        {
            string msPhong;
            IEnumerable<tblMaytinh> dsmayTinh;
            if(btnLuuMoi.Text.Equals("Lưu Mới"))
            {
                tblMaytinh mtMoi = GanDoiTuong();
                try {
                    mt.InsertNewMT(mtMoi);
                    msPhong = trwPhong.SelectedNode.Tag.ToString();
                    dsmayTinh = mt.GetMaytinhsThuocPhong(msPhong);
                    ClearText();
                    LoadTree(trwPhong);
                    LoadMayTinh(lvwMay, dsmayTinh);
                }
                catch
                {
                    MessageBox.Show("Trùng Mã");
                }
              
                
            }
            else
            {
                tblMaytinh mtMoi = GanDoiTuong();
                mt.UpdateMT(mtMoi);
                msPhong = trwPhong.SelectedNode.Tag.ToString();
                dsmayTinh = mt.GetMaytinhsThuocPhong(msPhong);
                LoadMayTinh(lvwMay, dsmayTinh);
                LoadTree(trwPhong);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            string msPhong;
            tblMaytinh mtXoa = null;
            IEnumerable<tblMaytinh> dsmaytinhXoa;
            r = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r==DialogResult.Yes)
            {
                if (lvwMay.SelectedItems.Count > 0)
                {
                    mtXoa = (tblMaytinh)lvwMay.SelectedItems[lvwMay.SelectedItems.Count - 1].Tag;
                    mt.DeleteMT(mtXoa);
                    msPhong = trwPhong.SelectedNode.Tag.ToString();
                    dsmaytinhXoa = mt.GetMaytinhsThuocPhong(msPhong);
                    LoadMayTinh(lvwMay, dsmaytinhXoa);
                    ClearText();
                }
            }
            
        }
    }
}
