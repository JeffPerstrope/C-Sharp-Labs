using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a movie name: ");
            string userMovie = Console.ReadLine();
            Console.Write("Length of movie in minutes: ");
            string userTime = Console.ReadLine();
            int.TryParse(userTime, out i);
            if (i == 0)
            {
                MovieTime(userMovie);
            }
            else
            {
                int movieMins = Convert.ToInt32(userTime);
                MovieTime(userMovie, movieMins);
            }
        }


        private static void MovieTime(string movie, int mins = 90)
        {
            Console.WriteLine("{0} is {1} minutes long", movie, mins);
        }
    }
}
