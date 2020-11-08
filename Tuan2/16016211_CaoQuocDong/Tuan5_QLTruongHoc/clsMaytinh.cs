using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QLTruongHoc
{

    public class clsMaytinh:clsKetnoi
    {
        public QLPhonghocDataContextDataContext dt;

        public clsMaytinh()
        {
            dt = getDatacontext();
        }

        public IEnumerable<tblMaytinh> getMaythuocPhong(string strMaphong)
        {
            IEnumerable<tblMaytinh> p = from n in dt.tblMaytinhs
                                        where n.msPhong.Equals(strMaphong)
                                        select n;
            return p;

        }
    }
}
