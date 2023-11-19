using System.Threading.Tasks;

namespace McApp.Data;

public interface IMcAppDbSchemaMigrator
{
    Task MigrateAsync();
}
