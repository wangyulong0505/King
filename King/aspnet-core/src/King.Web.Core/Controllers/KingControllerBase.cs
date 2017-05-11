using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace King.Controllers
{
    public abstract class KingControllerBase: AbpController
    {
        protected KingControllerBase()
        {
            LocalizationSourceName = KingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}