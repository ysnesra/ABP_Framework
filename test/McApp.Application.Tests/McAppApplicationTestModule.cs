using Volo.Abp.Modularity;

namespace McApp;

[DependsOn(
    typeof(McAppApplicationModule),
    typeof(McAppDomainTestModule)
    )]
public class McAppApplicationTestModule : AbpModule
{

}
