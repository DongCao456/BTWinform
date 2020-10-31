using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2_QuanlyCD
{
	class Khachthue
	{
		private int maso;
		private string hoten;
		private int soluong;
		private int dongia;
		private bool trangthai;

		public Khachthue()
		{
		}

		public Khachthue(int maso, string hoten, int soluong, int dongia, bool trangthai)
		{
			this.maso = maso;
			this.hoten = hoten;
			this.soluong = soluong;
			this.dongia = dongia;
			this.trangthai = trangthai;
		}

		public int Maso {
			get
			{
				return maso;
			}
			set
			{
				maso = value;
			}
		}
		public string Hoten
		{
			get
			{
				return hoten;
			}
			set
			{
				hoten = value;
			}
		}
		public int Soluong {
			get
			{
				return soluong;
			}
			set
			{
				soluong = value;
			}
		}
		public int Dongia {
			get
			{
				return dongia;
			}
			set
			{
				dongia = value;
			}
		}
		public bool Trangthai {

			get
			{
				return trangthai;
			}
			set
			{
				trangthai = value;
			}
		}

		public override bool Equals(object obj)
		{
			Khachthue objKhach = (Khachthue)obj;
			return this.Maso.Equals(objKhach.Maso);
		}

		public double Thanhtien()
		{
			double tTien = 0;
			tTien = (soluong * dongia) + Thuongphat();
			return tTien;
		}

		public double Thuongphat()
		{
			double thuongPhat = 0;
			if (trangthai)
			{
				thuongPhat = (soluong * dongia) * -0.03;
			}
			else
			{
				thuongPhat = (soluong * dongia) * 0.05;
			}
			return thuongPhat;
		}
	}
}
