namespace ThucHanh1
{
    partial class FGiaoVien
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
            this.ucInfo = new ThucHanh1.UCInfo();
            this.SuspendLayout();
            // 
            // ucInfo
            // 
            this.ucInfo.Location = new System.Drawing.Point(12, 12);
            this.ucInfo.Name = "ucInfo";
            this.ucInfo.Size = new System.Drawing.Size(946, 584);
            this.ucInfo.TabIndex = 0;
            // 
            // FGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 623);
            this.Controls.Add(this.ucInfo);
            this.Name = "FGiaoVien";
            this.Text = "FGiaoVien";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCInfo ucInfo;
    }
}