using Employee_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Bo
{
    class TonGiaoBo
    {
        private QLNhanSuDataContext dataContext;

        private TonGiaoBo() { dataContext = new QLNhanSuDataContext(DungChung.Instance.ConnectionString); }

        private static TonGiaoBo instance;

        public static TonGiaoBo Instance
        {
            get { if (instance == null) instance = new TonGiaoBo(); return instance; }
        }

        public List<TonGiao> GetTonGiaos() => dataContext.TonGiaos.Select(cv => cv).ToList();
    }
}
