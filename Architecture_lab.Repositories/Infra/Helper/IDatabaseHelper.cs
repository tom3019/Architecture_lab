using System.Data;

namespace Architecture_lab.Repositories.Infra.Helper
{
    public interface IDatabaseHelper
    {
        /// <summary>
        /// 取得資料庫連線字串
        /// </summary>
        /// <returns> </returns>
        IDbConnection GetConnection();
    }
}