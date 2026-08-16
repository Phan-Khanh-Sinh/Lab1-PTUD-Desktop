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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string hoInput = txtHo.Text.Trim();
            string tenInput = txtTen.Text.Trim();

            // Gọi hàm tĩnh từ lớp TienIch (Không cần khởi tạo đối tượng)
            string chuoiKetQua;
            NoiChuoi_GiaiThua.NoiChuoi(hoInput, tenInput, out chuoiKetQua);

            // Hiển thị kết quả
            txtKetQuaChuoi.Text = chuoiKetQua;
        }

        private void btnTinhGiaiThua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng có nhập đúng định dạng số nguyên hay không
            if (!int.TryParse(txtN.Text, out int n))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Nếu lỡ nhập số âm, tự động lấy trị tuyệt đối để chuyển thành số dương
            if (n < 0)
            {
                n = Math.Abs(n);
                txtN.Text = n.ToString(); // Cập nhật lại số dương lên ô TextBox để người dùng nhìn thấy
            }

            // 3. Gọi hàm tĩnh tính giai thừa từ lớp TienIch
            long ketQua = NoiChuoi_GiaiThua.GiaiThua(n);

            // 4. Hiển thị kết quả lên giao diện
            txtKetQuaGiaiThua.Text = $"{n}! = {ketQua}";
        }
    }
}
