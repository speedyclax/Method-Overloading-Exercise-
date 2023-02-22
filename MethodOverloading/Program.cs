using System.Reflection;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;

            if (isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return $"{sum} dollar";
            }
            
            
        }
        static void Main(string[] args)
        {
            var answer = Add(2.0m, 1.4m);
            Console.WriteLine(answer);
        }
    }
}
