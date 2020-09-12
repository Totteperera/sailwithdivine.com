using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using sailwithdivine.com.Models.Boat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sailwithdivine.com.Controllers
{
    public class BoatController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BoatController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var model = new BoatViewModel
            {
                ImageUrls = _webHostEnvironment.WebRootFileProvider.GetDirectoryContents("Content/Boat/Interior/")
                .Select(x => $"Content/Boat/Interior/{x.Name}").ToList()
            };

            
            return View(model);
        }
    }
}
