using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpGleapTest.Configuration.Dto;

namespace AbpGleapTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpGleapTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
