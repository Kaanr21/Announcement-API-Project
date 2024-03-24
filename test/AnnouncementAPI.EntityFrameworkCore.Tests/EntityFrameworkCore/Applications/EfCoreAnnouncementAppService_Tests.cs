using AnnouncementAPI.Announcements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AnnouncementAPI.EntityFrameworkCore.Applications
{
    [Collection(AnnouncementAPITestConsts.CollectionDefinitionName)]
    public class EfCoreAnnouncementAppService_Tests : AnnouncementsService_Tests<AnnouncementAPIEntityFrameworkCoreTestModule>
    {

    }


}
