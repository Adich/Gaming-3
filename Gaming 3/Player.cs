using System;
using System.Collections.Generic;
using System.Text;

namespace Gaming_3
{
    public class Player
    {
        string name;
        public Race race;

        public string Name { get => name; set => name = value; }

        public Player(string name)
        {
            this.name = name;
            race = new Race();
        }

        public void changeRace(string nameOfRace)
        {
            if(nameOfRace == "Human")
            {
                race = new Human();
            }
            else if (nameOfRace == "Orc")
            {
                race = new Orc();
            }
        }

        public void changeRole(string nameOfRole)
        {
            if (this.race != null)
            {
                if (nameOfRole == "Paladin")
                {
                    race.role = new Paladin();
                }
                else if (nameOfRole == "Peter Pan")
                {
                    race.role = new PeterPan();
                }

            }
        }
        public void takeDmg(int dmg)
        {
            this.race.takeDmg(dmg);
        }
    }
}