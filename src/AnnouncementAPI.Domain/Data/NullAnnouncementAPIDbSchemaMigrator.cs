using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AnnouncementAPI.Data;

/* This is used if database provider does't define
 * IAnnouncementAPIDbSchemaMigrator implementation.
 */
public class NullAnnouncementAPIDbSchemaMigrator : IAnnouncementAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
