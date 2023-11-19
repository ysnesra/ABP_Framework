using McApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace McApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class McAppController : AbpControllerBase
{
    protected McAppController()
    {
        LocalizationResource = typeof(McAppResource);
    }
}
