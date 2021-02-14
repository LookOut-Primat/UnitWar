using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Units;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitsFabric Fabric = new UnitsFabric();

            //создание нзаданного количества юнитов
            Console.WriteLine("Выберите количество юнитов Human и Orc");
            Console.WriteLine("Количество Humans: ");
            List<Unit> Humans = Fabric.Amount(Convert.ToInt32(Console.ReadLine()), "Human");

            Console.WriteLine("Количество Orcs: ");
            List<Unit> Orcs = Fabric.Amount(Convert.ToInt32(Console.ReadLine()), "Orc");

            //вывод созданных юнитов
            Fabric.AllUnits(Humans, "Human");
            Fabric.AllUnits(Orcs, "Orc");

            //переключатель хода
            bool Turn = false;

            Console.WriteLine("Игра началась!");
            //сама игра
            while (Humans.Count != 0 && Orcs.Count != 0)
            {
                Console.Clear();
                Fabric.AllUnits(Humans, "Human");
                Fabric.AllUnits(Orcs, "Orc");

                Console.ReadKey();
                if (Turn == false)
                {
                    //Turn Human
                    Console.WriteLine("\nХод Humans\nВыберете номер атакующего");
                    int Index1 = Fabric.InputValidation(Humans);

                    Console.WriteLine("Выберете номер атакуемого");
                    int Index2 = Fabric.InputValidation(Orcs);

                    Actions.Attack(Humans[Index1], Orcs[Index2], Orcs);

                    Turn = true;
                } else
                {
                    //Turn Orc
                    Console.WriteLine("\nХод Orcs\nВыберете номер атакующего");
                    int Index1 = Fabric.InputValidation(Orcs);

                    Console.WriteLine("Выберете номер атакуемого");
                    int Index2 = Fabric.InputValidation(Humans);

                    Actions.Attack(Orcs[Index1], Humans[Index2], Humans);

                    Turn = false;
                }
                Console.ReadKey();
            }
            
            Console.Write($"Игра окончена. Победил: ");
            if (Humans.Count == 0)
            {
                Console.Write("Orc");
            } else
            {
                Console.Write("Human");
            }
            
            Console.ReadKey();
        }
    }
}
