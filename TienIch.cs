using System;
using System.Collections.Generic;
using System.Text;

namespace quanlythuexe
{
    static class TienIch
    {
       public static double TinhSoNgay(DateTime start,DateTime end)
        {
            TimeSpan ts=end-start;
            return ts.TotalDays;


            
        }
    }
}
