using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming_3
{
    class Elf : Race
    {
        public Elf()
        {
            stamina = 120;
        }

        public override void racialAbility()
        {
            role.dexterity += 5;
        }
    }
}
