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
        public const int ROW_PER_PAGE = 2;

        public FrmTrangChinh()
        {
            InitializeComponent();

            this.trangHienTai = 1;
            tbxTrangHienTai.Text = this.trangHienTai.ToString();
        }

        private int maChucVu;
        private int trangHienTai;
        private int tongSoTrang;

        #region Events
       
        private void FrmTrangChinh_Load(object sender, EventArgs e)
        {
            List<ChucVu> chucVus = ChucVuBo.Instance.GetChucVus();
            lbxChucVu.DataSource = chucVus;
            lbxChucVu.DisplayMember = "TenChucVu";
            lbxChucVu.ValueMember = "MaChucVu";

            this.formLoaded = true;
            this.maChucVu = Convert.ToInt32(lbxChucVu.SelectedValue);
            this.tongSoTrang = NhanVienBo.Instance.TongNhanVienTheoChucVu(maChucVu) / ROW_PER_PAGE + 1;
            HienThiNhanVienTheoChucVu();
        }

        private void lbxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.formLoaded)
            {
                this.maChucVu = Convert.ToInt32(lbxChucVu.SelectedValue);
                this.tongSoTrang = NhanVienBo.Instance.TongNhanVienTheoChucVu(maChucVu) / ROW_PER_PAGE + 1;
                HienThiNhanVienTheoChucVu();
            }
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvNhanVien.CurrentCell = clickedCell;
                    var relativeMousePos = dgvNhanVien.PointToClient(Cursor.Position);
                    ctxmstrpNhanVien.Show(dgvNhanVien, relativeMousePos);
                }
            }
        }

        private void btnTrangTiep_Click(object sender, EventArgs e)
        {
            if (this.trangHienTai < this.tongSoTrang)
            {
                this.trangHienTai += 1;
                tbxTrangHienTai.Text = this.trangHienTai.ToString();
                HienThiNhanVienTheoChucVu();
            }
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (this.trangHienTai > 1)
            {
                this.trangHienTai -= 1;
                tbxTrangHienTai.Text = this.trangHienTai.ToString();
                HienThiNhanVienTheoChucVu();
            }
        }

        private void btnTrangDau_Click(object sender, EventArgs e)
        {
            this.trangHienTai = 1;
            tbxTrangHienTai.Text = this.trangHienTai.ToString();
            HienThiNhanVienTheoChucVu();
        }

        private void btnTrangCuoi_Click(object sender, EventArgs e)
        {
            this.trangHienTai = this.tongSoTrang;
            tbxTrangHienTai.Text = this.trangHienTai.ToString();
            HienThiNhanVienTheoChucVu();
        }

        private void btnThemNhanSu_Click(object sender, EventArgs e)
        {
            FrmThemNhanSu frmThemNhanSu = new FrmThemNhanSu();
            frmThemNhanSu.Show();
        }
        #endregion

        #region Functions

        bool formLoaded = false;
        private void HienThiNhanVienTheoChucVu()
        {
            if (this.formLoaded)
            {
                int maChucVu = Convert.ToInt32(lbxChucVu.SelectedValue);
                List<View_NhanVienTheoChucVu> nhanViens = NhanVienBo.Instance.GetNhanViensTheoChucVu(maChucVu, trangHienTai, ROW_PER_PAGE);
                dgvNhanVien.DataSource = nhanViens;
            }
        }


        #endregion
        
    }
}
