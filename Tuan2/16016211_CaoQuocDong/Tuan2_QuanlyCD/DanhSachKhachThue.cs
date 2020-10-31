using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2_QuanlyCD
{
	class DanhSachKhachThue
	{
		ArrayList ds;

		public DanhSachKhachThue()
		{
			ds = new ArrayList();
		}

		public bool ThemKhachThue(Khachthue KT)
		{
			if (ds.Contains(KT))
				return false;
			else {
				ds.Add(KT);
				return true;
			}
		}

		public Khachthue Timkhach(int ma)
		{
			foreach (Khachthue item in ds)
			{
				if (item.Maso == ma)
					return item;
			}
			return null;
		}
		public void Xoakhach(Khachthue ma)
		{
			ds.Remove(ma);
		}

		public void SuaThongTinKhach(Khachthue khachDaSua)
		{
			int vitriTimThay = ds.IndexOf(khachDaSua);
			if (vitriTimThay >= 0)
				ds[vitriTimThay] = khachDaSua;
		}

		public ArrayList GetAllKhachThue()
		{
			return ds;
		}
	}
}
