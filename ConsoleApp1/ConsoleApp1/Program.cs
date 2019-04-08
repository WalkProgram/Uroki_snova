using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = Plus(45, 12);
            int result2 = Plus(92, 14);
            int result3 = Plus(73, 13);
            int result4 = Plus(83, 5);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadKey();
        }


        static void Write(string str)
        {
            Console.WriteLine("Privet");
            Console.WriteLine(str);
            Console.WriteLine("Do svidaniya");
        }

        static int Plus(int param1, int param2)
        {
            return param1 + param2;
        }
        static int Difference(int param1, int param2)
        {
            return param1 - param2;
            
        }

        static int Minus(int chislo1, int chislo2)
        {

            int result = Difference(200, 50);
            return result;



        }


           




        
    }
}
