using McApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace McApp;

[DependsOn(
    typeof(McAppEntityFrameworkCoreTestModule)
    )]
public class McAppDomainTestModule : AbpModule
{

}
