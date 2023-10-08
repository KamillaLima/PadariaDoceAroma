using Microsoft.AspNetCore.Mvc;
using PadariaDoceAroma.Models;
using System.Diagnostics;

namespace PadariaDoceAroma.Controllers
{
    public class HomeController : Controller
    {
        //classe que herda de Controller,tudo que precisamos esta dentro dessa classe Controller

        public IActionResult Index()
        {   
            Item padaria = new Item();
            return View(padaria);
        }
        //Index é a nossa página principal

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