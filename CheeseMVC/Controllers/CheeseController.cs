using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();


        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        // Use [Route("/Cheese/Add")] to direct the form data
        // submition to this method. Or in the form, use 
        // action="NewCheese" to direct the form submition like what I am doing now
        public IActionResult NewCheese(string name, string description)
        {
            Cheeses.Add(name, description);
            return Redirect("/Cheese");
        }


        public IActionResult Remove()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        public IActionResult Delete(string name)
        {
            Cheeses.Remove(name);
            return Redirect("/Cheese");
        }
        public IActionResult Index2()
        {
            // Could return a page in a different controller folder like Home (Yi)
            return View("/Views/Home/Index.cshtml");
        }
    }
}
