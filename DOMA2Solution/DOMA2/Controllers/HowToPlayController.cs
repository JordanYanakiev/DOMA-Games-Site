using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DOMA2.Controllers
{
    public class HowToPlayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        
        
        public IActionResult LandOnGreenHowToPlay()
        {
            return View();
        }
        
        public IActionResult MemoryInventoryHowToPlay()
        {
            return View();
        }





    }
}