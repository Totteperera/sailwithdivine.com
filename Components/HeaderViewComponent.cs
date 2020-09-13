using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.Header;
using System;
using System.Linq;

namespace sailwithdivine.com.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public HeaderViewComponent(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }
        public IViewComponentResult Invoke()
        {
            var currentCultureName = Request.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.UICulture.Name;

            var otherCultureName = currentCultureName.Equals("sv-SE") ? "en-US" : "sv-SE";

            var model = new HeaderViewModel
            {
                Current = new CountryModel
                {
                    CountryName = _localizer[$"Header.Country.{currentCultureName}"],
                    CountryFlag = $"icon-{currentCultureName}",
                    Culture = currentCultureName

                },
                AvailableCountry = new CountryModel
                {
                    CountryName = _localizer[$"Header.Country.{otherCultureName}"],
                    CountryFlag = $"icon-{otherCultureName}",
                    Culture = otherCultureName
                }
            };

            return View(model);
        }


    }
}
