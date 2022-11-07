using Abp.Authorization;
using AbpGleapTest.Authorization.Roles;
using AbpGleapTest.Authorization.Users;

namespace AbpGleapTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
