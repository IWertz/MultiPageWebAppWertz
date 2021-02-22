using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiPageWebAppWertz.Models;

namespace MultiPageWebAppWertz.Controllers
{
    public class HomeController : Controller
    {
        private PhoneContext context { get; set; }

        public HomeController(PhoneContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var phones = context.Phones.OrderBy(m => m.Name).ToList();
            return View(phones);
        }
    }
}
