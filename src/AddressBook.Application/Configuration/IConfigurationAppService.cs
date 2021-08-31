using System.Threading.Tasks;
using AddressBook.Configuration.Dto;

namespace AddressBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
