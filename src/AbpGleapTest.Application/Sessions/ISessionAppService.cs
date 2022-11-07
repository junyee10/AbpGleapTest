using System.Threading.Tasks;
using Abp.Application.Services;
using AbpGleapTest.Sessions.Dto;

namespace AbpGleapTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
