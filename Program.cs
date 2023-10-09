using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneWayAttribute way of creating an array
            int[] luckynumbers = { 4, 5, 8, 9, };
            Console.WriteLine(luckynumbers[2]);
            //if you want to populate it later, the 5 is the size
            string[] friends = new string[5];
            friends[0] = "Patience";
            friends[1] = "Charles";
            friends[2] = "Sue";
            Console.WriteLine(friends[2]);

            Console.ReadLine();


        }
    }
}
