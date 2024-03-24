using Xunit;

namespace AnnouncementAPI.EntityFrameworkCore;

[CollectionDefinition(AnnouncementAPITestConsts.CollectionDefinitionName)]
public class AnnouncementAPIEntityFrameworkCoreCollection : ICollectionFixture<AnnouncementAPIEntityFrameworkCoreFixture>
{

}
