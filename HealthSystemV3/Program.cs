using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV3
{
    class Program
    {
        static Player player1 = new Player();
        static Enemy enemy1 = new Enemy();
        static UnitTest unitTest = new UnitTest();
        
        static void Main(string[] args)
        {
            // run unit test
            unitTest.RunUnitTest();

            // example player gameplay
            Console.WriteLine();
            Console.WriteLine("Player Gameplay");
            player1.ShowStats();

            Console.WriteLine("Player takes 50 damage");
            player1.TakeDamage(50);
            player1.ShowStats();

            Console.WriteLine("Player takes 60 damage");
            player1.TakeDamage(60);
            player1.ShowStats();

            Console.WriteLine("Player takes 50 damage");
            player1.TakeDamage(50);
            player1.ShowStats();

            Console.WriteLine("Player regens 20 hp");
            player1.RegenHealth(20);
            player1.ShowStats();

            Console.WriteLine("Player regens 20 sheild");
            player1.RegenShield(20);
            player1.ShowStats();

            Console.WriteLine("Player regen 1000000000 hp");
            player1.RegenHealth(1000000000);
            player1.ShowStats();

            Console.WriteLine("Player regen 1000000000 sheild");
            player1.RegenShield(1000000000);
            player1.ShowStats();

            Console.WriteLine("Player takes 1000000000 damage");
            player1.TakeDamage(1000000000);
            player1.ShowStats();

            // example enemy gameplay
            Console.WriteLine();
            Console.WriteLine("Enemy Gameplay");
            enemy1.ShowStats();

            Console.WriteLine("Enemy takes 50 damage");
            enemy1.TakeDamage(50);
            enemy1.ShowStats();

            Console.WriteLine("Enemy takes 60 damage");
            enemy1.TakeDamage(60);
            enemy1.ShowStats();

            Console.WriteLine("Enemy takes 50 damage");
            enemy1.TakeDamage(50);
            enemy1.ShowStats();

            Console.WriteLine("Enemy regens 20 hp");
            enemy1.RegenHealth(20);
            enemy1.ShowStats();

            Console.WriteLine("Enemy regens 20 shield");
            enemy1.RegenShield(20);
            enemy1.ShowStats();

            Console.WriteLine("Enemy regen 1000000000 hp");
            enemy1.RegenHealth(1000000000);
            enemy1.ShowStats();

            Console.WriteLine("Enemy regen 1000000000 shield");
            enemy1.RegenShield(1000000000);
            enemy1.ShowStats();

            Console.WriteLine("Enemyd takes 1000000000 damage");
            enemy1.TakeDamage(1000000000);
            enemy1.ShowStats();
        }
    }
}
