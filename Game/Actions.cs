using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class Actions
    {
        //действие атаки. Атакуемый подписывается на событие атаки атакуеющего, затем атакующий вызывает свой метод атаки. Отслеживается здоровье атакованного и, если нужно, вызывает метод смерти 
        public static void Attack(Unit Unit1, Unit Unit2, List<Unit> Units2)
        {
            Unit1.DoAttack += Unit2.Wound;
            Unit1.Attack(Unit1.weapon.Damage);
            Console.WriteLine($"{Unit1.Name}({Unit1.Number}) атакует {Unit2.Name}({Unit2.Number}) и наносит урон равный {Unit1.weapon.Damage}");

            Unit1.DoAttack -= Unit2.Wound;
            if (Unit2.Health == 0)
            {
                Unit2.Dead(Units2, Unit2);
            }
        }
    }
}
