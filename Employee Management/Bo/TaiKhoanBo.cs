using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management.Model;

namespace Employee_Management.Bo
{
    class TaiKhoanBo
    {
        private QLNhanSuDataContext dataContext;

        private TaiKhoanBo() { dataContext = new QLNhanSuDataContext(DungChung.Instance.ConnectionString); }

        private static TaiKhoanBo instance;

        public static TaiKhoanBo Instance
        {
            get { if (instance == null) instance = new TaiKhoanBo(); return instance; }
        }

        public TaiKhoan GetTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            TaiKhoan taiKhoan = dataContext.TaiKhoans.FirstOrDefault(tk => tk.TenTaiKhoan.Equals(tenTaiKhoan) && tk.MatKhau.Equals(matKhau));
            return taiKhoan;
        }
    }
}
