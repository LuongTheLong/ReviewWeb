using ReviewWeb.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ReviewWeb.Web.Pages
{
    public abstract class ReviewWebPageModel : AbpPageModel
    {
        protected ReviewWebPageModel()
        {
            LocalizationResourceType = typeof(ReviewWebResource);
        }
    }
}