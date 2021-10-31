using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Architecture_lab.Repositories.Base.EFCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The database context
        /// </summary>
        private readonly DbContext _dbContext;

        /// <summary>
        /// 實體集合
        /// </summary>
        public DbSet<T> Entities { get; }

        /// <summary>
        /// 使用資料庫 <see cref="Repository<T>"/> class.
        /// </summary>
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            Entities = _dbContext.Set<T>();
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        public void Create(T data)
        {
            Entities.Add(data);
        }

        /// <summary>
        /// 新增多筆資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        public void CreateMany(IEnumerable<T> data)
        {
            Entities.AddRange(data);
        }

        /// <summary>
        /// 取得內容
        /// </summary>
        /// <param name="id">編號</param>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return Entities;
        }

        /// <summary>
        /// 更新內容
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        public void Update(T data)
        {
            Entities.Update(data);
        }

        /// <summary>
        /// 更新多筆內容
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        public void UpdateMany(IEnumerable<T> data)
        {
            Entities.UpdateRange(data);
        }

        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        public void Delete(T data)
        {
            Entities.Remove(data);
        }

        /// <summary>
        /// 刪除多筆資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        public void DeleteMany(IEnumerable<T> data)
        {
            Entities.RemoveRange(data);
        }
    }
}