using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lesson2AspNetCoreMVC.Models;

namespace lesson2AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        //[ActionName("hello")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
