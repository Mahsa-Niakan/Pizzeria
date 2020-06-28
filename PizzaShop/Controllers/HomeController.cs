using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaShop.Models;
using PizzeriaApp1.Services.Repositories;

namespace PizzaShop.Controllers
{
 
        public class HomeController : Controller
        {
            private IPizzaRepository _pizzaRepository;

            public HomeController(IPizzaRepository pizzaRepository)
            {
                _pizzaRepository = pizzaRepository;
            }

            public IActionResult Index()
            {
                return View();
            }
            public IActionResult Menu()
            {
                List<PizzeriaApp1.DomainClass.Pizza> pizza = _pizzaRepository.GetAllPizzas();
                return View(pizza);
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
