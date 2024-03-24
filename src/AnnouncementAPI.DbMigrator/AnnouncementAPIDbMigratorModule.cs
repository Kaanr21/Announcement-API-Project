using AnnouncementAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AnnouncementAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AnnouncementAPIEntityFrameworkCoreModule),
    typeof(AnnouncementAPIApplicationContractsModule)
    )]
public class AnnouncementAPIDbMigratorModule : AbpModule
{
}
