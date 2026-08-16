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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        // Click đôi vào nút Bài 1

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Mở form Bài 1 khi nhấn vào nút Bài 1 trên form chính
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            // Mở form Bài 2 khi nhấn vào nút Bài 2 trên form chính
            var form = new frmBai2();
            form.ShowDialog();
        }
        private void tsbBai3_Click(object sender, EventArgs e)
        {
            // Mở form Bài 2 khi nhấn vào nút Bài 2 trên form chính
            var form = new frmBai3();
            form.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }
        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_3(object sender, EventArgs e)
        {

        }


    }
}
