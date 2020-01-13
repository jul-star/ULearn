using System;
using System.Collections.Generic;
using System.Text;

namespace Branching
{
    public class Robot
    {
        public static bool ShouldFire0(bool enemyInFront,
                                string enemyName,
                                int robotHealth)
        {
            bool shouldFire = true;
            if (enemyInFront == true)
            {
                if (enemyName == "boss")
                {
                    if (robotHealth < 50) shouldFire = false;
                    if (robotHealth > 100) shouldFire = true;
                }
            }
            else
            {
                return false;
            }
            return shouldFire;
        }

        public static bool ShouldFire(bool enemyInFront,
            string enemyName,
            int robotHealth)
        {
            return (enemyInFront && enemyName != "boss") || (enemyInFront && enemyName == "boss" && robotHealth >= 50);
        }
    }
}
