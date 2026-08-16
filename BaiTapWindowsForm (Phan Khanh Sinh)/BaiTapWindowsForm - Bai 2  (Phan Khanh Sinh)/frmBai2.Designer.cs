namespace BaiTapWindowsForm___Bai_2___Phan_Khanh_Sinh_
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.txbSo1 = new System.Windows.Forms.TextBox();
            this.txbSo2 = new System.Windows.Forms.TextBox();
            this.grbTitle1 = new System.Windows.Forms.GroupBox();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grbTitle1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(91, 55);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(94, 20);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Số thứ nhất";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(91, 97);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(84, 20);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Số thứ hai";
            // 
            // txbSo1
            // 
            this.txbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSo1.Location = new System.Drawing.Point(192, 55);
            this.txbSo1.Name = "txbSo1";
            this.txbSo1.Size = new System.Drawing.Size(149, 26);
            this.txbSo1.TabIndex = 1;
            // 
            // txbSo2
            // 
            this.txbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSo2.Location = new System.Drawing.Point(192, 94);
            this.txbSo2.Name = "txbSo2";
            this.txbSo2.Size = new System.Drawing.Size(149, 26);
            this.txbSo2.TabIndex = 1;
            // 
            // grbTitle1
            // 
            this.grbTitle1.Controls.Add(this.rdChia);
            this.grbTitle1.Controls.Add(this.rdNhan);
            this.grbTitle1.Controls.Add(this.rdTru);
            this.grbTitle1.Controls.Add(this.rdCong);
            this.grbTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTitle1.Location = new System.Drawing.Point(192, 146);
            this.grbTitle1.Name = "grbTitle1";
            this.grbTitle1.Size = new System.Drawing.Size(202, 170);
            this.grbTitle1.TabIndex = 2;
            this.grbTitle1.TabStop = false;
            this.grbTitle1.Text = "Chọn phép toán";
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(24, 34);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(69, 24);
            this.rdCong.TabIndex = 0;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Checked = true;
            this.rdTru.Location = new System.Drawing.Point(24, 64);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(55, 24);
            this.rdTru.TabIndex = 0;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(24, 94);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(69, 24);
            this.rdNhan.TabIndex = 0;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(24, 124);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(64, 24);
            this.rdChia.TabIndex = 0;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.Location = new System.Drawing.Point(136, 322);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(149, 32);
            this.btnXemKetQua.TabIndex = 3;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(91, 379);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(94, 20);
            this.lblTitle3.TabIndex = 0;
            this.lblTitle3.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(191, 379);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(13, 20);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 439);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.grbTitle1);
            this.Controls.Add(this.txbSo2);
            this.Controls.Add(this.txbSo1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Name = "frmBai2";
            this.Text = "Tính toán (Câu 2)";
            this.grbTitle1.ResumeLayout(false);
            this.grbTitle1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txbSo1;
        private System.Windows.Forms.TextBox txbSo2;
        private System.Windows.Forms.GroupBox grbTitle1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblKetQua;
    }
}