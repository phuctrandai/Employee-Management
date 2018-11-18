using Employee_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Bo
{
    class ChucVuBo
    {
        private QLNhanSuDataContext dataContext;

        private ChucVuBo() { dataContext = new QLNhanSuDataContext(DungChung.Instance.ConnectionString); }

        private static ChucVuBo instance;

        public static ChucVuBo Instance
        {
            get { if (instance == null) instance = new ChucVuBo(); return instance; }
        }

        public List<ChucVu> GetChucVus() => dataContext.ChucVus.Select(cv => cv).ToList();
    }
}
