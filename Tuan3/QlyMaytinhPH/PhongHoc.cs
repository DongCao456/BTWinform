using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyMaytinhPH
{
    public class PhongHoc
    {
        QlyMayTinhDataContext db;
        public PhongHoc()
        {
            db = new QlyMayTinhDataContext();
        }

        public IEnumerable<tblPhonghoc> GetPhonghocs()
        {
            IEnumerable<tblPhonghoc> q = from n in db.tblPhonghocs
                                         select n;
            return q;
        }
    }
}
