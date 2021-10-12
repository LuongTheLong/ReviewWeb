using ReviewWeb.Localization;
using Volo.Abp.Application.Services;

namespace ReviewWeb
{
    /* Inherit your application services from this class.
     */
    public abstract class ReviewWebAppService : ApplicationService
    {
        protected ReviewWebAppService()
        {
            LocalizationResource = typeof(ReviewWebResource);
        }
    }
}
