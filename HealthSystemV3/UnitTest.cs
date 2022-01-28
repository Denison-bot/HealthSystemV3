using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HealthSystemV3
{
    class UnitTest : GameCharacter
    {
        static Player playerTest = new Player();
        static Enemy enemyTest = new Enemy();

        public void RunUnitTest()
        {
            Console.WriteLine("running unit test");

            playerTest.RunUnitTest();
            enemyTest.RunUnitTest();

            Console.WriteLine("Press any key");
            Console.ReadKey(true);

            //Console.ReadKey(true);
            Console.WriteLine("No errors encountered");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
        
    }
}
