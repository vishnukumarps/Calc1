using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option;
            int n1,n2;
            int ans;

            Console.WriteLine("\t\t\t\t CALC");
            Console.WriteLine("\t\t\t==========================");

            Console.Write("(1) SUM");
            Console.Write("\t\t\t (2) SUM \n");

            Console.WriteLine("(3)Product \t\t  (4) Division");

            Console.WriteLine("\n\n\n\nChoose an option");
            option=Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("You have selected Sum");
                Console.WriteLine("Enter 2 num");
                n1=Convert.ToInt32(Console.ReadLine());
                n2=Convert.ToInt32(Console.ReadLine());

                ans=n1+ n2;
                Console.WriteLine("Sum="+ans);
                Console.WriteLine($"{n1}  +   {n2}   =  {ans}");

            }


        }
    }
}
