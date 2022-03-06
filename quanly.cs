using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace quanlythuexe
{
    internal class ThueXe
    {
       public oto a=new oto();
       public khachhang b = new khachhang();
       public NhanVien c=new NhanVien();
        private DateTime _ngayThue;
        private DateTime _ngayTra;
        private int _tienCoc;
        public int tienCoc
        {
            get { return _tienCoc; }
            set { _tienCoc = value;}
        }
        public DateTime NgayThue
        {
            get { return _ngayThue; }
            set { _ngayThue = value;}
        }
        public DateTime NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value;}
        }
        public override string ToString()
        {
            string s = $"Thong Tin khach hang {b.TenKhackHang} {b.CMND} {b.DiaChi} {b.SDT}" +
                $"Nhan Vien {c.TenKhackHang}" +
                $"Oto {a.BienSoXe} {a.NamSanXuat} {a.TenXe} {a.Hangxe} {a.GiaXe} {a.TinhTrangThue}";
            return s;
        }




    }
}
