using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm___Bai_2___Phan_Khanh_Sinh_
{
    public class ThietBi
    {
        // 1. Các thuộc tính
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        // 2. Hàm khởi tạo có tham số (Constructor)
        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, double donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        // 3. Phương thức ThanhTien
        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        // 4. Phương thức HienThi (Trả về chuỗi thông tin để dễ dàng đưa lên Form)
        public string HienThi()
        {
            return $" Mã: {MaThietBi}\n" +
                   $" Tên: {TenThietBi}\n" +
                   $" Nước SX: {NuocSanXuat} \n" +
                   $" Đơn giá: {DonGia:N0}đ \n" +
                   $" Số lượng: {SoLuong}\n" +
                   $" Thành tiền: {ThanhTien():N0}đ";
        }
    }
}
