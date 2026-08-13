using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class HangHoa
{
    // 1. Các thuộc tính (Properties)
    public string MaHang { get; set; }
    public string TenHang { get; set; }
    public string DVT { get; set; } // Đơn vị tính
    public int SoLuong { get; set; }
    public double DonGia { get; set; }

    // 2. Hàm khởi tạo không có tham số (No-argument Constructor)
    public HangHoa()
    {
    }

    // 3. Phương thức hiển thị tất cả thông tin của hàng hóa
    public string HienThi()
    {
        return string.Format(" {0}, {1}, {2}, {3}, {4}", MaHang, TenHang, DVT, SoLuong, DonGia);
    }
}


