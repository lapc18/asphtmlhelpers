using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HTMLHelpers.Models;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {   
        
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Formulario()
        {
            var Hobbys = new List<HobbysModel>{
            new HobbysModel{ ID = 1, Hobby = "Leer", IsChecked = false},
            new HobbysModel{ ID = 2, Hobby = "Ver series", IsChecked = false},
            new HobbysModel{ ID = 3, Hobby = "Escuchar musica", IsChecked = false},
            new HobbysModel{ ID = 4, Hobby = "Desarrollar software", IsChecked = false},
            };
            ViewData["list"] = Hobbys;
            return View();
        }


        [HttpPost]
        public IActionResult Formulario(FormularioModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
