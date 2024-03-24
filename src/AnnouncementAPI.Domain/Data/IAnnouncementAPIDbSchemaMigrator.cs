using System.Threading.Tasks;

namespace AnnouncementAPI.Data;

public interface IAnnouncementAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
