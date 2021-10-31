using System;
using System.Threading.Tasks;
using Architecture_lab.Common.Model;
using Architecture_lab.Repositories.Member.Entity;

namespace Architecture_lab.Repositories.Member
{
    public class MemberKitRepository : IMemberRepository
    {
        private readonly IMemberKit _memberKit;

        public MemberKitRepository(IMemberKit memberKit)
        {
            _memberKit = memberKit;
        }

        public Task<IResult> CreateAsync(MemberDataModel memberDataModel)
        {
            _memberKit.CreateAsync(memberDataModel);
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

    //模擬套件
    public class MemberKit : IMemberKit
    {
        public bool CreateAsync(MemberDataModel memberDataModel)
        {
            return true;
        }
    }

    public interface IMemberKit
    {
        bool CreateAsync(MemberDataModel memberDataModel);
    }
}