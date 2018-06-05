using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.UI.Shared
{
    public static class UIRepository
    {
        public static Project Project { get; set; } = new Project();

        public static List<Field> ProductionFields = new List<Field>()
        {
            new Field{ Description = "Детали"},
            new Field { Description = "Скорость потребления деталей" },
            new Field { Description = "Количество работников" },
            new Field { Description = "Ритм производства" },
            new Field { Description = "Такт производства" },
        };
        public static List<Ability> Abilities = new List<Ability>()
        {
            new Ability { Name = "Ordering",  Description ="Создание заказов на детали", OutputCount = 3 },
            new Ability { Name = "Forecasting", Description = "Планирование выполнения", OutputCount = 3 }
        };
    }

    public class Field
    {
        public String Description { get; set; }
        public int Value { get; set; } = 0;
    }

    public class Ability
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public int OutputCount { get; set; }
    }
}
