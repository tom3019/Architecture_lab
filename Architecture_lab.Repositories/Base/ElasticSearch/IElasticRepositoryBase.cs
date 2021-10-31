using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nest;

namespace Architecture_lab.Repositories.Base.ElasticSearch
{
    public interface IElasticRepositoryBase<T> where T : class
    {
        Task<bool> BulkAsync(IBulkRequest bulkRequest);

        Task<T> GetAsync(string id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetAsync(IGetRequest request);

        Task<T> FindAsync(string id);

        Task<T> FindAsync(IGetRequest request);

        Task<IEnumerable<T>> GetManyAsync(IEnumerable<string> ids);

        Task<IEnumerable<T>> SearchAsync(ISearchRequest request);

        Task<IEnumerable<T>> SearchAsync(Func<SearchDescriptor<T>, ISearchRequest> selector);

        IEnumerable<IHit<T>> HitsSearch(ISearchRequest request);

        Task<IEnumerable<IHit<T>>> HitsSearchAsync(ISearchRequest request);

        IEnumerable<IHit<T>> HitsSearch(Func<SearchDescriptor<T>, ISearchRequest> selector);

        Task<IEnumerable<IHit<T>>> HitsSearchAsync(Func<SearchDescriptor<T>, ISearchRequest> selector);

        Task<bool> InsertAsync(T t);

        Task<bool> InsertManyAsync(IList<T> tList);

        Task<bool> UpdateAsync(T t);

        Task<bool> UpdatePartAsync(T t, object partialEntity);

        Task<bool> DeleteByIdAsync(string id);

        Task<long> GetTotalCountAsync();

        Task<bool> ExistAsync(string id);
    }
}