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
            return View();
        }


        [HttpPost]
        public IActionResult ResultSet(string Cedula, string Nombre, string Apellido, int Edad, 
            string Telefono, string Email, string EstadoCivil, string genero, bool WatchSeries, 
            bool ListenMusic, bool ToDance, bool PlayVideos)
        {
            int n;
            int.TryParse(Edad.ToString(), out n);

            var data = new FormularioModel();


            data.Cedula = Cedula;
            data.Nombre = Nombre;
            data.Apellido = Apellido;

            data.Edad = n;
            data.Telefono = Telefono ?? "Ninguno";
            data.Email = Email ?? "Ninguno";
            data.Genero = genero;
            data.EstadoCivil = EstadoCivil;

            if (WatchSeries)
            {
                string a = "Ver series";
                data.Hobbys.Add(a);
            }
            if (ToDance)
            {
                string x = "Bailar";
                data.Hobbys.Add(x);
            }
            if (PlayVideos)
            {
                string y = "Video Juegos";
                data.Hobbys.Add(y);
            }
            if (ListenMusic)
            {
                string z = "Escuchar musica";
                data.Hobbys.Add(z);
            }

            return View(data);
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
