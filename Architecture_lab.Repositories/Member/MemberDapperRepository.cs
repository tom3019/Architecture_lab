using System;
using System.Threading.Tasks;
using Architecture_lab.Common.Model;
using Architecture_lab.Repositories.Infra.Helper;
using Architecture_lab.Repositories.Member.Entity;
using Dapper;

namespace Architecture_lab.Repositories.Member
{
    public class MemberDapperRepository : IMemberRepository
    {
        private readonly IDatabaseHelper _databaseHelper;

        public MemberDapperRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public Task<IResult> CreateAsync(MemberDataModel memberDataModel)
        {
            using var conn = _databaseHelper.GetConnection();
            var sqlCmd = @"Insert into [dbo].[Members] (Account, Password, CreateTime, UpdateTime)
                                Values (@Account , @Password , @CreateTime , @UpdateTime)";

            var result = conn.Execute(sqlCmd, memberDataModel);
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