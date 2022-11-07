using Abp.AutoMapper;
using AbpGleapTest.Sessions.Dto;

namespace AbpGleapTest.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}