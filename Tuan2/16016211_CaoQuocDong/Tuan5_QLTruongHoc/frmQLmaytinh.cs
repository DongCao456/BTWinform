using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_QLTruongHoc
{
    public partial class formQLPhongMay : Form
    {
        public formQLPhongMay()
        {
            InitializeComponent();
        }
        TreeNode nGoc;
        clsPhonghoc objPhong = new clsPhonghoc();
        clsMaytinh objMaytinh = new clsMaytinh();
        private void formQLPhongMay_Load(object sender, EventArgs e)
        {
            treePhong.ImageList = imgTree;
            treePhong.SelectedImageIndex = 1;
            treePhong.ImageIndex = 0;
            nGoc = new TreeNode("Danh sách Phòng");
            treePhong.Nodes.Add(nGoc);
            IEnumerable<tblPhonghoc> lstPhong = objPhong.getPhong();
            LoadTree(lstPhong);
            
        }

        void LoadTree(IEnumerable<tblPhonghoc> lstPhong)
        {
            TreeNode nconPhong;
            IEnumerable<tblMaytinh> listMayThuocPhong;
            foreach(tblPhonghoc p in lstPhong)
            {
                nconPhong = new TreeNode("Phòng:" + p.tenPhong);
                listMayThuocPhong = objMaytinh.getMaythuocPhong(p.msPhong);
                LoadMayThuocPhong(nconPhong, listMayThuocPhong);
                nconPhong.Tag = p.msPhong;
                nGoc.Nodes.Add(nconPhong);
            }
            treePhong.ExpandAll();
        }
        void LoadMayThuocPhong(TreeNode nPhong,IEnumerable<tblMaytinh> lstMT)
        {
            TreeNode nConMay;
            foreach(tblMaytinh mTinh in lstMT)
            {
                nConMay = new TreeNode("Mã máy:" + mTinh.msMay);
                nConMay.Tag = mTinh;
                nPhong.Nodes.Add(nConMay);
            }    
        }
    }
}
