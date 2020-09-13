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
                .Select(x => $"Content/Boat/Interior/{x.Name}").ToList(),
                Title = _localizer["Boat.Title"],
                Subtitle = _localizer["Boat.Subtitle"],
                InteriorTitle = _localizer["Boat.Interior.Title"],
                InteriorText = _localizer["Boat.Interior.Text"]
            };

            return View(model);
        }
    }
}
