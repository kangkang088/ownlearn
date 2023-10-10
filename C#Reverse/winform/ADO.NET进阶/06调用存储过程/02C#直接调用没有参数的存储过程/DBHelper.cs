using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _02C_直接调用没有参数的存储过程
{
    internal class DBHelper
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["SQLCONNECTION"].ConnectionString;//连接字符串
        public static SqlConnection sqlConnection = null;//连接对象
        public static SqlDataAdapter sqlDataAdapter = null;//数据适配器
        #region 连接数据库
        public static void OpenConn()
        {
            if (sqlConnection == null)
            { 
                sqlConnection = new SqlConnection(connStr);
                sqlConnection.Open();
            }
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            if (sqlConnection.State == System.Data.ConnectionState.Broken)
            { 
                sqlConnection.Close();
                sqlConnection.Open();
            }
        }
        #endregion
        #region 执行sql语句前的准备 将sql语句，传入SqlDataAdapter对象
        public static void PrepareSql(string sql)
        {
            OpenConn();
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);//执行sql语句
        }
        public static void PrepareProc(string sql)
        {
            OpenConn();
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;//执行存储过程
        }
        #endregion
        #region 设置sql语句的参数
        public static void SetParameter(string parameterName,Object parameterValue)
        {
            parameterName = "@" + parameterName.Trim();
            if (parameterValue == null)
                parameterValue = DBNull.Value;
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter(parameterName,parameterValue));
        }
        #endregion
        #region 执行sql语句
        public static int ExecNonQuery()
        { 
            int count = sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }
        public static DataTable ExecQuery()
        { 
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            sqlConnection.Close();
            return dt;
        }
        public static SqlDataReader ExecDataReader()
        { 
            return sqlDataAdapter.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static object ExecScalar()
        { 
            object obj = sqlDataAdapter.SelectCommand.ExecuteScalar();
            sqlConnection.Close();
            return obj;
        }
        #endregion
        public DBHelper() { }
    }
}
