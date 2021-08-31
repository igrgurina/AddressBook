using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.Dependency;
using AddressBook.Contacts.Dto;
using JetBrains.Annotations;
using Microsoft.AspNetCore.SignalR;
using Volo.Abp.EventBus.Distributed;

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
