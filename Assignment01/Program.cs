/*
 * Student ID : 1690704190
 * Name       : Lab03
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Sinbound";

            var characterName = "Moon";
            var characterRank = 'S';

            int characterLevel = 28;
            float attackPower = 245.5f;
            double healthPoint = 786.5;
            bool isAlive = true;

            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine($"║        {GameTitle} - STAT CARD        ║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine($"║ Character : {characterName}                 ║");
            Console.WriteLine($"║ Rank      : {characterRank}                          ║");
            Console.WriteLine($"║ Level     : {characterLevel}                         ║");
            Console.WriteLine($"║ Attack    : {attackPower}                       ║");
            Console.WriteLine($"║ HP        : {healthPoint}                       ║");
            Console.WriteLine($"║ Alive     : {isAlive}                        ║");
            Console.WriteLine("╚══════════════════════════════════════╝");

            Console.WriteLine();

            double levelAsDouble = characterLevel;

            Console.WriteLine("----- TYPE CONVERSION -----");
            Console.WriteLine($"Level as double (Implicit) : {levelAsDouble}");

            int healthTruncated = (int)healthPoint;
            int healthRounded = Convert.ToInt32(healthPoint);

            Console.WriteLine($"HP with Explicit Cast      : {healthTruncated}");
            Console.WriteLine($"HP with Convert.ToInt32    : {healthRounded}");

            Console.WriteLine();
            Console.WriteLine("----- END OF STAT CARD -----");
        }
    }
}
