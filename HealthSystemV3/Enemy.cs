using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV3
{
    class Enemy : GameCharacter
    {
        static UnitTest enemyUnitTest = new UnitTest();
        public Enemy()
        {
            maxHealth = 100;
            maxShield = 100;
            minHealth = 0;
            minSheild = 0;
            currentHealth = maxHealth;
            currentShield = maxShield;
        }
        public void RunUnitTest()
        {
            // ------typical-cases------

            // testing take damage
            currentHealth = 100;
            currentShield = 100;
            TakeDamage(50);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 50);

            // testing damage straight to health
            currentHealth = 100;
            currentShield = 0;
            TakeDamage(50);
            Debug.Assert(currentHealth == 50);
            Debug.Assert(currentShield == 0);

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
            Debug.Assert(currentHealth == 60);
            Debug.Assert(currentShield == 100);

            // testing regen shield
            currentHealth = 10;
            currentHealth = 10;
            RegenShield(90);
            Debug.Assert(currentHealth == 10);
            Debug.Assert(currentShield == 100);

            // ------special-cases------

            // large damage values
            currentHealth = 100;
            currentShield = 100;
            TakeDamage(1000);
            Debug.Assert(currentHealth == 0);
            Debug.Assert(currentShield == 0);

            currentHealth = 100;
            currentShield = 100;
            TakeDamage(10000000);
            Debug.Assert(currentHealth == 0);
            Debug.Assert(currentShield == 0);

            // large regen health values
            currentHealth = 10;
            currentShield = 100;
            RegenHealth(1000);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            currentHealth = 10;
            currentShield = 100;
            RegenHealth(10000000);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            // large regen sheild values
            currentHealth = 100;
            currentShield = 10;
            RegenShield(1000);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            currentHealth = 100;
            currentShield = 10;
            RegenShield(10000000);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            // ------Known-input-error------

            // negative damage value
            currentHealth = 100;
            currentShield = 100;
            TakeDamage(-50);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            // negative RegenHealth value
            currentHealth = 10;
            currentShield = 100;
            RegenHealth(-50);
            Debug.Assert(currentHealth == 10);
            Debug.Assert(currentShield == 100);

            // negative RegenSheild value
            currentHealth = 100;
            currentShield = 10;
            RegenShield(-50);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 10);

            // ------min/max-data-type-values------

            // damage
            currentHealth = 10;
            currentShield = 10;
            TakeDamage(int.MinValue);
            Debug.Assert(currentHealth == 10);
            Debug.Assert(currentShield == 10);

            currentHealth = 10;
            currentShield = 10;
            TakeDamage(int.MaxValue);
            Debug.Assert(currentHealth == 0);
            Debug.Assert(currentShield == 0);

            // Regen health
            currentHealth = 10;
            currentShield = 100;
            RegenHealth(int.MinValue);
            Debug.Assert(currentHealth == 10);
            Debug.Assert(currentShield == 100);

            currentHealth = 10;
            currentShield = 100;
            RegenHealth(int.MaxValue);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            // Regen sheild
            currentHealth = 100;
            currentShield = 10;
            RegenShield(int.MinValue);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 10);

            currentHealth = 100;
            currentShield = 10;
            RegenShield(int.MaxValue);
            Debug.Assert(currentHealth == 100);
            Debug.Assert(currentShield == 100);

            //Console.WriteLine(currentHealth);
            //Console.WriteLine(currentShield);
        }
    }
}
