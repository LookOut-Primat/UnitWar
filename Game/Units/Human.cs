using Game.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Human: Unit
    {
        public Human(int number)
        {
            Name = "Human";
            Number = number;
            Health = 100;
            Armor = 50;
            weapon = new ClassicSword();
        }
    }
}
