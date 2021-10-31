using System;
using System.Collections;
using System.Threading.Tasks;
using Architecture_lab.Repositories.Base.EFCore;
using Microsoft.EntityFrameworkCore;

namespace Architecture_lab.Repositories.Infra
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// The disposed value
        /// </summary>
        private bool disposedValue = false;

        /// <summary>
        /// Context
        /// </summary>
        private DbContext _context;

        /// <summary>
        /// The repositories
        /// </summary>
        private Hashtable _repositories;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// 取得泛型 Repository
        /// </summary>
        /// <typeparam name="TEntity">實體</typeparam>
        /// <returns></returns>
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (this._repositories == null)
            {
                this._repositories = new Hashtable();
            }

            var type = typeof(TEntity);
            if (!this._repositories.ContainsKey(type))
            {
                this._repositories[type] = new Repository<TEntity>(this._context);
            }
            return (IRepository<TEntity>)this._repositories[type];
        }

        /// <summary>
        /// 儲存資料變更
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangesAsync()
        {
            return await this._context.SaveChangesAsync();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}