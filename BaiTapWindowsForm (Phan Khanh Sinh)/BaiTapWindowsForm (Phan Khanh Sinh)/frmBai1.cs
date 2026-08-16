using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm__Phan_Khanh_Sinh_
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        // Click đôi vào thanh tiêu đề của form

        private void label2_Click(object sender, EventArgs e)
        {
            // Khai báo và khởi tạo biến đối tượng HangHoa
            HangHoa hh = new HangHoa();

            hh.MaHang = "HH01";
            hh.TenHang = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 4;
            hh.DonGia = 200000;

            // Hiển thị kết quả sử dụng lblThongBao
            lblThongBao.Text = hh.HienThi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
