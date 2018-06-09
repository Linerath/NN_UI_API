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
            new Field { Name = "DetailsCount", Description = "Количество деталей на холодильник", Value = 1337 },
            new Field { Name = "Speed", Description = "Скорость потребления деталей" },
            new Field { Name = "Employees", Description = "Количество работников", Value = 15 },
            new Field { Name = "Rhythm", Description = "Ритм производства" },
            new Field { Name = "Tact", Description = "Такт производства", Value = 228 },
            new Field { Name = "DefectPercentage", Description = "Процент брака", Value = 100 },
        };
        public static List<NetworkOutput> Abilities = new List<NetworkOutput>()
        {
            new NetworkOutput { NetworkFunction = NetworkFunction.FailureChance, Description = "Вероятность сбоя", OutputCount = 1 },
            new NetworkOutput { NetworkFunction = NetworkFunction.AssessmentOfCompleting, Description = "Оценка реальности выполнения плана", OutputCount = 1},
            new NetworkOutput { NetworkFunction = NetworkFunction.SaleChance, Description = "Оценка реальности сбыта продукции", OutputCount = 1},
        };
    }

    public class Field
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public double Value { get; set; } = 0;
    }
}