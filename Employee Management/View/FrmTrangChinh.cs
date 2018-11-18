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
using MetroFramework.Animation;

namespace Employee_Management.View
{
    public partial class FrmTrangChinh : MetroForm
    {
        public FrmTrangChinh()
        {
            InitializeComponent();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTrangChinh_Load(object sender, EventArgs e)
        {
            List<ChucVu> chucVus = ChucVuBo.Instance.GetChucVus();
            lbxChucVu.DataSource = chucVus;
            lbxChucVu.DisplayMember = "TenChucVu";
            lbxChucVu.ValueMember = "MaChucVu";
        }

        private void btnThemNhanSu_Click(object sender, EventArgs e)
        {
            FrmThemNhanSu frmThemNhanSu = new FrmThemNhanSu();
            frmThemNhanSu.Show();
        }

    }
}
