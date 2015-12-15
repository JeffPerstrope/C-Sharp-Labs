using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string woodType = "";
            int woodPrice = 0;
            Console.Write("Number of drawers in the desk: ");
            string userDrawers = Console.ReadLine();
            int numDrawers = NumberOfDrawers(userDrawers);

            Console.WriteLine("\nIndex \n---------------\n p). Pine: $100 \n o). Oak: $140 \n m). Mahogany: $180");
            Console.Write("\nWhich type of wood would you like your desk to be made out of? ");
            string userWoodChoice = Console.ReadLine();
            if (userWoodChoice == "p" || userWoodChoice == "P")
                woodType = "Pine";
            else if (userWoodChoice == "o" || userWoodChoice == "O")
                woodType = "Oak";
            else
                woodType = "Mahogany";
            int woodCost = TypeOfWood(userWoodChoice, woodPrice);

            string total = TotalCost(numDrawers, woodCost);
            DisplayResult(userDrawers, woodType, total);
        }


        private static int NumberOfDrawers(string userNum)
        {
            int drawers = Convert.ToInt32(userNum);
            return drawers;
        }


        private static int TypeOfWood(string input, int price)
        {
            if (input == "p" || input == "P")
                price = 100;
            else if (input == "o" || input == "O")
                price = 140;
            else
                price = 180;
            return price;
        }


        private static string TotalCost(int drawers, int wood)
        {
            double drawerTotal = drawers * 30;
            double mathTotal = drawerTotal + wood;
            string finalPrice = mathTotal.ToString("C");
            return finalPrice;
        }


        private static void DisplayResult(string drawers, string type, string total)
        {
            Console.WriteLine("\nYou want {0} drawer(s)", drawers);
            Console.WriteLine("You want {0} wood", type);
            Console.WriteLine("\nThe cost for the desk is {0}", total);
        }
    }
}
