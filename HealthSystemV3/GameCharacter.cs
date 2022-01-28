using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV3
{
    abstract class GameCharacter
    {
        public int currentHealth;
        public int currentShield;
        public int maxHealth;
        public int maxShield;
        public int minHealth;
        public int minSheild;
        public bool dead = false;

        public void RegenShield(int sp)
        {
            if (sp >= 2000000000)
            {
                sp = 10000000;
            }
            if (sp >= 0)
            {
                currentShield = currentShield + sp;
            }
            if (currentShield >= maxShield)
            {
                currentShield = maxShield;
            }
            //ShowStats();
        }

        public void RegenHealth(int hp)
        {
            if (hp >= 2000000000)
            {
                hp = 10000000;
            }
            if (hp >= 0)
            {
                currentHealth = currentHealth + hp;
            }
            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            }
            if (currentHealth <= minHealth)
            {
                currentHealth = minHealth;
            }

            //ShowStats();
        }

        public void TakeDamage(int damageTaken)
        {
            if (damageTaken >= 2000000000)
            {
                damageTaken = 10000000;
            }

            if (damageTaken >= 0)
            {
                currentShield = currentShield - damageTaken;
                if (currentShield <= 0)
                {
                    currentHealth = currentHealth + currentShield;
                }
                if (currentShield <= 0)
                {
                    currentShield = 0;
                }
                if (currentHealth <= 0)
                {
                    currentHealth = 0;
                    Console.WriteLine("Dead");
                    //Respawn();
                }
            }
            //ShowStats();
        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Health = " + currentHealth);
            Console.WriteLine("Shield = " + currentShield);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        public void Respawn()
        {
            currentHealth = maxHealth;
            currentShield = maxShield;
            //ShowStats();
        }
    }
}
