using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    class Enemy : GameCharacter
    {
        public Enemy()
        {
            currentHealth = 75;
            currentShield = 50;
        }
    }
}
