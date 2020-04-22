using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace CSharp
{
    public class DBHelper
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
        private SqlConnection _sqlConnection;
        public SqlConnection HelperConnection
        {
            get
            {
                _sqlConnection = _sqlConnection ?? new SqlConnection(connectionString);
                return _sqlConnection;
            }
        }

        /// <summary>
        /// 非查询行为,需要在外部打开关闭数据库连接
        /// </summary>
        /// <param name="cmdText">SQL代码</param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteNonQuery(string cmdText)
        {
            SqlCommand command = GetCommand(HelperConnection, cmdText);
            int rowNumberAffected = command.ExecuteNonQuery();
            return rowNumberAffected;
        }

        /// <summary>
        /// 查询标量，返回第一行第一列的数据
        /// </summary>
        /// <param name="cmdText">SQL代码</param>
        /// <returns>返回第一行第一列的数据</returns>
        public object ExecuteScalar(string cmdText)
        {
            using (HelperConnection)
            {
                SqlCommand command = GetCommand(HelperConnection, cmdText);
                return command.ExecuteScalar();
            }
        }

        public SqlDataReader ExecuteReader(string cmdText)
        {
            if (HelperConnection.State == System.Data.ConnectionState.Closed)
            {
                HelperConnection.Open();
            }
            SqlCommand command = GetCommand(HelperConnection, cmdText);
            return command.ExecuteReader();

        }

        private SqlCommand GetCommand(SqlConnection connection, string cmdText)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = cmdText;
            return command;
        }
        private SqlCommand GetCommand(string cmdText)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = new SqlConnection(connectionString);
            command.CommandText = cmdText;
            return command;
        }


    }


}
