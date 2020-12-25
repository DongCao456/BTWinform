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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MayTinh objMT=new MayTinh();
        IEnumerable<tblMaytinh> dsmaytinh;
        private void rdbMP_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbMP.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach(tblMaytinh mtTim in dsmaytinh)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(mtTim.msPhong);
                }
            }
        }

        private void rdbCPU_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbCPU.Checked)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                foreach(tblMaytinh mtTim in dsmaytinh)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(mtTim.CPU);
                }
            }
        }

        void FormatLuoi(DataGridView dtg)
        {
            dtg.Columns["CPU"].HeaderText = "Vi Xử Lý";
            dtg.Columns["cpu"].Width = 80;
            dtg.Columns["msmay"].HeaderText = "Mã Máy";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dsmaytinh = objMT.GetMaytinhs();
            dtgvMayTinh.DataSource = dsmaytinh.ToList();
            FormatLuoi(dtgvMayTinh);
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            rdbMP.Checked = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            IEnumerable<tblMaytinh> dstimMT = objMT.LocMTtheoAutoComplete(txtTimKiem.Text, rdbCPU.Checked);
            dtgvMayTinh.DataSource = dstimMT;
            FormatLuoi(dtgvMayTinh);
        }
    }
}
