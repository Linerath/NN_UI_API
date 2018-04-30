using Neural_Network.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_UI.Shared
{
    static class LayersHandler
    {
        public static void RefreshLayerValues(int NetworkIndex, DataGridView dataGridView, Layers layer, int decimalPlaces, bool rewriteValues)
        {
            switch (layer)
            {
                case Layers.Input:
                    dataGridView.RowCount = Project.Networks[NetworkIndex].InputLayerSize;
                    dataGridView.ColumnCount = 1;

                    if (rewriteValues)
                    {
                        for (int i = 0; i < Project.Networks[NetworkIndex].InputLayer.Length; i++)
                            dataGridView[0, i].Value = Project.Networks[NetworkIndex].InputLayer[i][0];
                    }
                    break;
                case Layers.Hidden:
                    dataGridView.RowCount = Project.Networks[NetworkIndex].HiddenLayerSize;
                    dataGridView.ColumnCount = Project.Networks[NetworkIndex].HiddenLayer.Max(x => x.InputCount);

                    if (rewriteValues)
                    {
                        for (int i = 0; i < Project.Networks[NetworkIndex].HiddenLayerSize; i++)
                            for (int j = 0; j < Project.Networks[NetworkIndex].HiddenLayer[i].InputCount; j++)
                                dataGridView[j, i].Value = Math.Round(Project.Networks[NetworkIndex].HiddenLayer[i][j], decimalPlaces);
                    }
                    break;
                case Layers.Output:
                    dataGridView.RowCount = Project.Networks[NetworkIndex].OutputLayerSize;
                    dataGridView.ColumnCount = Project.Networks[NetworkIndex].OutputLayer.Max(x => x.InputCount);

                    if (rewriteValues)
                    {
                        for (int i = 0; i < Project.Networks[NetworkIndex].OutputLayerSize; i++)
                            for (int j = 0; j < Project.Networks[NetworkIndex].OutputLayer[i].InputCount; j++)
                                dataGridView[j, i].Value = Math.Round(Project.Networks[NetworkIndex].OutputLayer[i][j], decimalPlaces);
                    }
                    break;
            }
        }
        public static void RefreshFontSize(DataGridView dataGridView, int fontSize)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.DefaultCellStyle.Font = new Font("Consolas", fontSize, GraphicsUnit.Pixel);
            }
        }
        public static void RefreshCellsAutoSize(DataGridView dataGridView, bool adaptCellsSize)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (adaptCellsSize)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    int oldWidth = col.Width;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Width = oldWidth;
                }
            }
        }

    }
}
