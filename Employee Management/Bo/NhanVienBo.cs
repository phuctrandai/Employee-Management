using Employee_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Bo
{
    class NhanVienBo
    {
        private QLNhanSuDataContext dataContext;

        private NhanVienBo() { dataContext = new QLNhanSuDataContext(DungChung.Instance.ConnectionString); }

        private static NhanVienBo instance;

        public static NhanVienBo Instance
        {
            get { if (instance == null) instance = new NhanVienBo(); return instance; }
        }

        public List<View_NhanVienTheoChucVu> GetNhanViensTheoChucVu(int maChucVu, int trangHienTai, int soDong)
        {
            List<View_NhanVienTheoChucVu> nhanViens = null;
            int totalRow = trangHienTai * soDong,
                skipRow = (trangHienTai - 1) * soDong;
            nhanViens = dataContext.View_NhanVienTheoChucVus.Where(nv => nv.MaChucVu.Equals(maChucVu)).Take(totalRow).Skip(skipRow).ToList();
            return nhanViens;
        }

        public void AddNhanVien(Dictionary<string, object> info)
        {
            string  hoTen = info["hoTen"].ToString(),
                    diaChi = info["diaChi"].ToString(),
                    queQuan = info["queQuan"].ToString(),
                    noiSinh = info["noiSinh"].ToString(),
                    soDienThoai = info["soDienThoai"].ToString(),
                    email = info["email"].ToString(),
                    soCMND = info["soCMND"].ToString();
            bool    gioiTinh = info["gioiTinh"].ToString().Equals("Nam") ? true : false;
            int     namSinh = Convert.ToInt32(info["namSinh"].ToString());
            long    luongCoBan = Convert.ToInt64(info["luongCoBan"].ToString());
            float   heSoLuong = float.Parse(info["heSoLuong"].ToString());
            DateTime ngayVaoLam = DateTime.Parse(info["ngayVaoLam"].ToString());
            int maDanToc = Convert.ToInt32(info["danToc"].ToString()),
                maTonGiao = Convert.ToInt32(info["tonGiao"].ToString()),
                maChucVu = Convert.ToInt32(info["chucVu"].ToString());

            var n = dataContext.NhanViens.Select(nv => nv).OrderByDescending(nv => nv.MaNhanVien);
            string maNhanVien = "NV00" + 1;
            if (n.Count() > 0) maNhanVien = "NV00" + n.First().IdNhanVien + 1;

            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNhanVien = maNhanVien;
            nhanVien.HoTen = hoTen;
            nhanVien.GioiTinh = gioiTinh;
            nhanVien.SoCMND = soCMND;
            nhanVien.NamSinh = namSinh;
            nhanVien.NoiSinh = noiSinh;
            nhanVien.QueQuan = queQuan;
            nhanVien.MaTonGiao = maTonGiao;
            nhanVien.MaDanToc = maDanToc;
            nhanVien.DiaChi = diaChi;
            nhanVien.SoDienThoai = soDienThoai;
            nhanVien.Email = email;
            nhanVien.NgayVaoLam = ngayVaoLam;
            nhanVien.MaChucVu = maChucVu;

            var l = dataContext.Luongs.Select(lu => lu).OrderByDescending(lu => lu.MaSoLuong);
            int maSoLuong = 1;
            if (l.Count() > 0) maSoLuong = l.First().MaSoLuong + 1;

            Luong luong = new Luong();
            luong.MaSoLuong = maSoLuong;
            luong.LuongCoBan = luongCoBan;
            luong.HeSoLuong = heSoLuong;
            nhanVien.Luong = luong;

            dataContext.Luongs.InsertOnSubmit(luong);
            dataContext.NhanViens.InsertOnSubmit(nhanVien);
            dataContext.SubmitChanges();
        }
        
        public int TongNhanVienTheoChucVu(int maChucVu)
        {
            return dataContext.NhanViens.Where(nv => nv.MaChucVu.Equals(maChucVu)).Count();
        }
    }
}
