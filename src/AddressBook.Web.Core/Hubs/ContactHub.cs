using System.Threading.Tasks;
using Abp.AspNetCore.SignalR.Hubs;
using AddressBook.Contacts.Dto;
using Microsoft.AspNetCore.SignalR;

namespace AddressBook.Hubs
{
    public class ContactHub : AbpHubBase
    {
        public async Task NotifyOthers(ContactDto contact)
        {
            await Clients.Others.SendAsync("getLiveUpdate", contact);
        }
    }
}
