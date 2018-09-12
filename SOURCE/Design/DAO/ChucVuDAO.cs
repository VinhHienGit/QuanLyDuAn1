using Design.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChucVuDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        

        public ChucVu getChucVuByid(string maCV)
        {
            ChucVu cv = new ChucVu();
            string query = "select * from ChucVu where maCV = '" + maCV + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in table.Rows)
            {
                cv = new ChucVu(item);
            }
            return cv;
        }


        public ChucVu getChucVuByName(string maCV)
        {
            ChucVu cv = new ChucVu();
            if (maCV.Equals("tất cả"))
            {
                cv = new ChucVu("CV000", "tất cả", 0, 0);
            } else
            { 
                string query = "select * from ChucVu where tenCV = N'" + maCV + "'";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in table.Rows)
                {
                    cv = new ChucVu(item);
                }
            }
            return cv;
        }

    }
}
