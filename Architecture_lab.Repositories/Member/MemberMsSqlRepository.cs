using System;
using System.Threading.Tasks;
using Architecture_lab.Common.Enum;
using Architecture_lab.Common.Model;
using Architecture_lab.Repositories.Infra;
using Architecture_lab.Repositories.Member.Entity;

namespace Architecture_lab.Repositories.Member
{
    public class MemberMsSqlRepository : IMemberRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberMsSqlRepository(Func<DbContextEnum, IUnitOfWork> resolver)
        {
            _unitOfWork = resolver(DbContextEnum.SampleMsSql);
        }

        public Task<IResult> CreateAsync(MemberDataModel memberDataModel)
        {
            _unitOfWork.GetRepository<MemberDataModel>().Create(memberDataModel);
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