using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.Cookiebanner;

namespace sailwithdivine.com.Components
{
    public class CookiebannerViewComponent : ViewComponent
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public CookiebannerViewComponent(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }
        public IViewComponentResult Invoke()
        {

            var model = new CookiebannerViewModel
            {
                Text = _localizer["Cookiebanner.Text"]
            };

            return View(model);
        }


    }
}
