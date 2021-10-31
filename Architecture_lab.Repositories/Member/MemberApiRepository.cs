using System;
using System.Threading.Tasks;
using Architecture_lab.Common.Model;
using Architecture_lab.Repositories.Infra.Helper;
using Architecture_lab.Repositories.Member.Entity;

namespace Architecture_lab.Repositories.Member
{
    public class MemberApiRepository : IMemberRepository
    {
        private IApiHelper<MemberDataModel> _apiHelper;

        public MemberApiRepository(IApiHelper<MemberDataModel> apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public Task<IResult> CreateAsync(MemberDataModel memberDataModel)
        {
            var url = "https://localhost:8080/api/test";
            _apiHelper.PostAsync(url, memberDataModel);
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