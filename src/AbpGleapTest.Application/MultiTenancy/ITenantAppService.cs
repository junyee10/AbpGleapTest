using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpGleapTest.MultiTenancy.Dto;

namespace AbpGleapTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
