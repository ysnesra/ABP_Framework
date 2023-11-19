using McApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace McApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class McAppPageModel : AbpPageModel
{
    protected McAppPageModel()
    {
        LocalizationResourceType = typeof(McAppResource);
    }
}
