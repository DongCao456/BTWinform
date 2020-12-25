using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyMaytinhPH
{
    public class MayTinh
    {
        QlyMayTinhDataContext db;

        public MayTinh()
        {
            db = new QlyMayTinhDataContext();
        }

        public IEnumerable<tblMaytinh> GetMaytinhs()
        {
            IEnumerable<tblMaytinh> q = from n in db.tblMaytinhs
                                        select n;

            return q;
        }

        public IEnumerable<tblMaytinh> GetMaytinhsThuocPhong(string maPhong)
        {
            IEnumerable<tblMaytinh> q = from n in db.tblMaytinhs
                                        where n.msPhong.Equals(maPhong)
                                        orderby n.HardDisk
                                        select n;
            return q;
        }

        public IEnumerable<tblMaytinh> LocMTtheoAutoComplete(string gtTim,bool theoCPU)
        {
            IEnumerable<tblMaytinh> q;
            if(theoCPU)
            {
                q = from n in db.tblMaytinhs
                    where n.CPU.StartsWith(gtTim)
                    orderby n.HardDisk
                    select n;

            }
            else
            {
                q = from n in db.tblMaytinhs
                    where n.msMay.Equals(gtTim)
                    orderby n.HardDisk descending
                    select n;
            }
            return q;
        }

        public bool CheckIfExist(tblMaytinh MT)
        {
            tblMaytinh tbl = db.tblMaytinhs.Where(x => x.msMay == MT.msMay).FirstOrDefault();
            if (tbl != null)
                return true;
            return false;
        }

        public void InsertNewMT(tblMaytinh MT)
        {
            try
            {
                if(!CheckIfExist(MT))
                {
                    db.tblMaytinhs.InsertOnSubmit(MT);
                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Đã trùng mã");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message+"abc");
            }
        }

        public void DeleteMT(tblMaytinh MT)
        {
            if (CheckIfExist(MT))
                db.tblMaytinhs.DeleteOnSubmit(MT);
            db.SubmitChanges();
        }

        public void UpdateMT(tblMaytinh newMT)
        {
            IEnumerable<tblMaytinh> q = from n in db.tblMaytinhs
                                        where n.msMay == newMT.msMay
                                        select n;
            if(q.First().msMay.Length>0)
            {
                q.First().CPU = newMT.CPU;
                q.First().HardDisk = newMT.HardDisk;
                q.First().RAM = newMT.RAM;
                q.First().VGA = newMT.VGA;
                q.First().Monitor = newMT.Monitor;
                db.SubmitChanges();
            }
        }
    }
}
