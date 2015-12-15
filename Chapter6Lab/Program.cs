using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Danielle", "Edward", "Francis" };
            string[] initials = { "d", "D", "e", "E", "f", "F", "z", "Z" };
            double[] totals = { 0, 0, 0 };
            bool continueLoop = true;
            Console.WriteLine("Index:");
            Console.WriteLine("(D or d) for {0}", names[0]);
            Console.WriteLine("(E or e) for {0}", names[1]);
            Console.WriteLine("(F or f) for {0}", names[2]);
            while (continueLoop == true)
            {
                Console.WriteLine("Enter a lowercase letter enter Z or z to exit");
                string userLetter = Console.ReadLine();
                if (userLetter == initials[0] || userLetter == initials[1])//Danielle
                {
                    Console.WriteLine("Sale: ");
                    string danielle = Console.ReadLine();
                    double danielleSale = Convert.ToDouble(danielle);
                    totals[0] += danielleSale;
                }
                else if (userLetter == initials[2] || userLetter == initials[3])//Edward
                {
                    Console.WriteLine("Sale: ");
                    string edward = Console.ReadLine();
                    double edwardSale = Convert.ToDouble(edward);
                    totals[1] += edwardSale;
                }
                else if (userLetter == initials[4] || userLetter == initials[5])//Francis
                {
                    Console.WriteLine("Sale: ");
                    string francis = Console.ReadLine();
                    double francisSale = Convert.ToDouble(francis);
                    totals[2] += francisSale;
                }
                else if (userLetter != initials[6] || userLetter != initials[7])//equals z or Z
                {
                    continueLoop = false;
                }
            }
            string danielleGrandTotal = totals[0].ToString("C");
            string edwardGrandTotal = totals[1].ToString("C");
            string francisGrandTotal = totals[2].ToString("C");
            Console.WriteLine("Sales Total:  {0}: {1}  {2}: {3}  {4}: {5}", names[0], danielleGrandTotal, names[1], edwardGrandTotal, names[2], francisGrandTotal);
        }
    }
}
