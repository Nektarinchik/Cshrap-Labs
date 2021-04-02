using System;
using System.Runtime.InteropServices;

namespace MathFunctions
{
    class Program
    {
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Sum(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Subtract(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Multiply(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Divide(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Mod(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Abs(int value);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.StdCall)]
        static extern int Min(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Pow(int firstValue, int secondValue);
        [DllImport("myDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Max(int firstValue, int secondValueb);

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3, 4));
            Console.WriteLine(Subtract(3, 4));
            Console.WriteLine(Multiply(3, 4));
            Console.WriteLine(Divide(3, 4));
            Console.WriteLine(Mod(3, 4));
            Console.WriteLine(Abs(-32));
            Console.WriteLine(Pow(3, 4));
            Console.WriteLine(Min(3, 4));
            Console.WriteLine(Max(3, 4));
        }
    }
}