namespace ThucHanh1
{
    partial class FHocSinh
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
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.ucInfo = new ThucHanh1.UCInfo();
            this.SuspendLayout();
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(845, 579);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(99, 47);
            this.btnGiaoVien.TabIndex = 33;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // ucInfo
            // 
            this.ucInfo.Location = new System.Drawing.Point(12, 13);
            this.ucInfo.Name = "ucInfo";
            this.ucInfo.Size = new System.Drawing.Size(946, 560);
            this.ucInfo.TabIndex = 34;
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 638);
            this.Controls.Add(this.ucInfo);
            this.Controls.Add(this.btnGiaoVien);
            this.Name = "FHocSinh";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGiaoVien;
        private UCInfo ucInfo;
    }
}

