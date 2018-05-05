using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Giohang
    {
        dbQLBANSACHDataContext data = new dbQLBANSACHDataContext();
        public int iMasach { set; get; }
        public string sTensach { set; get; }
        public string sHinhminhhoa { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        public Giohang (int Masach)
        {
            iMasach = Masach;
            SACH sach = data.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sHinhminhhoa = sach.Hinhminhhoa;
            dDongia = Double.Parse(sach.Dongia.ToString());
            iSoluong = 1;
        }
    }
}