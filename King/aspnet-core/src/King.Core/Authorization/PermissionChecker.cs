using Abp.Authorization;
using King.Authorization.Roles;
using King.Authorization.Users;
using King.MultiTenancy;

namespace King.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
