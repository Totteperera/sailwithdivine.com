using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using sailwithdivine.com.Models;
using sailwithdivine.com.Models.Home;

namespace sailwithdivine.com.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<Resource> _localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<Resource> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var atlanticDate = DateTime.Parse("2020-11-22");
            var daysLeft = (atlanticDate.Date - DateTime.UtcNow.Date).TotalDays;

            var result = "";

            if(DateTime.UtcNow.Date.CompareTo(atlanticDate) > 0 || DateTime.UtcNow.Date.CompareTo(atlanticDate) == 0)
            {
                result = _localizer["Home.Countdown.Crossing"];
            }
            else
            {
                result = $"{daysLeft} {_localizer["Home.Countdown.Days"]}";
            }


            var model = new HomeViewModel
            {
                IconContactUsText = _localizer["Home.Icon.ContactUs"],
                IconCrewText = _localizer["Home.Icon.Crew"],
                IconInstagramText = _localizer["Home.Icon.Instagram"],
                IconShipText = _localizer["Home.Icon.Ship"],
                PositionButtonText = _localizer["Home.Position.Button"],
                PositionText = _localizer["Home.Position.Text"],
                CountdownTitle = _localizer["Home.Countdown.Title"],
                CountdownDays = result
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
