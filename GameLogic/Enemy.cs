using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Enemy {
        Random random = new Random();
        public int strength;
        public int health;
        public int maxHealth;
        public int dexterity;
        public int wisdom;

        public int setStrength() {
            strength = random.Next(1, 10 + 1);

            return strength;
        }

        public int setHealth() {
            health = random.Next(50, 100 + 1);

            maxHealth = health;
            return health;
        }

        public int setDexterity() {
            dexterity = random.Next(1, 10 + 1);

            return dexterity;
        }

        public int setWisdom()
        {
            wisdom = random.Next(1, 10 + 1);

            return wisdom;
        }
    }
}
