using Abp.Authorization;
using Signage.Service.Authorization.Roles;
using Signage.Service.Authorization.Users;

namespace Signage.Service.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
