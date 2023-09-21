using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_Restaurant.FactoryMethod
{
    public interface IAppetizer : IDish
    {
    }

    public class ChickenStrips : Dish, IAppetizer
    {
        public ChickenStrips(string name,decimal price, string description) : base(name,price,description)
        {
        }
        public void Serve()
        {
            Console.WriteLine($"Chicken Strips {ShowDetails()}");
        }
    }
    public class OnionRinges : Dish, IAppetizer
    {
        public OnionRinges(string name, decimal price, string description) : base(name, price, description) 
        {
                
        }
        public void Serve()
        {
            Console.WriteLine($"Onion Ringes {ShowDetails()}");
        }
    }
    public class Mombar : Dish, IAppetizer
    {
        public Mombar(string name, decimal price, string description) : base(name, price, description)
        {

        }
        public void Serve()
        {
            Console.WriteLine($"Mombar {ShowDetails()}");
        }
    }
}
