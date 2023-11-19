using McApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace McApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(McAppEntityFrameworkCoreModule),
    typeof(McAppApplicationContractsModule)
    )]
public class McAppDbMigratorModule : AbpModule
{
}
