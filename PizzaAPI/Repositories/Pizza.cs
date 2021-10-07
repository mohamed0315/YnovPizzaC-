using System;
namespace PizzaAPI.Properties
{
    public class Pizza
    {

        public int v1 { get; set; }

        public string v2 { get; set; }
        public string v3 { get; set; }
        public int v4 { get; set; }

        public Pizza()
        {
        }

        public Pizza(int v1, string v2, string v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
