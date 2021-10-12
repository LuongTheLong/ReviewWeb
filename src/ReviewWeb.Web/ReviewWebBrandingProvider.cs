using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ReviewWeb.Web
{
    [Dependency(ReplaceServices = true)]
    public class ReviewWebBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ReviewWeb";
    }
}
