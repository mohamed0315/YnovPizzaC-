using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Properties;
using PizzaAPI.Repositories;
using PizzaAPI.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : Controller
    {

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            return PizzaService.getAll();
        }
    }
}
