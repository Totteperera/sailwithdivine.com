using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using sailwithdivine.com.Models.ContactUs;

namespace sailwithdivine.com.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public ContactUsController(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            var model = new ContactUsViewModel
            {
                Title = _localizer["ContactUs.Title"],
                Text = _localizer["ContactUs.Text"]
            };

            return View(model);
        }
    }
}
