/*
 * Student ID : 1690704190
 * Name       : Assignment02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

class Program
{
    static void Main()
    {
        const double SmeltRate = 0.25;
        const double SalvageRate = 0.30;

        while (true)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("        THE IRON FORGE");
            Console.WriteLine("=================================");
            Console.WriteLine($"S - Smelt Iron Ore -> Iron Ingot");
            Console.WriteLine($"B - Breakdown Iron Ingot -> Iron Ore");
            Console.WriteLine("Q - Quit");
            Console.WriteLine();
            Console.Write("Choose Menu: ");

            string? menu = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(menu))
            {
                Console.WriteLine("Invalid menu. Please try again.");
                Console.WriteLine();
                continue;
            }

            menu = menu.ToUpper();

            if (menu == "Q")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (menu != "S" && menu != "B")
            {
                Console.WriteLine("Invalid menu. Please choose S, B, or Q.");
                Console.WriteLine();
                continue;
            }

            Console.Write("How much would you like: ");
            string? input = Console.ReadLine();

            if (!double.TryParse(input, out double amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number.");
                Console.WriteLine();
                continue;
            }

            if (amount < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
                Console.WriteLine();
                continue;
            }

            if (menu == "S")
            {
                double ingot = amount * SmeltRate;

                Console.WriteLine();
                Console.WriteLine(
                    $"{amount:F2} Iron Ore -> {ingot:F2} Iron Ingot"
                );
            }
            else if (menu == "B")
            {
                double ore = amount / SalvageRate;

                Console.WriteLine();
                Console.WriteLine(
                    $"{amount:F2} Iron Ingot -> {ore:F2} Iron Ore"
                );
            }

            Console.WriteLine();
        }
    }
}