using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace quanlythuexe
{
    internal class quanlychucnang
    {
        List<oto> ds = new List<oto>();
        List<ThueXe> thueXeds = new List<ThueXe>();
        public void KhoiTaoDanhSachXe()
        {
            string []files = File.ReadAllLines("danhsachxe.txt");
            for (int i = 0; i < files.Length; i++)
            {
                string []s = files[i].Split(" ");
                oto h = new oto();
                h.BienSoXe = s[0].Trim();
                h.TenXe = s[1].Trim();
                h.Hangxe= s[2].Trim();
                h.NamSanXuat = int.Parse(s[3].Trim());
                h.GiaXe = int.Parse(s[4].Trim());
                h.TinhTrangThue=bool.Parse(s[5].Trim());
                ds.Add(h);
            }
        }
        public void ThanhToanHoaDon()
        {
            int i = 0;
            foreach (var item in thueXeds)
            {
                Console.WriteLine($"{i} {item.ToString()}");
            }
            Console.Write("chon khach Hang de thanh toan :");
            int result = int.Parse(Console.ReadLine());
           double soNgayThue=TienIch.TinhSoNgay(thueXeds[result].NgayThue, thueXeds[result].NgayTra);
            double priceThue= soNgayThue * thueXeds[result].a.GiaXe;//tien thue
            double sumPrice = soNgayThue * thueXeds[result].a.GiaXe - thueXeds[result].tienCoc;//tong tien

           
        }
        public void DanhsachXeChuaThue()
        {
            int i = 0;
            foreach (var item in ds)
            {
                if (item.TinhTrangThue==false)
                {
                    Console.WriteLine($"{i}  {item.ToString()}");
                    i++;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
        public void ThueXe()
        {
            ThueXe a = new ThueXe();
            a.b.NhapthongTinKhachHang();
            Console.Write("nhap ten nhan vien");
            a.c.TenKhackHang=Console.ReadLine();
            Console.Write("moi ban nhap ngay thue :");
            a.NgayThue=DateTime.Parse(Console.ReadLine());
            Console.Write("moi ban nhap ngay tra :");
            a.NgayTra = DateTime.Parse(Console.ReadLine());
            Console.Write("Tien coc :");
            a.tienCoc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int i = 0;
            foreach (var item in ds)
            {
                
                Console.WriteLine($"{i} {item.ToString()}");
                i++;
            }
            Console.Write("ban muon chon xe nao :");
            int result = int.Parse(Console.ReadLine());
            a.a = ds[result];
            a.a.TinhTrangThue = true;
            thueXeds.Add(a);
        }
        public void XuatDanhSachXe()
        {
            foreach (var item in ds)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void DanhSachKhachDangThue()
        {
            foreach (var item in thueXeds)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
