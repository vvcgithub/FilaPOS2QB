using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace POS2QB_WebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Branches()
        {
            return View();
        }

        public IActionResult BranchesUserAccess()
        {
            return View();
        }
    }
}
