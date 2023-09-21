using Branches_Restaurant.FactoryMethod;
using System;
using static Branches_Restaurant.FactoryMethod.PastaSheeshTurkyFactory;

namespace Branches_Restaurant
{
    class Program
    {

        public static void Main(string[] args)
        {

            IAppetizer appetizer=null;
            IMainCourse mainCourse = null;
            IDessert dessert = null;

            Console.WriteLine("Appetizers");
            Console.WriteLine("1 Chicken Strips");
            Console.WriteLine("2 Onion Ringes");
            Console.WriteLine("3 Mombar");
            Console.WriteLine($" Any other key to skip");
            int selectedAppetizer = int.Parse(Console.ReadLine());


            if (selectedAppetizer <= 3)
            {

                switch (selectedAppetizer)
                {
                    
                    case 1:
                        appetizer = new ChickenStripsFactory().CreateDish();
                        break;
                    case 2:
                        appetizer = new OnionRingesFactory().CreateDish();
                        break;
                    case 3:
                        appetizer = new MombarFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }

            Console.Clear();

            Console.WriteLine("Main Course");
            Console.WriteLine("5 FataMozaDany");
            Console.WriteLine("6 BurgarBranches");
            Console.WriteLine("7 PastaSheeshTurky");
            Console.WriteLine($" Any other key to skip");
            int selectedMainCourse = int.Parse(Console.ReadLine());
            if (selectedMainCourse >= 4&& selectedMainCourse <= 7)
            {
                switch (selectedMainCourse)
                {
                    case 5:
                        mainCourse = new FataMozaDanyFactory().CreateDish();
                        break;
                    case 6:
                        mainCourse = new BurgarBranchesFactory().CreateDish();
                        break;
                    case 7:
                        mainCourse = new PastaSheeshTurkyFactory().CreateDish();
                        break;
                    default:
                        break;
                }
                
            }
            
            Console.Clear();

            Console.WriteLine("Desserts");
            Console.WriteLine("9 Fruit Salad");
            Console.WriteLine("10 Browny");
            Console.WriteLine("11 IceCream");
            Console.WriteLine("Any other key to skip");
            int selectedDessert = int.Parse(Console.ReadLine());

            if (selectedDessert >= 9 && selectedDessert <= 13)
            {

                switch (selectedDessert)
                {
                    case 9:
                        dessert = new FruitSaladFactory().CreateDish();
                        break;
                    case 10:
                        dessert = new BrownyFactory().CreateDish();
                        break;
                    case 11:
                        dessert = new IceCreamFactory().CreateDish();
                        break;
                    default:
                        break;
                }
            }
            Console.Clear();
            appetizer?.Serve();
            mainCourse?.Serve();
            dessert?.Serve();
            
        }
    }
}
