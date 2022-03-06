using System;
using System.Collections.Generic;
using System.Text;

namespace quanlythuexe
{
    internal class khachhang
    {
        private string _tenKhackHang;
        private string _cMND;
        private string _sDT;
        private string _diaChi;
        
        public string TenKhackHang
        {
            get { return _tenKhackHang;}
            set { _tenKhackHang = value;}
        }
        public string CMND
        {
            get { return _cMND;}
            set { _cMND = value;}
        }
        public string SDT
        {
            get { return _sDT;}
            set { _sDT = value;}
        }
        public string DiaChi
        {
            get { return _diaChi;}
            set { _diaChi = value;}
        }
        public void NhapthongTinKhachHang()
        {
            Console.Write("moi ban nhap ten :");
            this.TenKhackHang = Console.ReadLine();
            Console.Write("moi ban nhap SDT :");
            this.SDT = Console.ReadLine();
            Console.Write("moi ban nhap CMND :");
            this.CMND= Console.ReadLine();
            Console.Write("moi ban nhap dia chi :");
            this.DiaChi = Console.ReadLine();
        }
        
    }
}
