using AnnouncementAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AnnouncementAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AnnouncementAPIController : AbpControllerBase
{
    protected AnnouncementAPIController()
    {
        LocalizationResource = typeof(AnnouncementAPIResource);
    }
}
