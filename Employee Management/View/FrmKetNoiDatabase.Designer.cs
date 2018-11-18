namespace Employee_Management
{
    partial class FrmKetNoiDatabase
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
            this.lbTenServer = new MetroFramework.Controls.MetroLabel();
            this.cbxTenServer = new MetroFramework.Controls.MetroComboBox();
            this.tbxTenDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.lbTenDangNhap = new MetroFramework.Controls.MetroLabel();
            this.lbMatKhau = new MetroFramework.Controls.MetroLabel();
            this.tbxMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.lbTenDatabase = new MetroFramework.Controls.MetroLabel();
            this.cbxTenDatabase = new MetroFramework.Controls.MetroComboBox();
            this.btnKetNoi = new MetroFramework.Controls.MetroButton();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbTenServer
            // 
            this.lbTenServer.AutoSize = true;
            this.lbTenServer.Location = new System.Drawing.Point(86, 96);
            this.lbTenServer.Name = "lbTenServer";
            this.lbTenServer.Size = new System.Drawing.Size(72, 19);
            this.lbTenServer.TabIndex = 0;
            this.lbTenServer.Text = "Tên server:";
            // 
            // cbxTenServer
            // 
            this.cbxTenServer.FormattingEnabled = true;
            this.cbxTenServer.ItemHeight = 23;
            this.cbxTenServer.Items.AddRange(new object[] {
            ".\\SQLEXPRESS"});
            this.cbxTenServer.Location = new System.Drawing.Point(205, 86);
            this.cbxTenServer.Name = "cbxTenServer";
            this.cbxTenServer.Size = new System.Drawing.Size(211, 29);
            this.cbxTenServer.TabIndex = 0;
            this.cbxTenServer.UseSelectable = true;
            // 
            // tbxTenDangNhap
            // 
            // 
            // 
            // 
            this.tbxTenDangNhap.CustomButton.Image = null;
            this.tbxTenDangNhap.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.tbxTenDangNhap.CustomButton.Name = "";
            this.tbxTenDangNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxTenDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxTenDangNhap.CustomButton.TabIndex = 1;
            this.tbxTenDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxTenDangNhap.CustomButton.UseSelectable = true;
            this.tbxTenDangNhap.CustomButton.Visible = false;
            this.tbxTenDangNhap.Lines = new string[] {
        "sa"};
            this.tbxTenDangNhap.Location = new System.Drawing.Point(205, 121);
            this.tbxTenDangNhap.MaxLength = 32767;
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.PasswordChar = '\0';
            this.tbxTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxTenDangNhap.SelectedText = "";
            this.tbxTenDangNhap.SelectionLength = 0;
            this.tbxTenDangNhap.SelectionStart = 0;
            this.tbxTenDangNhap.ShortcutsEnabled = true;
            this.tbxTenDangNhap.Size = new System.Drawing.Size(211, 23);
            this.tbxTenDangNhap.TabIndex = 1;
            this.tbxTenDangNhap.Text = "sa";
            this.tbxTenDangNhap.UseSelectable = true;
            this.tbxTenDangNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxTenDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(86, 125);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(98, 19);
            this.lbTenDangNhap.TabIndex = 0;
            this.lbTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(86, 154);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(66, 19);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // tbxMatKhau
            // 
            // 
            // 
            // 
            this.tbxMatKhau.CustomButton.Image = null;
            this.tbxMatKhau.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.tbxMatKhau.CustomButton.Name = "";
            this.tbxMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxMatKhau.CustomButton.TabIndex = 1;
            this.tbxMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxMatKhau.CustomButton.UseSelectable = true;
            this.tbxMatKhau.CustomButton.Visible = false;
            this.tbxMatKhau.Lines = new string[] {
        "0946901161"};
            this.tbxMatKhau.Location = new System.Drawing.Point(205, 150);
            this.tbxMatKhau.MaxLength = 32767;
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.PasswordChar = '●';
            this.tbxMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxMatKhau.SelectedText = "";
            this.tbxMatKhau.SelectionLength = 0;
            this.tbxMatKhau.SelectionStart = 0;
            this.tbxMatKhau.ShortcutsEnabled = true;
            this.tbxMatKhau.Size = new System.Drawing.Size(211, 23);
            this.tbxMatKhau.TabIndex = 2;
            this.tbxMatKhau.Text = "0946901161";
            this.tbxMatKhau.UseSelectable = true;
            this.tbxMatKhau.UseSystemPasswordChar = true;
            this.tbxMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbTenDatabase
            // 
            this.lbTenDatabase.AutoSize = true;
            this.lbTenDatabase.Location = new System.Drawing.Point(86, 189);
            this.lbTenDatabase.Name = "lbTenDatabase";
            this.lbTenDatabase.Size = new System.Drawing.Size(110, 19);
            this.lbTenDatabase.TabIndex = 0;
            this.lbTenDatabase.Text = "Tên cơ sở dữ liệu:";
            // 
            // cbxTenDatabase
            // 
            this.cbxTenDatabase.FormattingEnabled = true;
            this.cbxTenDatabase.ItemHeight = 23;
            this.cbxTenDatabase.Location = new System.Drawing.Point(205, 179);
            this.cbxTenDatabase.Name = "cbxTenDatabase";
            this.cbxTenDatabase.Size = new System.Drawing.Size(211, 29);
            this.cbxTenDatabase.TabIndex = 3;
            this.cbxTenDatabase.UseSelectable = true;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(282, 227);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(134, 31);
            this.btnKetNoi.TabIndex = 4;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseSelectable = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(205, 227);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(71, 31);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseSelectable = true;
            // 
            // FrmKetNoiDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.tbxMatKhau);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.cbxTenDatabase);
            this.Controls.Add(this.cbxTenServer);
            this.Controls.Add(this.lbTenDatabase);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.lbTenServer);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FrmKetNoiDatabase";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbTenServer;
        private MetroFramework.Controls.MetroComboBox cbxTenServer;
        private MetroFramework.Controls.MetroTextBox tbxTenDangNhap;
        private MetroFramework.Controls.MetroLabel lbTenDangNhap;
        private MetroFramework.Controls.MetroLabel lbMatKhau;
        private MetroFramework.Controls.MetroTextBox tbxMatKhau;
        private MetroFramework.Controls.MetroLabel lbTenDatabase;
        private MetroFramework.Controls.MetroComboBox cbxTenDatabase;
        private MetroFramework.Controls.MetroButton btnKetNoi;
        private MetroFramework.Controls.MetroButton btnThoat;
    }
}

