using System;
using System.Collections.Generic;
using System.Text;

namespace quanlythuexe
{
    internal class oto
    {
        private string _bienSoXe;
        private string _tenXe;
        private string _hangxe;
        private int _namSanXuat; //fields //trường
        private int _giaXe;
        private bool _tinhTrangThue;
        public oto()
        {

        }
        public oto(string bienso, string ten, string hang, int nam, int gia, bool tinhTrang)
        {
            this._bienSoXe = bienso;
            this._tenXe = ten;
            this._hangxe = hang;
            this._namSanXuat = nam;
            this._giaXe = gia;
            this._tinhTrangThue = tinhTrang;

        }
        public bool TinhTrangThue
        {
            get { return _tinhTrangThue; }
            set { _tinhTrangThue = value; }
        }
        public string BienSoXe //property thuoc tinh
        {
            get { return _bienSoXe; }
            set { this._bienSoXe = value; }
        }
        public string TenXe
        {
            get { return _tenXe; }
            set { this._tenXe = value; }
        }
        public string Hangxe
        {
            get { return _hangxe; }
            set { this._hangxe = value; }
        }
        public int NamSanXuat
        {
            get { return _namSanXuat; }
            set { this._namSanXuat = value; }
        }
        public int GiaXe
        {
            get { return _giaXe; }
            set { this._giaXe = value; }
        }
        public override string ToString()
        {
            string s = $"{this.BienSoXe} {this.TenXe} {this.Hangxe} {this.NamSanXuat.ToString()} {this.GiaXe.ToString()} {this.TinhTrangThue.ToString()}";

            return s;
        }
    }
}
