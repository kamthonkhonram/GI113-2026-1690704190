/*
 * Student ID : 1690704190
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System;
using static System.Net.Mime.MediaTypeNames;
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args) {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // Lab 02 Part B
            string warriorName = "Cyrus";
            int warriorHp = 300;
            float warriorSpeed = 7.5f;
            char warriorRank = 'A';
            bool warriorAlive = true;

            string mageName = "Aurora";
            int mageMana = 250;
            double mageMagicPower = 85.5;
            char mageRank = 'S';
            bool mageAlive = true;

            string archerName = "Maple";
            int archerHp = 180;
            float archerAccuracy = 92.5f;
            char archerRank = 'A';
            bool archerAlive = true;

            string healerName = "Nestor";
            int healerHp = 200;
            double healerHealPower = 75.25;
            char healerRank = 'B';
            bool healerAlive = true;

            Console.WriteLine("===== CHARACTER STATUS : FANTASY GAME =====");

            Console.WriteLine("----- Warrior -----");
            Console.WriteLine($"Name: {warriorName}");
            Console.WriteLine($"HP: {warriorHp}");
            Console.WriteLine($"Speed: {warriorSpeed}");
            Console.WriteLine($"Rank: {warriorRank}");
            Console.WriteLine($"Alive: {warriorAlive}");

            Console.WriteLine("----- Mage -----");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Mana: {mageMana}");
            Console.WriteLine($"Magic Power: {mageMagicPower}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"Alive: {mageAlive}");

            Console.WriteLine("----- Archer -----");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"HP: {archerHp}");
            Console.WriteLine($"Accuracy: {archerAccuracy}");
            Console.WriteLine($"Rank: {archerRank}");
            Console.WriteLine($"Alive: {archerAlive}");

            Console.WriteLine("----- Healer -----");
            Console.WriteLine($"Name: {healerName}");
            Console.WriteLine($"HP: {healerHp}");
            Console.WriteLine($"Heal Power: {healerHealPower}");
            Console.WriteLine($"Rank: {healerRank}");
            Console.WriteLine($"Alive: {healerAlive}");
        }
        
        
    }
}

