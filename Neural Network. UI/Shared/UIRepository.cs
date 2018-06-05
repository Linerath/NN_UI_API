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
            new Field { Name = "Details", Description = "Детали", Value = 1337 },
            new Field { Name = "Speed", Description = "Скорость потребления деталей" },
            new Field { Name = "Employees", Description = "Количество работников", Value = 15 },
            new Field { Name = "Rhythm", Description = "Ритм производства" },
            new Field { Name = "Tact", Description = "Такт производства", Value = 228 },
        };
        public static List<Ability> Abilities = new List<Ability>()
        {
            new Ability { Name = "Forecasting", Description = "Оценка реальности выполнения", OutputCount = 3 },
            new Ability { Name = "Ordering",  Description ="Создание заказов на детали", OutputCount = 3 },
        };
    }

    public class Field
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public double Value { get; set; } = 0;
    }

    public class Ability
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public int OutputCount { get; set; }
    }
}
