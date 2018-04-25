using Neural_Network.Core.Implementation;
using Neural_Network_WF__Graduate_Work_.Networks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network_WF__Graduate_Work_.Forms
{
    public partial class NetworkViewForm : Form
    {
        public NetworkViewForm()
        {
            InitializeComponent();
        }

        #region Events
        private void NetworkViewForm_Load(object sender, EventArgs e)
        {
            UpdateNetwork(true);
        }
        private void DGVHiddenLayer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateNetwork();
        }
        private void DGVOutputLayer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateNetwork();
        }
        private void NUDHiddenDecimalPlaces_ValueChanged(object sender, EventArgs e)
        {
            if (CBSync0.Checked)
            {
                NUDOutputDecimalPlaces.Value = NUDHiddenDecimalPlaces.Value;
            }
            UpdateNetwork();
        }
        private void NUDOutputDecimalPlaces_ValueChanged(object sender, EventArgs e)
        {
            if (CBSync0.Checked)
            {
                NUDHiddenDecimalPlaces.Value = NUDOutputDecimalPlaces.Value;
            }
            UpdateNetwork();
        }
        private void NUDInputFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (CBSync1.Checked)
            {
                NUDHiddenFontSize.Value = NUDInputFontSize.Value;
                NUDOutputFontSize.Value = NUDInputFontSize.Value;
            }
            UpdateNetwork();
        }
        private void NUDHiddenFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (CBSync1.Checked)
            {
                NUDInputFontSize.Value = NUDHiddenFontSize.Value;
                NUDOutputFontSize.Value = NUDHiddenFontSize.Value;
            }
            UpdateNetwork();
        }
        private void NUDOutputFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (CBSync1.Checked)
            {
                NUDInputFontSize.Value = NUDOutputFontSize.Value;
                NUDHiddenFontSize.Value = NUDOutputFontSize.Value;
            }
            UpdateNetwork();
        }
        private void CBHiddenAdaptCellSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellsAutoSize(DGVHiddenLayer, CBHiddenAdaptCellSize.Checked);
        }
        private void CBOutputAdaptCellSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellsAutoSize(DGVOutputLayer, CBOutputAdaptCellSize.Checked);
        }
        private void BDrawScheme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development.", "Sorry");
        }
        private void BDefaultSettings_Click(object sender, EventArgs e)
        {
            CBSync0.Checked = true;
            CBSync1.Checked = true;
            NUDHiddenDecimalPlaces.Value = 3;
            NUDInputFontSize.Value = 17;
            CBHiddenAdaptCellSize.Checked = true;
            CBOutputAdaptCellSize.Checked = true;
        }
        private void BBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Methods
        private void UpdateNetwork(bool rewriteValues = false)
        {
            int count0 = (int)NUDHiddenDecimalPlaces.Value;
            int count1 = (int)NUDOutputDecimalPlaces.Value;
            void UpdateFont()
            {
                foreach (DataGridViewColumn col in DGVInputLayer.Columns)
                {
                    col.DefaultCellStyle.Font = new Font("Consolas", (int)NUDInputFontSize.Value, GraphicsUnit.Pixel);
                }
                foreach (DataGridViewColumn col in DGVHiddenLayer.Columns)
                {
                    col.DefaultCellStyle.Font = new Font("Consolas", (int)NUDHiddenFontSize.Value, GraphicsUnit.Pixel);
                }
                foreach (DataGridViewColumn col in DGVOutputLayer.Columns)
                {
                    col.DefaultCellStyle.Font = new Font("Consolas", (int)NUDOutputFontSize.Value, GraphicsUnit.Pixel);
                }
            }
            void FillValues()
            {
                for (int i = 0; i < NeuralNetwork.Network[0].Count(); i++)
                    DGVInputLayer[0, i].Value = NeuralNetwork.Network[0][i][0];
                for (int i = 0; i < NeuralNetwork.Network[1].Count(); i++)
                    for (int j = 0; j < NeuralNetwork.Network[1][i].InputCount; j++)
                        DGVHiddenLayer[j, i].Value = Math.Round(NeuralNetwork.Network[1][i][j], count0).ToString();
                for (int i = 0; i < NeuralNetwork.Network[2].Count(); i++)
                    for (int j = 0; j < NeuralNetwork.Network[2][i].InputCount; j++)
                        DGVOutputLayer[j, i].Value = Math.Round(NeuralNetwork.Network[2][i][j], count1).ToString();
            }

            DGVInputLayer.RowCount = NeuralNetwork.Network.InputLayerSize;

            DGVHiddenLayer.RowCount = NeuralNetwork.Network.HiddenLayerSize;
            DGVHiddenLayer.ColumnCount = NeuralNetwork.Network[1].Max(x => x.InputCount);

            DGVOutputLayer.RowCount = NeuralNetwork.Network.OutputLayerSize;
            DGVOutputLayer.ColumnCount = NeuralNetwork.Network[2].Max(x => x.InputCount);

            UpdateFont();
            UpdateCellsAutoSize(DGVHiddenLayer, CBHiddenAdaptCellSize.Checked);
            UpdateCellsAutoSize(DGVOutputLayer, CBOutputAdaptCellSize.Checked);
            if (rewriteValues)
                FillValues();
        }
        private void UpdateCellsAutoSize(DataGridView dataGridView, bool adapt)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (adapt)
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
        #endregion
    }
}