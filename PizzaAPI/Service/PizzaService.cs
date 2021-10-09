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

        public static IEnumerable<Pizza> GetOnePizza(int? _id)
        {
            IEnumerable<Pizza> query = getAll()
                .Where(n => n.v1.Equals(_id))
                .Select(n => n);
            return query;
        }

        public static IEnumerable<Pizza> GetOnePizzaOrAll(int? _id)
        {
            if (String.IsNullOrEmpty(_id.ToString()))
            {
                try
                {
                    return getAll();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                if (_id < 0)
                {
                    throw new ArgumentException("Negative ID !");
                }
                try
                {
                    return GetOnePizza(_id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }

    }
}
