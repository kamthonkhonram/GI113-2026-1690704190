using System.Runtime.Intrinsics.Arm;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin"; 
            var rank = 'S';           
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level {level} /{MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power : {attackPower} " +
                $"\nCrit Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");

            // Implicit Conversion: currentHp (int) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // (double)currentHpDouble = (int)currentHp
            Console.WriteLine($"HP (double): {currentHpDouble}");


            // Calculate Percent -->> double
            Console.WriteLine("\n----- Exact HP Percent (no interger truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact) : {hpPercentExact}%");


            // Explicit Conversation Cast attackPower (float) -->> int
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int castPower = (int)attackPower;
            Console.WriteLine($"Attack Power(int cast): {castPower}");


            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int castCrit = (int)critMultiplier;
            Console.WriteLine($"Crit Multiplier; (int cast): {castPower}");
            Console.WriteLine("Crit Multiplier (Convert rounded): " + Convert.ToInt32(critMultiplier));







            // Cast vs. Convert critMuliplier (double) -->> int










        }
    }
}
