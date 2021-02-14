using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Weapons;

namespace Game.Units
{
    class Orc: Unit
    {
        public Orc(int number)
        {
            Name = "Orc";
            Number = number;
            Health = 100;
            Armor = 0;
            weapon = new ClassicSword();
        }
    }
}
