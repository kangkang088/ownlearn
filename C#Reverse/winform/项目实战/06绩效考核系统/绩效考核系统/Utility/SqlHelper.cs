using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 绩效考核系统.Utility {
    internal class SqlHelper {
        public static string ConnStr { get; set; }
        public static DataTable ExcuteTable(string cmdText) {
            using (SqlConnection sqlConnection = new SqlConnection(ConnStr)) {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static int ExcuteNonQuery(string cmdText) {
            using (SqlConnection sqlConnection = new SqlConnection(ConnStr)) {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(cmdText, sqlConnection);
                int rows = cmd.ExecuteNonQuery();
                if (rows <= 0) {
                    throw new Exception("数据库操作失败");
                }
                return rows;
            }
        }
    }
}
