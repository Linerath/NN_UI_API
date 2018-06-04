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

        public static Dictionary<String, int> ProductionFields = new Dictionary<string, int>()
        {
            { "Детали", 0 },
            { "Скорость потребления деталей", 0 },
            { "Количество работников", 0 },
            { "Ритм производства", 0 },
            { "Такт производства", 0 },

        };
        public static List<String> Abilities = new List<string>()
        {
            { "Создание заказов на детали" },
            { "Планирование выполнения" },
        };
    }
}
