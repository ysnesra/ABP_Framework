using Volo.Abp.Settings;

namespace McApp.Settings;

public class McAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(McAppSettings.MySetting1));
    }
}
