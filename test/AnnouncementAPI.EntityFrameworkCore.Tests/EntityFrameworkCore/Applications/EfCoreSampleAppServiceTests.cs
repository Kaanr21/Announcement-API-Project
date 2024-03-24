using AnnouncementAPI.Samples;
using Xunit;

namespace AnnouncementAPI.EntityFrameworkCore.Applications;

[Collection(AnnouncementAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AnnouncementAPIEntityFrameworkCoreTestModule>
{

}
