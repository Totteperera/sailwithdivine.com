﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sailwithdivine.com.Controllers
{
    public class BoatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
