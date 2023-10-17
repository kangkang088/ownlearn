using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07手写DBHelper类 {
    internal class DBHelper {
        private string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        private static SqlConnection SqlConnection = null;
        private static SqlDataAdapter SqlDataAdapter = null;

        public static void OpenConn() {
            if (SqlConnection == null) {
                SqlConnection = new SqlConnection();
                SqlConnection.Open();
            }
            if (SqlConnection.State == System.Data.ConnectionState.Closed) {
                SqlConnection.Open();
            }
            if (SqlConnection.State == System.Data.ConnectionState.Broken) {
                SqlConnection.Close();
                SqlConnection.Open();
            }
        }
        public static void PrepareSql(string sqlConn) {
            OpenConn();
            SqlDataAdapter = new SqlDataAdapter(sqlConn, SqlConnection);
        }
        public static void PrepareProc() { }
        public static void SetParameter(string parameterName, object parameterValue) {
            parameterName = "@" + parameterName.Trim();
            if (parameterName == null) {
                parameterName = DBNull.Value.ToString();
            }
            SqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter(parameterName, parameterValue));
        }
        public static void SetOutParameter(string parameterName, SqlDbType sqlDbType) {
            parameterName = "@" + parameterName.Trim();
            
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType);
            sqlParameter.Direction = ParameterDirection.Output;
            SqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        public static void SetOutParameter(string parameterName, SqlDbType sqlDbType, int size) {
            parameterName = "@" + parameterName.Trim();
          
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType, size);
            sqlParameter.Direction = ParameterDirection.Output;
            SqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        public static void SetInOutParameter(string parameterName, SqlDbType sqlDbType, string parameterValue) {
            parameterName = "@" + parameterName.Trim();
           
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            sqlParameter.Value = parameterValue;
            SqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        public static void SetInOutParameter(string parameterName, SqlDbType sqlDbType, int size, string parameterValue) {
            parameterName = "@" + parameterName.Trim();
            
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType,size);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            sqlParameter.Value = parameterValue;
            SqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        public static void ReturnParameter(string parameterName) {
            parameterName = "@" + parameterName.Trim();
           
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = parameterName;
            sqlParameter.Direction = ParameterDirection.ReturnValue;
            SqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        public static object GetParameter(string parameterName) {
            parameterName = "@" + parameterName.Trim();
            object str = SqlDataAdapter.SelectCommand.Parameters["parameterName"].Value;
            return str; 
        }
        public static int ExecNonQuery() {
            int row = 0;
            row = SqlDataAdapter.SelectCommand.ExecuteNonQuery();
            SqlConnection.Close();
            return row;
        }
        public static DataTable ExecQuery() {
            DataTable dataTable = new DataTable();
            SqlDataAdapter.Fill(dataTable);
            SqlConnection.Close();
            return dataTable;
        }
        public static SqlDataReader ExecQueryDataReader() {
            SqlDataReader dataReader = SqlDataAdapter.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return dataReader;
        }
        public static object ExecScalar() {
            object o = SqlDataAdapter.SelectCommand.ExecuteScalar();
            return o;
        }
    }
}
