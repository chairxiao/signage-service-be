using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Signage.Service.Controllers
{
    public abstract class ServiceControllerBase: AbpController
    {
        protected ServiceControllerBase()
        {
            LocalizationSourceName = ServiceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
