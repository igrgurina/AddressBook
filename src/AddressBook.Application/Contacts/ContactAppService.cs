using Abp.Application.Services;
using Abp.Domain.Repositories;
using AddressBook.Contacts.Dto;

namespace AddressBook.Contacts
{
    public interface IContactAppService : IAsyncCrudAppService<ContactDto>
    {

    }

    public class ContactAppService : AsyncCrudAppService<Contact, ContactDto>, IContactAppService
    {
        public ContactAppService(IRepository<Contact, int> repository)
            : base(repository)
        {
        }
    }
}
