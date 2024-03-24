using Volo.Abp.Modularity;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIDomainModule),
    typeof(AnnouncementAPITestBaseModule)
)]
public class AnnouncementAPIDomainTestModule : AbpModule
{

}
