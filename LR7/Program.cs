using System;

namespace LR7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 9);
            Fraction f2 = new Fraction(5, 6);
            Fraction testF;
            Console.WriteLine("Testing math operations");
            testF = f1 * f2;
            Console.WriteLine($"f1 * f2 = {testF.GetDoubleType()}");
            testF = f1 / f2;
            Console.WriteLine($"f1 / f2 = {testF.GetDoubleType()}");
            testF = f1 + f2;
            Console.WriteLine($"f1 + f2 = {testF.GetDoubleType()}");
            testF = f1 - f2;
            Console.WriteLine($"f1 - f2 = {testF.GetDoubleType()}");
            Console.WriteLine("Testing comparison operations");
            Console.WriteLine($"f1 > f2 = {f1 > f2}");
            Console.WriteLine($"f1 < f2 = {f1 < f2}");
            Console.WriteLine($"f1 >= f2 = {f1 >= f2}");
            Console.WriteLine($"f1 <= f2 = {f1 <= f2}");
            Console.WriteLine($"f1 == f2 = {f1 == f2}");
            Console.WriteLine($"f1 != f2 = {f1 != f2}");
            Console.WriteLine("Testing object to string ");
            Console.WriteLine($"f1 -> ToString(F) = {f1.ToString()}");
            Console.WriteLine($"f1 -> ToString(D) = {f1.ToString("D", null)}");
            Console.WriteLine($"f1 -> ToString(F) = {f1.ToString("D3", null)}");
            Console.WriteLine($"f1 -> ToString(F) = {f1.ToString("F4", null)}");
            try
            {
                f1.ToString("I", null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Testing string to object");
            testF = Fraction.Parse("350/100");
            Console.WriteLine($"testF = 350/150 = {testF.GetDoubleType()}");
            testF = Fraction.Parse("1000");
            Console.WriteLine($"testF = 1000 = {testF.GetDoubleType()}");
            testF = Fraction.Parse("350.100");
            Console.WriteLine($"testF = 350.150 = {testF.GetDoubleType()}");
            testF = Fraction.Parse("350,100");
            Console.WriteLine($"testF = 350,150 = {testF.GetDoubleType()}");
            try
            {
                testF = Fraction.Parse("350//100");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Testing conversion operators and IConvertible");
            Console.WriteLine($"f1.ToBoolean = {f1.ToBoolean(null)}");
            Console.WriteLine($"f1.GetTypeCode = {f1.GetTypeCode()}");
            Console.WriteLine($"f1.ToDouble = {f1.ToDouble(null)}");
            Console.WriteLine($"f1.ToInt32 = {f1.ToInt32(null)}");
        }
    }
}
