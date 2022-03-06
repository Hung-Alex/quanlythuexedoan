using System;
using System.Collections.Generic;
using System.Text;

namespace quanlythuexe
{
    internal class Hoadon:ThueXe
    {
        private double _tienThue;
        private double _tienCoc;
        private double _tongTien;
        private string _maID;
        
        public Hoadon(string tenXe,string bienSo,string ten,string tenv,double tienThue,double tienCoc,double TongTien,DateTime ngayThue,DateTime ngayTra,string maID)
        {
            this._maID = maID;
            this.a.TenXe = tenXe;
            this.a.BienSoXe = bienSo;
            this.b.TenKhackHang=ten;
            this.c.TenKhackHang = tenv;
            this.NgayThue = ngayThue;
            this.NgayTra = ngayTra;      
            this._tienThue = tienThue;
            this._tienCoc=tienCoc;
            this._tongTien = TongTien;      
        }
        public override string ToString()
        {
            return $"";
        }
    }
}
