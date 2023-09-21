using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_Restaurant.FactoryMethod
{
    public interface IMainCourse : IDish
    {
    }
    public class FataMozaDany : Dish, IMainCourse
    {
        public FataMozaDany(string name, decimal price, string description) : base(name, price, description)
        {

        }
        public void Serve()
        {
            Console.WriteLine($"Fata Moza Dany {ShowDetails()}");
        }
    }

    public class BurgarBranches : Dish, IMainCourse
    {
        public BurgarBranches(string name, decimal price, string description) : base(name, price, description)
        {

        }
        public void Serve()
        {
            Console.WriteLine($"BurgarBranches {ShowDetails()}");
        }
    }
    public class PastaSheeshTurky : Dish, IMainCourse
    {
        public PastaSheeshTurky(string name, decimal price, string description) : base(name, price, description)
        {

        }
        public void Serve()
        {
            Console.WriteLine($"PastaSheeshTurky {ShowDetails()}");
        }
    }
}
