using AnnouncementAPI.Samples;
using Xunit;

namespace AnnouncementAPI.EntityFrameworkCore.Domains;

[Collection(AnnouncementAPITestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AnnouncementAPIEntityFrameworkCoreTestModule>
{

}
