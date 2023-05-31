using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pojeto_c_.Controllers
{
    
    public class LoginController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        
    }
}