using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_Restaurant.FactoryMethod
{
    public abstract class DishFactory
    {
        public abstract IDish CreateDish();
    }

    public class ChickenStripsFactory : DishFactory
    {
        public override IAppetizer CreateDish()
        {
            return new ChickenStrips("Small Chicken Strips Box", 47m, "Strips With Tomato Sauce");
        }
    }
    public class OnionRingesFactory : DishFactory
    {
        public override IAppetizer CreateDish()
        {
            return new OnionRinges("5 Small Onion Ringes", 30m, "Onion Ringes With Tomato Sauce ");
        }
    }
    public class MombarFactory : DishFactory
    {
        public override IAppetizer CreateDish()
        {
            return new Mombar("1/4 Mombar", 50m, "Mombar With Soup ");
        }
    }


    public class FataMozaDanyFactory : DishFactory
    {
        public override IMainCourse CreateDish()
        {
            return new FataMozaDany("Fata", 200m, "1/2 FataMozaDany with soup and rice");
        }
    }

    public class BurgarBranchesFactory : DishFactory
    {
        public override IMainCourse CreateDish()
        {
            return new BurgarBranches("Burgar", 100m, "Burger stuffed with cheese, cucumber, tomato and lettuce");
        }
    }

    public class PastaSheeshTurkyFactory : DishFactory
    {
        public override IMainCourse CreateDish()
        {
            return new PastaSheeshTurky("Pasta", 90m, "Pasta With Tomato sauce and chicken");
        }


        public class FruitSaladFactory : DishFactory
        {
            public override IDessert CreateDish()
            {
                return new FruitSalad("BranchesFruitSalad", 62m, "Mango,Apple,Banana,Berries");
            }
        }
        public class BrownyFactory : DishFactory
        {
            public override IDessert CreateDish()
            {
                return new Browny("BrownyCup", 60m, "Browny WIth Chocolate Sauce");
            }
        }

        public class IceCreamFactory : DishFactory
        {
            public override IDessert CreateDish()
            {
                return new IceCream("Ice Cream", 63m, "Ice Cream Chocolate And Vanilla with Nuts");
            }
        }
    }
}
