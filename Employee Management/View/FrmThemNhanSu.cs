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
using MetroFramework.Forms;

namespace Employee_Management
{
    public partial class FrmThemNhanSu : MetroForm
    {
        public FrmThemNhanSu()
        {
            InitializeComponent();
        }

        private void FrmThemNhanSu_Load(object sender, EventArgs e)
        {
            cbxGioiTinh.DataSource = new List<String> { "Nam", "Nữ" };

            cbxChucVu.DataSource = ChucVuBo.Instance.GetChucVus();
            cbxChucVu.DisplayMember = "TenChucVu";
            cbxChucVu.ValueMember = "MaChucVu";

            cbxDanToc.DataSource = DanTocBo.Instance.GetDanTocs();
            cbxDanToc.DisplayMember = "TenDanToc";
            cbxDanToc.ValueMember = "MaDanToc";

            cbxTonGiao.DataSource = TonGiaoBo.Instance.GetTonGiaos();
            cbxTonGiao.DisplayMember = "TenTonGiao";
            cbxTonGiao.ValueMember = "MaTonGiao";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoSung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxHoTen.Text))
            {
                MessageBox.Show("Họ tên không được trống!");
                tbxHoTen.Focus();
            }
            else if (string.IsNullOrEmpty(tbxSoCMND.Text))
            {
                MessageBox.Show("Số chứng minh nhân dân không được trống!");
                tbxSoCMND.Focus();
            }
            else if (tbxSoCMND.Text.Length >= 12)
            {
                MessageBox.Show("Số chứng minh nhân dân quá dài!");
                tbxSoCMND.Focus();
            }
            else if (string.IsNullOrEmpty(tbxSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được trống!");
                tbxSoDienThoai.Focus();
            }
            else if (tbxSoDienThoai.Text.Length >= 11)
            {
                MessageBox.Show("Số điện thoại quá dài!");
                tbxSoDienThoai.Focus();
            }
            else
            {
                Dictionary<string, object> info = new Dictionary<string, object>();
                info.Add("hoTen", tbxHoTen.Text);
                info.Add("gioiTinh", cbxGioiTinh.Text);
                info.Add("soCMND", tbxSoCMND.Text);
                info.Add("noiSinh", tbxNoiSinh.Text);
                info.Add("queQuan", tbxQueQuan.Text);
                info.Add("tonGiao", cbxTonGiao.SelectedValue);
                info.Add("danToc", cbxDanToc.SelectedValue);
                info.Add("namSinh", nudNamSinh.Value);
                info.Add("diaChi", tbxDiaChi.Text);
                info.Add("soDienThoai", tbxSoDienThoai.Text);
                info.Add("email", tbxEmail.Text);
                info.Add("ngayVaoLam", dtNgayVaoLam.Value);
                info.Add("chucVu", cbxChucVu.SelectedValue);
                info.Add("luongCoBan", nudLuongCoBan.Value);
                info.Add("heSoLuong", nudHeSoLuong.Value);
                NhanVienBo.Instance.AddNhanVien(info);

                MessageBox.Show("Bổ sung nhân sự thành công!");

                tbxHoTen.Clear();
                tbxDiaChi.Clear();
                tbxEmail.Clear();
                tbxNoiSinh.Clear();
                tbxQueQuan.Clear();
                tbxSoCMND.Clear();
                tbxSoDienThoai.Clear();
            }
        }
    }
}
