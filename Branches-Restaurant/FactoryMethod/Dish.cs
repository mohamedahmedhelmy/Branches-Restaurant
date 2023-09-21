using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_Restaurant.FactoryMethod
{
    public abstract class Dish
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Dish(string name, decimal price, string description)
        {
            Description = description;
            Name=name;
            Price = price;
        }
        protected string ShowDetails()
        {
            return $" Dish Name : {Name} .Dish Price ({Price.ToString("C")})\n {Description}\n";
        }
    }
}
