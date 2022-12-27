using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        // public static void toPrint<T>(T[] inputArray)
        // {
        //    foreach (var element in inputArray)
        //  {
        //         Console.WriteLine(element);
        //     }
        //  }
        // public static void toPrint(double[] inputarray)
        // {
        //  foreach (double element in inputArray)
        //  {
        //    Console.WriteLine(element);
        // }
        // }
        // public static void toPrint(char[] inputArray)
        //{
        // foreach (char element in inputArray)
        // }
        //  Console.WriteLine(element);
        //}

        public static void Main(string[] args)
        {
          //  int[] intArray = { 1, 2, 3, 4, 5 };
          //  double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
          //  char[] charArray = { 'H', 'E', 'A', 'R' };

            // toPrint<int>(intArray);
            // toPrint<double>(doubleArray);
            // toPrint<char>(charArray);

            //   PrintArray<int> intprintArray = new PrintArray<int>(intArray);
            // intprintArray.toPrint();
            //PrintArray<double> doubleprintArray = new PrintArray<double>(doubleArray);
            //doubleprintArray.toPrint();
            // PrintArray<char> charprintArray = new PrintArray<char>(charArray);
            //charprintArray.toPrint();
            //Console.ReadKey();

            double firstvalue = 34.3;
            double secondvalue = 20.5;
            
            
            
            double value = firstvalue.CompareTo(secondvalue);
            

             Console.WriteLine(value);
            Console.ReadKey();
        }

    }
}
