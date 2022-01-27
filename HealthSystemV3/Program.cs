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
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Running unit test");
            //unitTest.RunUnitTest();


            player1.ShowStats();

            player1.TakeDamage(50);
            player1.ShowStats();

            player1.TakeDamage(60);
            player1.ShowStats();

            player1.TakeDamage(50);
            player1.ShowStats();

            player1.RegenHealth(20);
            player1.ShowStats();

            player1.RegenSheild(20);
            player1.ShowStats();

            player1.RegenHealth(1000000000);
            player1.ShowStats();

            player1.RegenSheild(1000000000);
            player1.ShowStats();
        }
    }
}
