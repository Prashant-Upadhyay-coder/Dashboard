using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VAPT.Controllers
{
    public class OperatorController : Controller
    {
        public IActionResult Target()
        {
            return View();
        }
        public IActionResult Scan()
        {
            return View();
        }
        public IActionResult TargetMasterpage()
        {
            return View();
        }
        public IActionResult SideMenu()
        {
            return View();
        }
    }
}