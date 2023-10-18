
namespace IntroDelegates.Services
{
    internal class CalculationServices
    {
        /* métodos comentados para o uso do multicast
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
        */
        public static void Max(double x, double y)
        {
            double result = (x>y) ? x : y;
            Console.WriteLine(result);
        }
        public static void Sum(double x, double y)
        {
            Console.WriteLine(x + y);
        }
    }
}
