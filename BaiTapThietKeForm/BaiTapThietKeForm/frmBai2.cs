using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;


            // Nếu chưa chọn hàng nào ở listBox1
            if (item == null)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng không chạy code phía dưới
            }
            listBox2.Items.Add(item);
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            // Nếu chưa chọn hàng nào ở listBox2 để xóa
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng trong danh sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng không chạy code phía dưới
            }
            listBox2.Items.Remove(listBox2.SelectedItem);
            // Nếu danh sách đã xóa hết sạch, ép nhãn hiển thị về 0 đồng
            if (listBox2.Items.Count == 0)
            {
                lblSoTien.Text = "0 đồng";
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;

            foreach (string hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = soTien + " đồng";
            }

        }
    }
}
