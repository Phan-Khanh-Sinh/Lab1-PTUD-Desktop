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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            var form = new frmBai1();

            // Hiển thị form dưới dạng cửa sổ độc lập
            form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            var form = new frmBai2();

            // Hiển thị form dưới dạng cửa sổ độc lập
            form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            var form = new frmBai3();

            // Hiển thị form dưới dạng cửa sổ độc lập
            form.ShowDialog();
        }

        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Bài 1
            var form = new frmBai4();

            // Hiển thị form dưới dạng cửa sổ độc lập
            form.ShowDialog();
        }
    }
}
