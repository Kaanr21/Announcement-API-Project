using System;
using System.Collections.Generic;
using System.Text;
using AnnouncementAPI.Localization;
using Volo.Abp.Application.Services;

namespace AnnouncementAPI;

/* Inherit your application services from this class.
 */
public abstract class AnnouncementAPIAppService : ApplicationService
{
    protected AnnouncementAPIAppService()
    {
        LocalizationResource = typeof(AnnouncementAPIResource);
    }
}
