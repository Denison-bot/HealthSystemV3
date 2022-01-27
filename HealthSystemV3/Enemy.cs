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
            enemyUnitTest.RunUnitTest();
            maxHealth = 100;
            maxShield = 100;
            currentHealth = maxHealth;
            currentShield = maxShield;
        }
    }
}
