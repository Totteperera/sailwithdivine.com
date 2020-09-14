using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.Boat;
using System.Linq;

namespace sailwithdivine.com.Controllers
{
    public class BoatController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IStringLocalizer<Resource> _localizer;

        public BoatController(IWebHostEnvironment webHostEnvironment, IStringLocalizer<Resource> localizer)
        {
            _webHostEnvironment = webHostEnvironment;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            var model = new BoatViewModel
            {
                ImageUrls = _webHostEnvironment.WebRootFileProvider.GetDirectoryContents("Content/Boat/Interior/")
                .Select(x => $"../Content/Boat/Interior/{x.Name}").ToList(),
                Title = _localizer["Boat.Title"],
                Subtitle = _localizer["Boat.Subtitle"],
                InteriorTitle = _localizer["Boat.Interior.Title"],
                InteriorText = _localizer["Boat.Interior.Text"],
                LayoutTitle = _localizer["Boat.Layout.Title"],
                LayoutText = _localizer["Boat.Layout.Text"],
                EquipmentTitle = _localizer["Boat.Equipment.Title"],
                IconAutopilot = _localizer["Boat.Icon.Autopilot"],
                IconEngine = _localizer["Boat.Icon.Engine"],
                IconFire = _localizer["Boat.Icon.Fire"],
                IconFishing = _localizer["Boat.Icon.Fishing"],
                IconInflatable = _localizer["Boat.Icon.Inflatable"],
                IconLifeRaft = _localizer["Boat.Icon.LifeRaft"],
                IconMap = _localizer["Boat.Icon.Map"],
                IconRadar = _localizer["Boat.Icon.Radar"],
                IconSignal = _localizer["Boat.Icon.Signal"],
                IconSolar = _localizer["Boat.Icon.Solar"]
            };

            return View(model);
        }
    }
}
