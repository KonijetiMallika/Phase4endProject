using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesLibrary
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string Type { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
        static public List<Pizza> pizzadetails = new List<Pizza>()
 {
         new Pizza { PizzaId = 100,Type = "Vigetable Pizza", Price =25},
         new Pizza { PizzaId = 101,Type = "Chicken Pizza",Price=30},
         new Pizza { PizzaId = 102,Type = "Margherita",Price=45},
         new Pizza { PizzaId = 103,Type = "Mushroom ",Price=35},
         new Pizza { PizzaId = 104,Type = "Pepproni ",Price=20},
         new Pizza { PizzaId = 105,Type = "Cheese Pizza ",Price=50},
         new Pizza { PizzaId = 106,Type = "Bianca Pizza ",Price=40}
 };
        public string display(int pid)
        {
            string c = "";
            foreach (var p in pizzadetails)
            {
                if (p.PizzaId == pid)
                {
                    c = p.Type;
                }
            }

            return c;
        }
    }
}
