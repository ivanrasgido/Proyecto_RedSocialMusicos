using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using red_social_musicos.Models;
using System.Web;


namespace red_social_musicos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //getSubirArchivo

        public IActionResult SubirArchivo()
        {
            return View();
        }

        //postSubirArchivo
        
        [HttpPost]
        public ActionResult SubirArchivo( IFormFile archivo)
        {
            SubirArchivosModelo modelo = new SubirArchivosModelo();

            if(archivo != null)
            {
                string ruta= PathString.FromUriComponent("~/Temp/");
                ruta = archivo.FileName;
                modelo.SubirArchivo(ruta,archivo);
                ViewBag.Error = modelo.error;
                ViewBag.Correcto = modelo.confimacion;
            }
           
            return View();
        }

       
                    
        public IActionResult Index()
        {
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
