using IntroDelegates.Services;

namespace IntroDelegates
{
        
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //double result = CalculationServices.Max(a, b); // uso normal
            BinaryNumericOperation op = CalculationServices.Max; // op terá a referência do método da classe max
            BinaryNumericOperation op1 = CalculationServices.Sum;
            //, no entanto somente funcionará caso a declaração dos parâmetros sejam como as do delegate.

            //exemplo abaixo não funciona, pois, square espera somente um parâmetro
            //BinaryNumericOperation op2 = CalculationServices.Square;
            double result = op(a, b); // ou, outra forma de chamada...
            result = op.Invoke(a, b);
            Console.WriteLine("O maior :" + result);
            Console.WriteLine("A Soma: " + op1(a, b));

        }
    }
}