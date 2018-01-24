using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("About/index");
        }
        public IActionResult history()
        {
            return Content("About/history");
        }
        public IActionResult location()
        {
            return Content("About/location");
        }
    }
}