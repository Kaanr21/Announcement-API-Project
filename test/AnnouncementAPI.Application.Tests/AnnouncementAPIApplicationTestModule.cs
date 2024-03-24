using Volo.Abp.Modularity;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIApplicationModule),
    typeof(AnnouncementAPIDomainTestModule)
)]
public class AnnouncementAPIApplicationTestModule : AbpModule
{

}
