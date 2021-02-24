using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class Character
    {
        public string name;
        public int health;
        public int maxHealth;
        public int damage;
        public string wName;

        public int Hurt(int eDamage)
        {
            health = health - eDamage;
            return health;
        }
        public void PickUp(int weapon, string weName)
        {
            wName = weName;
            damage = weapon;
        }

    }
}
