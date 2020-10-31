using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_Cinema
{
    public partial class frmCinema : Form
    {
        public frmCinema()
        {
            InitializeComponent();
        }
        const int DAYA = 100;
        const int DAYB = 200;
        const int DAYC = 300;
        
        private void frmCinema_Load(object sender, EventArgs e)
        {
            CreateButton(15);
            statusStrip1.Items[2].Text = "Ngày:" + DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Interval = 1000;
            timer1.Start();
        }

        public void CreateButton(int n)
        {
            Button btn;
            for (int i= 1; i<= n;i++)
            {
                btn = new Button();
                btn.Text = i.ToString();
                btn.Name = "A" + i.ToString();
                btn.Width = 107;
                btn.Height =100;
                btn.BackColor = Color.Gray;
                btn.Click += new EventHandler(btnTuchon_Click);
                flowLayoutPanel1.Controls.Add(btn);
                
            }
        }

        private void btnTuchon_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tienchon = 0;
            if (btn.BackColor != Color.Yellow)
                btn.BackColor = Color.Yellow;
            else
                btn.BackColor = Color.Gray;
            
            tienchon = Tintiendangchon();
            txtGia.Text = tienchon.ToString("#,##0");
            
        }

        private int Tintiendangchon()
        {
            int Giatri = 0;
            int tien = 0;
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.BackColor == Color.Yellow)
                {
                    Giatri = Convert.ToInt32(btn.Text);
                    if (Giatri <= 5)
                        tien += DAYA;
                    else if (Giatri <= 10)
                        tien += DAYB;
                    else
                        tien += DAYC;

                }
            }
            return tien;
        }
        private int Tintongtien()
        {
            int Giatri = 0;
            int tien = 0;
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.BackColor == Color.Aqua)
                {
                    Giatri = Convert.ToInt32(btn.Text);
                    if (Giatri <= 5)
                        tien += DAYA;
                    else if (Giatri <= 10)
                        tien += DAYB;
                    else
                        tien += DAYC;

                }
            }
            return tien;
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach(Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.BackColor == Color.Yellow)
                {
                    
                    btn.BackColor = Color.Aqua;
                    btn.Enabled = false;
                }
                
            }
            txtGia.Text = "";
            statusStrip1.Items[1].Text = Tintongtien().ToString("#,##0");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.BackColor == Color.Yellow)
                {

                    btn.BackColor = Color.Gray;
                    
                }

            }
            txtGia.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[3].Text = DateTime.Now.ToLongTimeString();
        }
    }
}
