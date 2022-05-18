using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment
{
    internal class SwapTwoNo
    {
       public static void Swapnumber()
       {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            temp = number1; //temp=10
            number1 = number2; //number1=20      
            number2 = temp; //number2=10    
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
            Console.ReadKey();
       }
    }
    
}
