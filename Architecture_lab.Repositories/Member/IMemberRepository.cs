using System.Threading.Tasks;
using Architecture_lab.Common.Model;
using Architecture_lab.Repositories.Member.Entity;

namespace Architecture_lab.Repositories.Member
{
    public interface IMemberRepository
    {
        Task<MemberDataModel> GetAsync(int id);

        Task<IResult> CreateAsync(MemberDataModel memberDataModel);

        Task<IResult> UpdateAsync(MemberDataModel memberDataModel);

        Task<IResult> DeleteAsync(int id);
    }
}