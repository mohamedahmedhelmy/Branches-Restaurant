using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_Restaurant.FactoryMethod
{
    public interface IDessert : IDish
    {
    }

    public class FruitSalad : Dish, IDessert
    {
        public FruitSalad(string name, decimal price, string description) : base(name, price, description)
        {

        }
        public void Serve()
        {
            Console.WriteLine($"Fruit Salad {ShowDetails()}");
        }
    }
    public class Browny : Dish, IDessert
    {
        public Browny(string name, decimal price, string description) : base(name, price, description)
        {

        }
        public void Serve()
        {
            Console.WriteLine($"Browny {ShowDetails()}");
        }
    }
    public class IceCream : Dish, IDessert
    {
        public IceCream(string name, decimal price, string description) : base(name, price, description)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Ice Cream {ShowDetails()}");
        }
    }
}
