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
        public static void RefreshLayerValues(DataGridView dataGridView, Layers layer, int decimalPlaces, bool rewriteValues)
        {
            switch (layer)
            {
                case Layers.Input:
                    dataGridView.RowCount = NeuralNetwork.Network.InputLayerSize;
                    dataGridView.ColumnCount = 1;

                    if (rewriteValues)
                    {
                        for (int i = 0; i < NeuralNetwork.Network.InputLayer.Length; i++)
                            dataGridView[0, i].Value = NeuralNetwork.Network.InputLayer[i][0];
                    }
                    break;
                case Layers.Hidden:
                    dataGridView.RowCount = NeuralNetwork.Network.HiddenLayerSize;
                    dataGridView.ColumnCount = NeuralNetwork.Network.HiddenLayer.Max(x => x.InputCount);

                    if (rewriteValues)
                    {
                        for (int i = 0; i < NeuralNetwork.Network.HiddenLayerSize; i++)
                            for (int j = 0; j < NeuralNetwork.Network.HiddenLayer[i].InputCount; j++)
                                dataGridView[j, i].Value = Math.Round(NeuralNetwork.Network.HiddenLayer[i][j], decimalPlaces);
                    }
                    break;
                case Layers.Output:
                    dataGridView.RowCount = NeuralNetwork.Network.OutputLayerSize;
                    dataGridView.ColumnCount = NeuralNetwork.Network.OutputLayer.Max(x => x.InputCount);

                    if (rewriteValues)
                    {
                        for (int i = 0; i < NeuralNetwork.Network.OutputLayerSize; i++)
                            for (int j = 0; j < NeuralNetwork.Network.OutputLayer[i].InputCount; j++)
                                dataGridView[j, i].Value = Math.Round(NeuralNetwork.Network.OutputLayer[i][j], decimalPlaces);
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
