using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyNike
{
    public class DBHelper
    {
        public static string connStr = "server =.;database = DBWORK1;uid = sa;pwd = 08875799wei";//连接字符串
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

        #region 设置和获取sql语句的参数
        public static void SetParameter(string parameterName, Object parameterValue)
        {
            parameterName = "@" + parameterName.Trim();
            if (parameterValue == null)
                parameterValue = DBNull.Value;
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter(parameterName, parameterValue));
        }
        /// <summary>
        /// 设置输出参数，非字符串类型
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="sqlDbType"></param>
        public static void SetOutParameter(string parameterName, SqlDbType sqlDbType)
        {
            parameterName = "@" + parameterName.Trim();
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType);
            sqlParameter.Direction = ParameterDirection.Output;
            sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        /// <summary>
        /// 设置输出参数，字符串类型，必须要设置size
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="sqlDbType"></param>
        /// <param name="size"></param>
        public static void SetOutParameter(string parameterName, SqlDbType sqlDbType, int size)
        {
            parameterName = "@" + parameterName.Trim();
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType, size);
            sqlParameter.Direction = ParameterDirection.Output;
            sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        /// <summary>
        /// 输入输出参数，非字符串类型
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="sqlDbType"></param>
        /// <param name="paparameterValue"></param>
        public static void SetOutAndInParameter(string parameterName, SqlDbType sqlDbType, Object paparameterValue)
        {
            parameterName = "@" + parameterName.Trim();
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            sqlParameter.Value = paparameterValue;
            sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        /// <summary>
        /// 输入输出参数，字符串类型
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="sqlDbType"></param>
        /// <param name="size"></param>
        /// <param name="paparameterValue"></param>
        public static void SetOutAndInParameter(string parameterName, SqlDbType sqlDbType, int size, Object paparameterValue)
        {
            parameterName = "@" + parameterName.Trim();
            SqlParameter sqlParameter = new SqlParameter(parameterName, sqlDbType,size);
            sqlParameter.Direction = ParameterDirection.InputOutput;
            sqlParameter.Value = paparameterValue;
            sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        /// <summary>
        /// 返回值参数
        /// </summary>
        /// <param name="parameterName"></param>
        public static void SetReturnParameter(string parameterName)
        { 
            parameterName = "@" + parameterName.Trim();
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = parameterName;
            sqlParameter.Direction = ParameterDirection.ReturnValue;
            sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
        }
        /// <summary>
        /// 获取参数的值
        /// </summary>
        public static object GetParameter(string parameterName)
        {
            parameterName = "@" + parameterName.Trim();
            return sqlDataAdapter.SelectCommand.Parameters[parameterName].Value;
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
