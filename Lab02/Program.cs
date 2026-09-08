/*
 * Student ID : 1690704190
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

class Program
{
    static void Main()
    {
        // =========================
        // Part A — Kirin's Status Report
        // =========================

        string bossName = "Kirin";
        char rank = 'S';
        int level = 7;
        int maxHp = 240;
        int currentHp = 175;
        float attackPower = 42.5f;
        double critMultiplier = 1.75;
        bool isBoss = true;

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

        Console.WriteLine();

        Console.WriteLine("Kirin takes 60 damage!");
        currentHp = currentHp - 60;

        Console.WriteLine();

        Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
        Console.WriteLine($"HP: {currentHp} / {maxHp}");

        hpPercent = currentHp * 100 / maxHp;
        Console.WriteLine($"HP Percent: {hpPercent}%");


        // =========================
        // Part B — My Own Game
        // =========================

        string heroName = "Cyrus";
        int heroHp = 150;
        float heroSpeed = 8.5f;
        char heroRank = 'A';
        bool heroAlive = true;

        string mageName = "Aurora";
        int mageHp = 100;
        double mageMagicPower = 95.5;
        char mageRank = 'S';
        bool mageAlive = true;

        string warriorName = "Maple";
        int warriorHp = 220;
        float warriorDefense = 35.5f;
        char warriorRank = 'B';
        bool warriorAlive = true;

        string archerName = "Nestor";
        int archerHp = 120;
        double archerCriticalRate = 0.75;
        char archerRank = 'A';
        bool archerAlive = true;

        Console.WriteLine("===== MY BATTLE TEAM =====");

        Console.WriteLine($"Name: {heroName}");
        Console.WriteLine($"HP: {heroHp}");
        Console.WriteLine($"Speed: {heroSpeed}");
        Console.WriteLine($"Rank: {heroRank}");
        Console.WriteLine($"Alive: {heroAlive}");

        Console.WriteLine($"Name: {mageName}");
        Console.WriteLine($"HP: {mageHp}");
        Console.WriteLine($"Magic Power: {mageMagicPower}");
        Console.WriteLine($"Rank: {mageRank}");
        Console.WriteLine($"Alive: {mageAlive}");

        Console.WriteLine($"Name: {warriorName}");
        Console.WriteLine($"HP: {warriorHp}");
        Console.WriteLine($"Defense: {warriorDefense}");
        Console.WriteLine($"Rank: {warriorRank}");
        Console.WriteLine($"Alive: {warriorAlive}");

        Console.WriteLine($"Name: {archerName}");
        Console.WriteLine($"HP: {archerHp}");
        Console.WriteLine($"Critical Rate: {archerCriticalRate}");
        Console.WriteLine($"Rank: {archerRank}");
        Console.WriteLine($"Alive: {archerAlive}");
    }
}
