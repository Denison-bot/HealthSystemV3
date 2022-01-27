using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV3
{
    
    class Player : GameCharacter
    {
        static UnitTest playerUnitTest = new UnitTest();
        public Player()
        {

            maxHealth = 100;
            maxShield = 100;
            currentHealth = maxHealth;
            currentShield = maxShield;

        }
        public void RunUnitTest()
        {

            // testing take damage
            currentHealth = 100;
            currentShield = 100;
            TakeDamage(50);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 50);

            // testing spillover
            currentHealth = 100;
            currentShield = 100;
            TakeDamage(150);
            Debug.Assert(currentHealth == 50);
            Debug.Assert(currentShield == 0);

            // testing regen health
            currentHealth = 10;
            currentShield = 100;
            RegenHealth(50);
            Console.WriteLine(currentShield);
            // Debug.Assert(currentHealth == 60);
            Debug.Assert(currentShield == 100);

            Console.ReadKey(true);
            Console.WriteLine("No errors encountered");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
