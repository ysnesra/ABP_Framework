using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace McApp.Web;

[Dependency(ReplaceServices = true)]
public class McAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "McApp";
}
