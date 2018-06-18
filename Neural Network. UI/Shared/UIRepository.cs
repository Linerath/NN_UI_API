using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Shared
{
    public static class UIRepository
    {
        public static Project Project { get; set; } = new Project();

        public static List<Field> ProductionFields;
        public static List<NetworkOutput> Abilities = new List<NetworkOutput>()
        {
            new NetworkOutput { NetworkFunction = NetworkFunction.FailureChance, Description = "Вероятность сбоя", OutputCount = 1 },
            new NetworkOutput { NetworkFunction = NetworkFunction.AssessmentOfCompleting, Description = "Оценка реальности выполнения плана", OutputCount = 1 },
            new NetworkOutput { NetworkFunction = NetworkFunction.SaleChance, Description = "Оценка реальности сбыта продукции", OutputCount = 1 },
        };

        private static String inputFieldsFile = "input_fields.txt";

        static UIRepository()
        {
            ReadProductionFields();
        }

        public static void ReadProductionFields()
        {
            if (!File.Exists(inputFieldsFile))
            {
                MessageBox.Show("File 'input_fields.txt' not found.", "Error");
                return;
            }

            String text = File.ReadAllText(inputFieldsFile);
            text = text.Trim();

            int startIndex, endIndex;

            List<Field> tempFields = new List<Field>();
            Field field;

            while ((startIndex = text.IndexOf('{')) >= 0 && (endIndex = text.IndexOf('}')) >= 0)
            {
                if (startIndex >= endIndex)
                {
                    MessageBox.Show("Incorrect file format.", "Error");
                    return;
                }
                var example = text.Substring(startIndex + 1, endIndex - startIndex - 1);
                //example = Regex.Replace(example, @"\s+", "");
                if (!example.Contains(','))
                {
                    MessageBox.Show("Incorrect file format.", "Error");
                    return;
                }

                var exampleTemp = example.Split(',');
                try
                {
                    field = new Field
                    {
                        Name = exampleTemp[0].Trim(),
                        Description = exampleTemp[1].Trim(),
                        MinValue = Double.Parse(exampleTemp[2]),
                        MaxValue = Double.Parse(exampleTemp[3]),
                        Value = Double.Parse(exampleTemp[4]),
                    };
                }
                catch (FormatException e)
                {
                    MessageBox.Show("Incorrect file format. " + e.Message, "Error");
                    return;
                }

                tempFields.Add(field);

                text = text.Remove(startIndex, endIndex - startIndex + 1);
            }
            ProductionFields = tempFields;
        }
    }

    public class Field
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public double Value { get; set; } = 0;
        public double MinValue { get; set; } = 0;
        public double MaxValue { get; set; } = 1;
    }
}