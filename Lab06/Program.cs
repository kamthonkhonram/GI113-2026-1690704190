/*
* Student ID : 1690704190
* Name       : Lab06
* Section    : 129D
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== HERO VS MONSTER ===");
        Console.WriteLine("A powerful monster appears!");
        Console.WriteLine();
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Defend");
        Console.WriteLine("3. Use Potion");
        Console.WriteLine();
        Console.Write("Choose your action: ");

        bool inputOk = int.TryParse(Console.ReadLine(), out int action);

        if (!inputOk)
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 3.");
        }
        else if (action == 1)
        {
            Console.WriteLine("You attack the monster with your sword!");
            Console.WriteLine("You deal 40 damage to the monster.");
            Console.WriteLine("The monster is defeated!");
        }
        else if (action == 2)
        {
            Console.WriteLine("You raise your shield and defend yourself.");
            Console.WriteLine("The monster attacks, but you block the damage.");
            Console.WriteLine("You are ready for the next battle.");
        }
        else if (action == 3)
        {
            Console.WriteLine("You drink a healing potion.");
            Console.WriteLine("Your HP increases by 30 points.");
            Console.WriteLine("You are ready to fight the monster again.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
        }
    }
}



