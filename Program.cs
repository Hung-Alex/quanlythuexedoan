using System;

namespace quanlythuexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*quanlychucnang ds= new quanlychucnang();
             ds.KhoiTaoDanhSachXe();
             Console.WriteLine("danh sach xe chua co nguoi thue :");
             ds.DanhsachXeChuaThue();
             Console.WriteLine();
             Console.WriteLine("thue xe");
             ds.ThueXe();
             Console.WriteLine("danh sach xe dang thue");
             ds.DanhSachKhachDangThue();

             ds.DanhsachXeChuaThue();
            */
            DateTime a=new DateTime(2020,2,1);
            DateTime b = new DateTime(2020, 2, 15);
            TimeSpan ts = b - a;
            Console.WriteLine(ts.TotalDays);

            

        }
    }
}
