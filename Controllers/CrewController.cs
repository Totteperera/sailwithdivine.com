using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.Crew;

namespace sailwithdivine.com.Controllers
{
    public class CrewController : Controller
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public CrewController(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var model = new CrewViewModel
            {
                Title = _localizer["Crew.Title"]
            };

            return View(model);
        }
    }
}
