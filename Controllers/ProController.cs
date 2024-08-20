using demoday2.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoday2.Controllers
{
    public class ProController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult showall()
        {
            ProductmockData prmock= new ProductmockData();

           var productsn=prmock.GetProducts();

            return View("view1",productsn);
        }

        public IActionResult shows(int id)
        {
            
            ProductmockData prmock= new ProductmockData();
            var productsn=prmock.getprod(id);
            return View("prodsp", productsn);

        }
    }
}
