using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Units
{
    class UnitsFabric
    {
        public static Unit Fabric(string select, int number)
        {
            Unit unit = null;
            switch (select)
            {
                case "Human":  return unit = new Human(number);
                case "Orc": return unit = new Orc(number);
                default: Console.WriteLine("Такого юнита не существует"); return unit;
            }
        }

        //метод создания произвольного количества юнитов
        public List<Unit> Amount(int i, string NameUnit)
        {
            List<Unit> Units = new List<Unit>();
            while (i != 0)
            {
                Units.Add(UnitsFabric.Fabric(NameUnit, i));
                i--;
            }

            return Units;
        }

        //метод вывода всех созданных юнитов
        public void AllUnits(List<Unit> Units, string name)
        {
            foreach (Unit un in Units)
            {
                Console.WriteLine($"{name}({un.Number}): {un.Health}");
            }
        }

        //метод выполняющий поиск юнита с определенным номером
        public int Find(List<Unit> Units, int number)
        {
            foreach (Unit un in Units)
            {
                if(un.Number == number)
                {
                    //Console.WriteLine($"IndexOf:{Units.IndexOf(un)}");
                    return Units.IndexOf(un);
                }
            }
            return -1;
        }

        //проверка на корректный ввод номера юнита
        public int InputValidation(List<Unit> Units)
        {
            int Number = -1;

            while(Number == -1)
            {
                Console.WriteLine("Введите номер юнита: ");
                try
                {
                    Number = Find(Units, Convert.ToInt32(Console.ReadLine()));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
                if(Number == -1)
                {
                    Console.WriteLine("Такого юнита не существует. Введите корректный номер");
                }
            }
            
            return Number;
        }
    }
}
