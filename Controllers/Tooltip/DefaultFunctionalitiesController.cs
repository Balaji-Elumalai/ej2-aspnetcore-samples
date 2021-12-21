﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class TooltipController : Controller
    {
        public IActionResult DefaultFunctionalities()
        {
            ViewBag.content = "Let's go green to save the planet!!";
            return View();
        }
    }
}
