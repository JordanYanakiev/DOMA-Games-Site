using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DOMA2.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LandOnGreen()
        {
            return View();
        }

        public IActionResult MemoryInventory()
        {
            return View();
        }
        
        public IActionResult HowToPlay()
        {
            return View();
        }



    }
}