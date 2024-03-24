using AnnouncementAPI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AnnouncementAPI.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AnnouncementAPIPageModel : AbpPageModel
{
    protected AnnouncementAPIPageModel()
    {
        LocalizationResourceType = typeof(AnnouncementAPIResource);
    }
}
