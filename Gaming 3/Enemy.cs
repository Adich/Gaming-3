using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;

namespace Gaming_3
{
    public class Enemy
    {
        int hp; 
        int attackDmg;
        public Enemy(int hp, int attackDmg)
        {
            this.hp = hp;
            this.attackDmg = attackDmg;
        }

        public int attack()
        {
            Random random = new Random();
            return attackDmg + random.Next(0, 10);
        }

        public void takeDmg(int dmg)
        {
            hp -= dmg;
        }

        public int getHP()
        {
            return hp;
        }

        public bool isAlive()
        {
            if(hp < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}