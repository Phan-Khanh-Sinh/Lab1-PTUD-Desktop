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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào xem có trống hay không
            if (string.IsNullOrWhiteSpace(txbSo1.Text) || string.IsNullOrWhiteSpace(txbSo2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ hai số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Chuyển đổi dữ liệu từ chuỗi sang số thực double
            if (!double.TryParse(txbSo1.Text, out double so1) || !double.TryParse(txbSo2.Text, out double so2))
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double ketQua = 0;

            // 3. Kiểm tra xem RadioButton nào đang được chọn
            if (rdCong.Checked)
            {
                ketQua = so1 + so2;
            }
            else if (rdTru.Checked)
            {
                ketQua = so1 - so2;
            }
            else if (rdNhan.Checked)
            {
                ketQua = so1 * so2;
            }
            else if (rdChia.Checked)
            {
                // Kiểm tra điều kiện chia cho số 0
                if (so2 == 0)
                {
                    MessageBox.Show("Không thể thực hiện phép chia cho 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ketQua = so1 / so2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phép toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblKetQua.Text = $"{ketQua}";
        }
    }
}
