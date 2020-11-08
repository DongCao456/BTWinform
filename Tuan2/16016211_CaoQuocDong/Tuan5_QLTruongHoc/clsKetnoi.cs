using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QLTruongHoc
{
    public class clsKetnoi
    {
        private QLPhonghocDataContextDataContext db;

        public QLPhonghocDataContextDataContext getDatacontext()
        {
            string strKetnoi = @"Data Source=H41-M06;Initial Catalog=QLTRUONGHOC;Integrated Security=True";
            db = new QLPhonghocDataContextDataContext(strKetnoi);
            db.Connection.Open();
            return db;
        }
    }
}
