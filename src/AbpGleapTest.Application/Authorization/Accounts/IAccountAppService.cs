using System.Threading.Tasks;
using Abp.Application.Services;
using AbpGleapTest.Authorization.Accounts.Dto;

namespace AbpGleapTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
