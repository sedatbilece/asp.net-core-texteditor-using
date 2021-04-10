using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using text_editor_kullanımı.Models;

namespace text_editor_kullanımı.Controllers
{
    public class HomeController : Controller



    {
        Context c = new Context();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(Makale mkl)
        {

            var zaman = DateTime.Now.ToLongDateString();
            mkl.Tarih = zaman;
            c.makale.Add(mkl);
            c.SaveChanges();



            return RedirectToAction("Index");
        }


        public IActionResult Makaleler()
        {

            var makaleler = c.makale.ToList();
            return View(makaleler);
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
