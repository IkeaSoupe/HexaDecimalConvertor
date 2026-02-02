namespace HexaDecimaleConvertor_
{
    using System;

    internal class HexConverter
    {
        static void Main()
        {
            string ExitChoice;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Decimal to Hexadecimal");
                Console.WriteLine("2. Hexadecimal to Decimal");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter a decimal number: ");
                    if (int.TryParse(Console.ReadLine(), out int decimalNumber))
                    {
                        string hex = decimalNumber.ToString("X");
                        Console.WriteLine($"Hexadecimal: {hex}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid decimal number.");
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter a hexadecimal number: ");
                    string hexInput = Console.ReadLine();
                    try
                    {
                        int decimalNumber = Convert.ToInt32(hexInput, 16);
                        Console.WriteLine($"Decimal: {decimalNumber}");
                    }
                    catch
                    {
                        Console.WriteLine("Invalid hexadecimal number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }

                Console.WriteLine("Press any key to clear the console...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Do you want to exit? Press 1 to exit, any other key to continue.");
                ExitChoice = Console.ReadLine();

            } while (ExitChoice != "1");
        }
    }
}
