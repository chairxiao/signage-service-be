using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Signage.Service.Configuration.Dto;

namespace Signage.Service.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ServiceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
