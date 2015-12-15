using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Lab
{
    class PackageClient
    {
        static void Main(string[] args)
        {
            Package p1 = new Package(123, "Drew", 30);
            Package p2 = new Package(124, "Lisa", 32);
            Package p3 = new Package(125, "Sam", 40);
            InsuredPackage ip1 = new InsuredPackage(126, "Nick", 31);
            InsuredPackage ip2 = new InsuredPackage(127, "Mike", 157);
            Console.WriteLine("ID #: {0}   Name: {1}   Weight: {2}   Total Price: {3}\n", p1.IDNum, p1.RecipientName, p1.Weight, p1.SetPrice());
            Console.WriteLine("ID #: {0}   Name: {1}   Weight: {2}   Total Price: {3}\n", p2.IDNum, p2.RecipientName, p2.Weight, p2.SetPrice());
            Console.WriteLine("ID #: {0}   Name: {1}   Weight: {2}   Total Price: {3}\n", p3.IDNum, p3.RecipientName, p3.Weight, p3.SetPrice());
            Console.WriteLine("ID #: {0}   Name: {1}   Weight: {2}   Total Price: {3}\n\tWith insurance of {4}\n", ip1.IDNum, ip1.RecipientName, ip1.Weight, ip1.SetPrice(), ip1.PackageValue.ToString("C"));
            Console.WriteLine("ID #: {0}   Name: {1}   Weight: {2}   Total Price: {3}\n\tWith insurance of {4}\n", ip2.IDNum, ip2.RecipientName, ip2.Weight, ip2.SetPrice(), ip2.PackageValue.ToString("C"));
        }
    }
}
