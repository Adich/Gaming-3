using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;

namespace Gaming_3
{
    public class Race
    {
        public int stamina;
        public Role role = new Role();
        public Race()
        {
            this.stamina = 20;
        }

        public virtual void racialAbility()
        {
        }

        public void takeDmg(int dmg)
        {

            if (role.checkAttribute())
            {

            }
            else
            {
                stamina -= dmg;
            }
           
        }

    }

    class Human : Race
    {
        public Human()
        {
            stamina = 130;
        }

        public override void racialAbility()
        {
            Random random = new Random();
            stamina += random.Next(5, 90);
        }
    }

    class Orc : Race
    {
        public Orc()
        {
            stamina = 150;
        }

        public override void racialAbility()
        {
            Random random = new Random();
            this.role.gainStrenght(random.Next(5, 20));
        }
    }
}