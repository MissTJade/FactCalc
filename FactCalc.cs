using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    internal class Program
    {
        static BigInteger fCalcFact(uint n)
        {
            BigInteger iFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Step ID: {i}");
                iFactorial *= i;
                Console.WriteLine($"Factorial Total: {iFactorial}");
            }
            return iFactorial;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input The Factorial Number: ");
                uint iCap = uint.Parse(Console.ReadLine());

                Console.WriteLine("--- --- ---");
                Console.WriteLine($"\nFactorial of {iCap} equals: {fCalcFact(iCap)}");
                Console.WriteLine("===========");

                Console.WriteLine("Press Any Key To Restart");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
