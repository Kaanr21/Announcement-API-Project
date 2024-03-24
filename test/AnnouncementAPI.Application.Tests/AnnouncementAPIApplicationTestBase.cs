using Volo.Abp.Modularity;

namespace AnnouncementAPI;

public abstract class AnnouncementAPIApplicationTestBase<TStartupModule> : AnnouncementAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
