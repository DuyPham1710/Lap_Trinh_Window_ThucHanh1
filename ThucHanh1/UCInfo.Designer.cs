namespace ThucHanh1
{
    partial class UCInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gvHsinh = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvHsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(226, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(214, 26);
            this.txtID.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblID.Location = new System.Drawing.Point(24, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "ID";
            // 
            // gvHsinh
            // 
            this.gvHsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHsinh.Location = new System.Drawing.Point(479, 41);
            this.gvHsinh.Name = "gvHsinh";
            this.gvHsinh.RowHeadersWidth = 62;
            this.gvHsinh.RowTemplate.Height = 28;
            this.gvHsinh.Size = new System.Drawing.Size(441, 317);
            this.gvHsinh.TabIndex = 23;
            this.gvHsinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHsinh_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(226, 198);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(214, 26);
            this.txtCMND.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(226, 127);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 26);
            this.txtAddress.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 26);
            this.txtName.TabIndex = 19;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(22, 269);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(196, 25);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Ngay thang nam sinh";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCMND.Location = new System.Drawing.Point(24, 204);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(72, 25);
            this.lblCMND.TabIndex = 17;
            this.lblCMND.Text = "CMND";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAddress.Location = new System.Drawing.Point(22, 133);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 25);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Dia chi";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 25);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Ho va Ten";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEdit.Location = new System.Drawing.Point(399, 512);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 37);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Sua";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemove.Location = new System.Drawing.Point(226, 512);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 37);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Xoa";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.Location = new System.Drawing.Point(54, 512);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 37);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(226, 327);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(214, 26);
            this.txtGioiTinh.TabIndex = 37;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGioiTinh.Location = new System.Drawing.Point(24, 333);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(82, 25);
            this.lblGioiTinh.TabIndex = 36;
            this.lblGioiTinh.Text = "Gioi tinh";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 385);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 26);
            this.txtEmail.TabIndex = 39;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(24, 391);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(226, 443);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 26);
            this.txtPhone.TabIndex = 41;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone.Location = new System.Drawing.Point(24, 449);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 25);
            this.lblPhone.TabIndex = 40;
            this.lblPhone.Text = "Phone Number";
            // 
            // UCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gvHsinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "UCInfo";
            this.Size = new System.Drawing.Size(946, 622);
            ((System.ComponentModel.ISupportInitialize)(this.gvHsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.DataGridView gvHsinh;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtCMND;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnAdd;
    }
}
