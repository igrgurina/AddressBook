using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AddressBook.Configuration.Dto;

namespace AddressBook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AddressBookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
