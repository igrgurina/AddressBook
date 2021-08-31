using Abp.Authorization;
using AddressBook.Authorization.Roles;
using AddressBook.Authorization.Users;

namespace AddressBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
