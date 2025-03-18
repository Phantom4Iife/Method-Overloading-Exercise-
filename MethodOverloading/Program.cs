using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine(Sum(5, 10))              
            
            Console.WriteLine(Sum(5.5, 4.5));            
            Console.WriteLine(FormattedSum(1, 0, true)); 
            Console.WriteLine(FormattedSum(5, 11, true)); 
          
            Console.WriteLine(FormattedSum(0, 0, true)); 
        }

        
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        
        public static double Sum(double num1,  double num2)
        {
            return num1 + num2;
            
        }

        
        public static string FormattedSum(int num1, int num2, bool useCurrency)
        {
            int total = num1 + num2;

            
            if (!useCurrency) return total.ToString();

            return total == 1 ? total + " dollar" : total + " dollars";
        }
    }
}