using Abp.Application.Services;
using AddressBook.MultiTenancy.Dto;

namespace AddressBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

