using System.Collections.Generic;
using System.Linq;

namespace Architecture_lab.Repositories.Base.EFCore
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        void Create(T data);

        /// <summary>
        /// 新增多筆資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        void CreateMany(IEnumerable<T> data);

        /// <summary>
        /// 取得內容
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Get();

        /// <summary>
        /// 更新內容
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        void Update(T data);

        /// <summary>
        /// 更新多筆內容
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        void UpdateMany(IEnumerable<T> data);

        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        void Delete(T data);

        /// <summary>
        /// 刪除多筆資料
        /// </summary>
        /// <param name="data">資料</param>
        /// <returns></returns>
        void DeleteMany(IEnumerable<T> data);
    }
}