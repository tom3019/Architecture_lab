using System.Data;
using Microsoft.Data.SqlClient;

namespace Architecture_lab.Repositories.Infra.Helper
{
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly string _connectionString;

        /// <summary>
        /// 實作DatabaseHelper
        /// </summary>
        /// <param name = "connectionString"> 連線字串 </param>
        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// 取得資料庫連線資訊
        /// </summary>
        /// <returns> </returns>
        public IDbConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }
    }
}