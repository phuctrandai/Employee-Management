using Employee_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Bo
{
    class DanTocBo
    {
        private QLNhanSuDataContext dataContext;

        private DanTocBo() { dataContext = new QLNhanSuDataContext(DungChung.Instance.ConnectionString); }

        private static DanTocBo instance;

        public static DanTocBo Instance
        {
            get { if (instance == null) instance = new DanTocBo(); return instance; }
        }

        public List<DanToc> GetDanTocs() => dataContext.DanTocs.Select(cv => cv).ToList();
    }
}
