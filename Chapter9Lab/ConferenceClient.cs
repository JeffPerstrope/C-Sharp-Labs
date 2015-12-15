using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9Lab
{
    class ConferenceClient
    {
        static void Main(string[] args)
        {
            string name = "";
            string date = "";
            int numOfPeople = 0;
            Conference[] groups = new Conference[2];
            for (int i = 0; i < groups.Length; i++)
            {
                Console.Write("Group Name: ");
                name = Console.ReadLine();
                Console.Write("Date: ");
                date = Console.ReadLine();
                Console.Write("Number of people: ");
                numOfPeople = Convert.ToInt32(Console.ReadLine());
                groups[i] = new Conference(name, date, numOfPeople);
                Console.WriteLine("");
            }

            Console.WriteLine("");

            Array.Sort(groups);

            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine("Group Name: {0}   Date: {1}   # of people: {2}", groups[i].GroupName, groups[i].Date, groups[i].Attendence);
            }
        }
    }
}
