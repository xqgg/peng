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
        /// 非查询行为
        /// </summary>
        /// <param name="cmdText">SQL代码</param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteNonQuery(string cmdText)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = HelperConnection;
            command.CommandText = cmdText;
            int rowNumberAffected = command.ExecuteNonQuery();
            return rowNumberAffected;
        }



    }


}
