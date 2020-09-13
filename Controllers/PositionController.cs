using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.Position;

namespace sailwithdivine.com.Controllers
{
    public class PositionController : Controller
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public PositionController(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var model = new PositionViewModel
            {
                Title = _localizer["Position.Title"],
                Subtitle = _localizer["Position.Subtitle"]
            };

            return View(model);
        }
    }
}
