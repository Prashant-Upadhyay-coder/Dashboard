using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VAPT.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult masterpage()
        {
            return View();
        }
        public IActionResult VAPT_Manager()
        {
            return View();
        }
        public IActionResult Tool_Master()
        {
            return View();
        }
        public IActionResult CWE_Master()
        {
            return View();
        }
        public IActionResult VAPT_Master()
        {
            return View();
        }
        public IActionResult sidemenu()
        {
            return View();
        }
        public IActionResult Tool_Linkage()
        {
            return View();
        }
    }
}