using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV3
{
    class GameCharacter
    {
        public int currentHealth;
        public int currentShield;
        public int maxHealth;
        public int maxShield;

        public void RegenSheild(int sp)
        {
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
            if (hp >= 0)
            {
                currentHealth = currentHealth + hp;
            }
            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            }
            //ShowStats();
        }

        public void TakeDamage(int damageTaken)
        {
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
                    Console.WriteLine("Dead--Respawning");
                    Respawn();
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
