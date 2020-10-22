using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.SailWithUs;

namespace sailwithdivine.com.Controllers
{
    public class SailWithUsController : Controller
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public SailWithUsController(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            var model = new SailWithUsViewModel
            {
                HeroTitle = _localizer["SailWithUs.Hero.Title"],
                Section1Title = _localizer["SailWithUs.Section1.Title"],
                Section1Text = _localizer["SailWithUs.Section1.Text"],
                Section2Title = _localizer["SailWithUs.Section2.Title"],
                Section2Text = _localizer["SailWithUs.Section2.Text"],
                Section3Title = _localizer["SailWithUs.Section3.Title"],
                Section3Text = _localizer["SailWithUs.Section3.Text"],
                Section4Title = _localizer["SailWithUs.Section4.Title"],
                Section4Text = _localizer["SailWithUs.Section4.Text"]
            };

            return View(model);
        }
    }
}
