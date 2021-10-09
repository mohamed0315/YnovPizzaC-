using System;
namespace PizzaAPI.Service
{
    public static class PriceService
    {

        public static double ConverToEur(this double usd)
        {
            if (usd >= 100)
            {
                throw new ArgumentException("Mauvais prix: " + usd);
            }
            if (usd < 0)
            {
                throw new ArgumentException("Prix negatif: " + usd);
            }
            if (usd > 0)
            {
                return usd * 0.85;
            }
            return usd;
        }
    }
}
