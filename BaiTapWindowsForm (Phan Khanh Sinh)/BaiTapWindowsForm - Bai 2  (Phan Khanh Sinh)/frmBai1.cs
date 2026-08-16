using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm___Bai_2___Phan_Khanh_Sinh_
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void lblTTTB_Click(object sender, EventArgs e)
        {
            // Khai báo và sử dụng biến đối tượng ThietBi bằng hàm khởi tạo có tham số
               ThietBi tb = new ThietBi("TB01", "Máy tính Dell", "Hoa Kỳ", 15000000, 2);

            // Gọi phương thức hiển thị thông tin đối tượng lên MessageBox hoặc ListBox
               lblTTTB.Text = tb.HienThi();
        }
    }
}
