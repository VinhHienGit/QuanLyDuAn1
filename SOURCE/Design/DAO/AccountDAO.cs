using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool login(String taiKhoan, String matKhau)
        {
            String qr = "select * from TaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(qr);
            foreach (DataRow row in data.Rows)
            {
                if (taiKhoan == row["taiKhoan"].ToString() && matKhau == row["matKhau"].ToString())
                    return true;
            }
            return false;
        }
    }
}
