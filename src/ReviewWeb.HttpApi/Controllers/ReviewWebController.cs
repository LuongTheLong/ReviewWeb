using ReviewWeb.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ReviewWeb.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ReviewWebController : AbpController
    {
        protected ReviewWebController()
        {
            LocalizationResource = typeof(ReviewWebResource);
        }
    }
}