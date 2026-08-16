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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmBai1_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            frmBai1 f1 = new frmBai1();

            // Hiển thị form dưới dạng cửa sổ độc lập
            f1.Show();
        }

        private void tsmBai2_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            frmBai2 f2 = new frmBai2();

            // Hiển thị form dưới dạng cửa sổ độc lập
            f2.Show();

        }

        private void tsmBai3_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            frmBai3 f3 = new frmBai3();

            // Hiển thị form dưới dạng cửa sổ độc lập
            f3.Show();
        }
    }
}
