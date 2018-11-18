using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Bo
{
    public class DungChung
    {
        private string tenServer;
        private string tenDatabase;
        private string tenDangNhap;
        private string matKhau;
        private string connectionString;
        private static DungChung instance;
        
        public DungChung() { }

        public string TenServer { get => tenServer; set => tenServer = value; }
        public string TenDatabase { get => tenDatabase; set => tenDatabase = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public static DungChung Instance
        {
            get { if (instance == null) instance = new DungChung(); return instance; }
        }

        public void updateConnectionString()
        {
            this.connectionString = @"Data Source=.\" + TenServer + ";Initial Catalog="+ TenDatabase +";Integrated Security=True";
        }

        public List<String> GetAllDatabaseName()
        {
            List<String> list = null;

            string conectionString = @"Data Source=.\"+ tenServer + ";Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conectionString);
            connection.Open();

            if (connection.State == System.Data.ConnectionState.Open)
            {
                list = new List<string>();
                SqlCommand command = new SqlCommand("select * from sys.databases", connection);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    list.Add(reader["name"].ToString());
                }
                reader.Close();
            }
            connection.Close();
            return list;
        }
    }
}
