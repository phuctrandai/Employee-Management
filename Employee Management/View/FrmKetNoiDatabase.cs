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
using Employee_Management.View;
using MetroFramework.Forms;

namespace Employee_Management
{
    public partial class FrmKetNoiDatabase : MetroForm
    {
        public FrmKetNoiDatabase()
        {
            InitializeComponent();
        }

        private void cbxTenDatabase_DropDown(object sender, EventArgs e)
        {
            List<String> list = DungChung.Instance.GetAllDatabaseName();
            if (list != null)
            {
                cbxTenDatabase.DataSource = null;
                cbxTenDatabase.Items.Clear();
                cbxTenDatabase.DataSource = list;
            }
        }

        private void FrmKetNoiDatabase_Load(object sender, EventArgs e)
        {
            cbxTenServer.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxTenDatabase.Text))
            {
                MessageBox.Show("Chưa chọn cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DungChung.Instance.TenDatabase = cbxTenDatabase.Text;
            DungChung.Instance.TenDangNhap = tbxTenDangNhap.Text;
            DungChung.Instance.MatKhau = tbxMatKhau.Text;
            DungChung.Instance.updateConnectionString();

            FrmDangNhap frmDangNhap = new FrmDangNhap();
            this.Hide();
            DialogResult dialogResult = frmDangNhap.ShowDialog();
            if(dialogResult == DialogResult.Abort)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
