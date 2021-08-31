using System.Threading.Tasks;
using Abp.Application.Services;
using AddressBook.Sessions.Dto;

namespace AddressBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
