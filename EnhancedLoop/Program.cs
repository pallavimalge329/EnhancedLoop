using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
             int count = 0;
             foreach (int element in fibNumbers)
             {
                 count++;
                 Console.WriteLine($"Element #{count}: {element}");
             }
             Console.WriteLine($"Number of elements: {count}");
             Console.ReadLine();*/


            String[] myArray;

            myArray = new String[10];
            myArray[0] = "Pallavi";
            myArray[1] = "Palak";
            myArray[2] = "Neha";

            // We do not need to get the size of array.

            Console.WriteLine("Elements of the array: ");
            foreach (string val in myArray)     // Each element in myArray is a string
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();


        }
    }
}
