using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm___Bai_2___Phan_Khanh_Sinh_
{
    class NoiChuoi_GiaiThua
    {
        // Hàm tĩnh nối chuỗi: Kết quả trả về thông qua tham số s nhờ từ khóa 'out'
        public static void NoiChuoi(string ho, string ten, out string s)
        {
            s = ho + " " + ten;
        }

        // Hàm tĩnh tính giai thừa của số nguyên dương n
        public static long GiaiThua(int n)
        {
            if (n < 0) return 0; // Tránh trường hợp n âm trái logic đề bài

            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return (long) kq;
        }
    }
}
