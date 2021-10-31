using System.Threading.Tasks;
using Architecture_lab.Repositories.Base.EFCore;

namespace Architecture_lab.Repositories.Infra
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// 取得泛型 Repository
        /// </summary>
        /// <typeparam name="TEntity">實體</typeparam>
        /// <returns></returns>
        IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class;

        /// <summary>
        /// 儲存資料變更
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();
    }
}