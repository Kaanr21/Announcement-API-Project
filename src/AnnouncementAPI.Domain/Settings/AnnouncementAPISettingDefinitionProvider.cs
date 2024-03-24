using Volo.Abp.Settings;

namespace AnnouncementAPI.Settings;

public class AnnouncementAPISettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AnnouncementAPISettings.MySetting1));
    }
}
