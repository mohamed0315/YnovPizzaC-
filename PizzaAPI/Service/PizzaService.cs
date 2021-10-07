using System;
using System.Collections.Generic;
using System.Linq;
using PizzaAPI.Properties;
using PizzaAPI.Repositories;

namespace PizzaAPI.Service
{
    public static class PizzaService
    {

        public static IEnumerable<Properties.Pizza> getAll()
        {
            IEnumerable<Pizza> pizzas = from
                pizza in PizzaRepository.GetPizzas()
                                        select pizza;

            return pizzas;


        }

    }
}
