using System.Threading.Tasks;
using Abp.Application.Services;
using AbpGleapTest.Configuration.Dto;

namespace AbpGleapTest.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}