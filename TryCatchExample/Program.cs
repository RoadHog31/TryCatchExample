using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20, num2 = 5, num3 = 10;
            int count = 0;
            double average;
            //Calculate the average without the try/catch
            //average = (num1 + num2 + num3) / count;

            try
            {
                average = (num1 + num2 + num3) / count;
            }
            catch (DivideByZeroException)
            {
                Console.Out.WriteLine("the program is attempting to divide by Zero");
                Console.ReadLine(); 
            }
            
        }
    }
}
