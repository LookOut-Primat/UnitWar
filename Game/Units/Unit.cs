using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Unit
    {
        public delegate void AttackAction(int damage);
        public event AttackAction DoAttack;

        public delegate void DeadAction(List<Unit> Units, Unit unit);
        public event DeadAction DoDead;

        public string Name { get; protected set; }
        public int Number { get; protected set; }
        public int Health { get; protected set; }
        public int Armor { get; protected set; }
        public Weapon weapon { get; protected set; }

        public void Attack(int damage)
        {
            DoAttack(damage);
        }

        public void Wound(int damage)
        {
            if (damage <= Armor)
            {
                Armor -= damage;
            }
            if(damage > Armor)
            {
                int i = Armor - damage;
                i *= -1;
                Console.WriteLine(i);
                Armor = 0;

                if (i >= Health)
                {
                    Health = 0;
                }
                else
                {
                    Health -= i;
                }
            }
            
        }
        
        public void Dead(List<Unit> Units, Unit unit)
        {
            Console.WriteLine($"{unit.Name}({unit.Number}) погибает");
            Units.Remove(unit);
        }
    }
}
