using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AddressBook.Controllers
{
    public abstract class AddressBookControllerBase: AbpController
    {
        protected AddressBookControllerBase()
        {
            LocalizationSourceName = AddressBookConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
