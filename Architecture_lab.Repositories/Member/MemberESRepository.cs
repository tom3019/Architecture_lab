using System;
using System.Threading.Tasks;
using Architecture_lab.Common.Model;
using Architecture_lab.Repositories.Base.ElasticSearch;
using Architecture_lab.Repositories.Member.Entity;
using Nest;

namespace Architecture_lab.Repositories.Member
{
    public class MemberESRepository : ElasticRepositoryBase<MemberDataModel>, IMemberRepository
    {
        public MemberESRepository(IElasticClient elasticClient) : base(elasticClient)
        {
        }

        public override string IndexName => "Members";

        public Task<IResult> CreateAsync(MemberDataModel memberDataModel)
        {
            base.InsertAsync(memberDataModel);
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MemberDataModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(MemberDataModel memberDataModel)
        {
            throw new NotImplementedException();
        }
    }
}