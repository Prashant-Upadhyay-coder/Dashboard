using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VAPT.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login_page()
        {
            return View();
        }
        public IActionResult login_MasterPage()
        {
            return View();
        }
    }
}