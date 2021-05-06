using System;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Initials I = new Contact("Ermolaev", "Nikita", "Vladimirovich", 2982579);
            I.GetInfo();
        }
    }
}
