namespace BaiTapWindowsForm___Bai_2___Phan_Khanh_Sinh_
{
    partial class frmBai1
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
            this.lblTTTBTitle = new System.Windows.Forms.Label();
            this.lblTTTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTTTBTitle
            // 
            this.lblTTTBTitle.AutoSize = true;
            this.lblTTTBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTTBTitle.Location = new System.Drawing.Point(22, 45);
            this.lblTTTBTitle.Name = "lblTTTBTitle";
            this.lblTTTBTitle.Size = new System.Drawing.Size(138, 20);
            this.lblTTTBTitle.TabIndex = 0;
            this.lblTTTBTitle.Text = "Thông tin thiết bị:";
            // 
            // lblTTTB
            // 
            this.lblTTTB.AutoSize = true;
            this.lblTTTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTTB.Location = new System.Drawing.Point(22, 89);
            this.lblTTTB.Name = "lblTTTB";
            this.lblTTTB.Size = new System.Drawing.Size(13, 20);
            this.lblTTTB.TabIndex = 0;
            this.lblTTTB.Text = ".";
            this.lblTTTB.Click += new System.EventHandler(this.lblTTTB_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 221);
            this.Controls.Add(this.lblTTTB);
            this.Controls.Add(this.lblTTTBTitle);
            this.Name = "frmBai1";
            this.Text = "Thông tin thiết bị (Câu 1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTTTBTitle;
        private System.Windows.Forms.Label lblTTTB;
    }
}