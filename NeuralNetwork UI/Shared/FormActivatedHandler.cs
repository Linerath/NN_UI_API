using Neural_Network.Core.Implementation;
using NeuralNetwork_UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_UI.Shared
{
    static class FormActivatedHandler
    {
        public static ViewSettingsForm SettingsForm { get; set; }

        public static void OnForm_Activated(Form form)
        {
            if (form is LayerForm layerForm)
            {
                SettingsForm.PGLayers.SelectedObject = layerForm.ViewSettings;
            }
        }

        private static void RefreshSettings()
        {
            if (SettingsForm == null)
                return;
        }
        private static void RefreshSettingsForLayer(int fontSize, bool adaptCellSize, int decimalPlaces)
        {
            if (SettingsForm == null)
                return;

            //SettingsForm.PLayersSettings.Visible = true;
            //var dgv = SettingsForm.DGVLayersSettings;

            //dgv.Columns.Clear();
            //dgv.Rows.Clear();
            //dgv.RowCount = 3;

            //DataGridViewCell[] keys = new DataGridViewCell[]
            //{
            //    new DataGridViewCell
            //};

            //dgv.Rows[0].Cells[0].
            //dgv.Columns.AddRange(new DataGridViewColumn[] {
            //    new DataGridViewColumn(),
            //    new DataGridViewColumn(),
            //});

        }
    }
}

/*
    class Setting<TName, TValue, TType> 
        where TType : Type
    {
        private TName Name;
        private TValue Value;
        private TType Type;

        private TValue MinValue;
        private TValue MaxValue;
        private List<TValue> ValuesArray;

        public Setting(TName name, TValue value, TType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }
        public Setting(TName name, TValue value, TType type, TValue minValue, TValue maxValue)
        {
            Name = name;
            Value = value;
            Type = type;
            MinValue = minValue;
            MaxValue = maxValue;
        }
        public Setting(TName name, TValue value, TType type, IEnumerable<TValue> valuesRange)
        {
            Name = name;
            Value = value;
            Type = type;
            ValuesArray = valuesRange.ToList();
        }
    }
}

settings = new List<Setting<string, object, Type>>
                {
                    new Setting<string, object, Type>("Font size", inputLayerForm.FontSize, typeof(int), 17, 35),
                    new Setting<string, object, Type>("Adapt cells size", inputLayerForm.AdaptCellsSize, typeof(bool)),
                    new Setting<string, object, Type>("Decimal places", inputLayerForm.DecimalPlaces, typeof(decimal), 0, 9),
                    //new Setting<string, object, Type>("Followed form", inputLayerForm.FollowedForm, typeof(Form), {  }),
                };
 */
