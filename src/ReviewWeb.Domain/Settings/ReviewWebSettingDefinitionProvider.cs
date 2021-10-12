using Volo.Abp.Settings;

namespace ReviewWeb.Settings
{
    public class ReviewWebSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ReviewWebSettings.MySetting1));
        }
    }
}
