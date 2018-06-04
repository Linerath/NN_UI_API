using Neural_Network.Core.Implementation;
using Neural_Network.UI.Constants;
using Neural_Network.UI.Constants.Form;
using Neural_Network.UI.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Forms
{
    public partial class NetworkForm : Form
    {
        public FeedforwardNetworkSHL Network { get; private set; }
        public TableViewSettings ViewSettings { get; private set; }

        private DataGridView dgvInput;
        private DataGridView[] dgvHidden;
        private DataGridView dgvOutput;

        public NetworkForm(FeedforwardNetworkSHL network)
        {
            InitializeComponent();

            Network = network;
            ViewSettings = new TableViewSettings();

            LocateTables();
        }

        #region Events
        private void DGVLayer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //double value = Double.Parse(DGVLayer[e.ColumnIndex, e.RowIndex].Value.ToString());
            //UIRepository.Project.Networks[NetworkIndex][layer][e.RowIndex][e.ColumnIndex] = value;
        }
        #endregion

        #region Methods
        private void LocateTables()
        {
            int inputLayerSize = 150;
            int hiddenLayerSize = 300;
            int outputLayerSize = 300;

            Size = new Size(inputLayerSize + hiddenLayerSize + outputLayerSize, 253);

            // Input layer
            dgvInput = CreateDataGridView(inputLayerSize);
            TLPPanel.Controls.Add(dgvInput, 0, 0);
            TLPPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 15F);

            // Hidden layer
            dgvHidden = new DataGridView[1];
            for (int i = 0; i < dgvHidden.Length; i++)
            {
                dgvHidden[i] = CreateDataGridView(hiddenLayerSize);
                TLPPanel.ColumnCount++;
                TLPPanel.Controls.Add(dgvHidden[i], TLPPanel.ColumnCount - 1, 0);
            }

            // Output layer
            dgvOutput = CreateDataGridView(outputLayerSize);
            TLPPanel.ColumnCount++;
            TLPPanel.Controls.Add(dgvOutput, TLPPanel.ColumnCount - 1, 0);

            DataGridView CreateDataGridView(int width)
            {
                return new DataGridView
                {
                    ColumnHeadersVisible = false,
                    RowHeadersVisible = false,
                    AllowUserToAddRows = false,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left,
                    Size = new Size(width, ClientSize.Height),
                };
            }
        }
        public void FullNetworkRefresh()
        {
            RefreshNetworkWeights();
            RefreshFont();
            RefreshCellsAutoSize();
        }
        public void RefreshNetworkWeights()
        {
            if (ViewSettings.NeuronsSorting == NeuronsSorting.Horizontal)
            {
                // Input layer
                dgvInput.RowCount = Network.InputLayerSize;
                dgvInput.ColumnCount = 1;
                for (int i = 0; i < Network.InputLayer.Length; i++)
                    dgvInput[0, i].Value = Network.InputLayer[i][0];

                // Hidden layer
                for (int i = 0; i < dgvHidden.Length; i++)
                {
                    dgvHidden[i].RowCount = Network.HiddenLayerSize;
                    dgvHidden[i].ColumnCount = Network.HiddenLayer.Max(x => x.InputCount);
                    for (int j = 0; j < Network.HiddenLayerSize; j++)
                        for (int k = 0; k < Network.HiddenLayer[j].InputCount; k++)
                            dgvHidden[i][k, j].Value = Math.Round(Network.HiddenLayer[j][k], ViewSettings.DecimalPlaces);
                }

                // Output layer
                dgvOutput.RowCount = Network.OutputLayerSize;
                dgvOutput.ColumnCount = Network.OutputLayer.Max(x => x.InputCount);
                for (int i = 0; i < Network.OutputLayerSize; i++)
                    for (int j = 0; j < Network.OutputLayer[i].InputCount; j++)
                        dgvOutput[j, i].Value = Math.Round(Network.OutputLayer[i][j], ViewSettings.DecimalPlaces);
            }
            else
            {
                // Input layer
                dgvInput.RowCount = 1;
                dgvInput.ColumnCount = Network.InputLayerSize;
                for (int i = 0; i < Network.InputLayer.Length; i++)
                    dgvInput[i, 0].Value = Network.InputLayer[i][0];

                // Hidden layer
                for (int i = 0; i < dgvHidden.Length; i++)
                {
                    dgvHidden[i].RowCount = Network.HiddenLayer.Max(x => x.InputCount);
                    dgvHidden[i].ColumnCount = Network.HiddenLayerSize;
                    for (int j = 0; j < Network.HiddenLayerSize; j++)
                        for (int k = 0; k < Network.HiddenLayer[j].InputCount; k++)
                            dgvHidden[i][j, k].Value = Math.Round(Network.HiddenLayer[j][k], ViewSettings.DecimalPlaces);
                }

                // Output layer
                dgvOutput.RowCount = Network.OutputLayer.Max(x => x.InputCount);
                dgvOutput.ColumnCount = Network.OutputLayerSize;
                for (int i = 0; i < Network.OutputLayerSize; i++)
                    for (int j = 0; j < Network.OutputLayer[i].InputCount; j++)
                        dgvOutput[i, j].Value = Math.Round(Network.OutputLayer[i][j], ViewSettings.DecimalPlaces);
            }
        }
        public void RefreshFont()
        {
            TableHandler.RefreshFont(dgvInput, ViewSettings);
            for (int i = 0; i < dgvHidden.Length; i++)
                TableHandler.RefreshFont(dgvHidden[i], ViewSettings);
            TableHandler.RefreshFont(dgvOutput, ViewSettings);
        }
        public void RefreshCellsAutoSize()
        {
            TableHandler.RefreshCellsAutoSize(dgvInput, ViewSettings);
            for (int i = 0; i < dgvHidden.Length; i++)
                TableHandler.RefreshCellsAutoSize(dgvHidden[i], ViewSettings);
            TableHandler.RefreshCellsAutoSize(dgvOutput, ViewSettings);
        }
        #endregion
    }
}