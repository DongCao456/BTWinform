using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QLTruongHoc
{
    public class clsPhonghoc:clsKetnoi
    {
        public QLPhonghocDataContextDataContext dt;

        public clsPhonghoc()
        {
            dt = getDatacontext();
        }

        public IEnumerable<tblPhonghoc> getPhong()
        {
            IEnumerable<tblPhonghoc> p = from n in dt.tblPhonghocs
                                         select n;
            return p;
        }

        
    }
}
