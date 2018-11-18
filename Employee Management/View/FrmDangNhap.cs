using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management.Bo;
using Employee_Management.Model;
using MetroFramework.Forms;

namespace Employee_Management.View
{
    public partial class FrmDangNhap : MetroForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = tbxTenTaiKhoan.Text;
            string matKhau = tbxMatKhau.Text;

            TaiKhoan taiKhoan = TaiKhoanBo.Instance.GetTaiKhoan(tenTaiKhoan, matKhau);
            if(taiKhoan == null)
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmTrangChinh frmTrangChinh = new FrmTrangChinh();
                this.Hide();
                DialogResult dialogResult = frmTrangChinh.ShowDialog();
                
                if(dialogResult == DialogResult.Abort)
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}
