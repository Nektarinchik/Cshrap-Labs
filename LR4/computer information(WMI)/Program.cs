using System;

namespace computer_information_WMI_
{
    class Program
    {
        static void Main(string[] args)
        {
            uint type = 0;
            Console.WriteLine("The following information is available:\n" +
                "1. CPU\n" +
                "2. RAM\n" +
                "3. Graphics card");
            bool canUseInput;
            do
            {
                canUseInput = true;
                try
                {
                    Console.WriteLine("Enter the number 1, 2 or 3 depending on the type of information you are interested in : ");
                    type = Convert.ToUInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message + " It is not a number");
                    canUseInput = false;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message + " Incorrect number");
                    canUseInput = false;
                }
            } while (!canUseInput);
            Console.Clear();
            switch (type)
            {
                case 1:
                    GetInfo.GetCPUInfo();
                    break;
                case 2:
                    GetInfo.GetRAMInfo();
                    break;
                case 3:
                    GetInfo.GetGraphicsCardInfo();
                    break;
            }
        }
    }
}
