using System.Threading.Tasks;
using Abp.Application.Services;
using AddressBook.Authorization.Accounts.Dto;

namespace AddressBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
