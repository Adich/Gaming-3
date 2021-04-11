using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming_3
{
    public class Role
    {
        public int strenght;
        public int dexterity;
        public int intellect;

        public Role()
        {
            strenght = 10;
            dexterity = 10;
            intellect = 10; 
        }

        public virtual bool checkAttribute()
        {
            return false;
        }
        public virtual void classAbility()
        {
            intellect -= 1;
        }
        public void gainStrenght(int str)
        {
            this.strenght += str;
        }

        public virtual void attack(Enemy enemy)
        {
            enemy.takeDmg(strenght);
        }
    }

    class Paladin : Role
    {
        public bool invulnerable;
        public Paladin()
        {
            base.strenght = 14;
            base.dexterity = 12;
            base.intellect = 9;
        }

        public override bool checkAttribute()
        {
            bool check = invulnerable;
            this.invulnerable = false;
            return check;
        }
        public override void classAbility()
        {
            invulnerable = true;
        }
    }

    class PeterPan : Role
    {
        public PeterPan()
        {
            base.strenght = 5;
            base.dexterity = 24;
            base.intellect = 3;
        }

        public override void attack(Enemy enemy)
        {
            enemy.takeDmg(dexterity);
        }

        public override void classAbility()
        {
            //Peter pan flies away
            Environment.Exit(0);

        }
    }
}