using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AnnouncementAPI.Web;

[Dependency(ReplaceServices = true)]
public class AnnouncementAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AnnouncementAPI";
}
