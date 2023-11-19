using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace McApp.Data;

/* This is used if database provider does't define
 * IMcAppDbSchemaMigrator implementation.
 */
public class NullMcAppDbSchemaMigrator : IMcAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
