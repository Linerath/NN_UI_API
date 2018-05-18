using Neural_Network.UI.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Forms
{
    public partial class TrainingForm : Form
    {
        private List<double[]> inputSignals;
        private List<double[]> correctOutputSignals;
        public int NetworkIndex { get; set; }
        public TableViewSettings ViewSettings { get; private set; }


        public TrainingForm(int networkIndex)
        {
            inputSignals = new List<double[]>();
            correctOutputSignals = new List<double[]>();
            this.NetworkIndex = networkIndex;
            ViewSettings = new TableViewSettings();

            InitializeComponent();
        }

        #region Events
        private void TrainingForm_Load(object sender, EventArgs e)
        {
            LCreationDate0.Text += "\n" + UIRepository.Project.Networks[NetworkIndex].CreationDate.ToString();
            LLearningEpochs1.Text = UIRepository.Project.Networks[NetworkIndex].LearningEpochs.ToString();
            MinimumSize = Size;

            FullTablesRefresh();
        }
        private void BSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (TryReadSignals(ofd.FileName))
                    FullTablesRefresh();
            }
        }
        private void NFBAdd_Click(object sender, EventArgs e)
        {

        }
        private void NFBRemove_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods
        private void RefreshSignals(bool rewriteValues = false)
        {
            DGVInputSignals.RowCount = UIRepository.Project.Networks[NetworkIndex].InputLayerSize;
            DGVCorrectOutputSignals.RowCount = UIRepository.Project.Networks[NetworkIndex].OutputLayerSize;

            if (correctOutputSignals.Count() < 1)
            {
                DGVInputSignals.ColumnCount = 1;

                for (int i = 0; i < DGVInputSignals.RowCount; i++)
                    for (int j = 0; j < DGVInputSignals.ColumnCount; j++)
                        DGVInputSignals[j, i].Value = 0;

                DGVCorrectOutputSignals.ColumnCount = 1;

                for (int i = 0; i < DGVCorrectOutputSignals.RowCount; i++)
                    for (int j = 0; j < DGVCorrectOutputSignals.ColumnCount; j++)
                        DGVCorrectOutputSignals[j, i].Value = 0;
            }
            else
            {
                DGVInputSignals.ColumnCount = inputSignals.Count();
                DGVCorrectOutputSignals.ColumnCount = correctOutputSignals.Count();

                for (int i = 0; i < inputSignals.Count(); i++)
                    for (int j = 0; j < inputSignals[i].Length; j++)
                        DGVInputSignals[i, j].Value = Math.Round(inputSignals[i][j], ViewSettings.DecimalPlaces).ToString();
                for (int i = 0; i < correctOutputSignals.Count(); i++)
                    for (int j = 0; j < correctOutputSignals[i].Length; j++)
                        DGVCorrectOutputSignals[i, j].Value = Math.Round(correctOutputSignals[i][j], ViewSettings.DecimalPlaces).ToString();
            }
        }
        private bool TryReadSignals(String filePath)
        {
            if (!File.Exists(filePath))
                return false;

            String text = File.ReadAllText(filePath);
            text = text.Trim();

            int startIndex, endIndex;
            double[] input, output;
            int count = 0;

            while ((startIndex = text.IndexOf('{')) >= 0 && (endIndex = text.IndexOf('}')) >= 0)
            {
                var example = text.Substring(startIndex + 1, endIndex - startIndex - 1);
                if (!example.Contains(':'))
                {
                    MessageBox.Show("Incorrect file format.", "Error");
                    return false;
                }
                var exampleTemp = example.Split(':');
                var inputTemp = exampleTemp[0].Split(',');
                var outputTemp = exampleTemp[1].Split(',');

                try
                {
                    input = Array.ConvertAll(inputTemp, Double.Parse);
                    output = Array.ConvertAll(outputTemp, Double.Parse);
                }
                catch (FormatException e)
                {
                    MessageBox.Show("Incorrect file format. " + e.Message, "Error");
                    return false;
                }
                if (input.Length != UIRepository.Project.Networks[NetworkIndex].InputLayerSize)
                    Array.Resize(ref input, UIRepository.Project.Networks[NetworkIndex].InputLayerSize);

                if (output.Length != UIRepository.Project.Networks[NetworkIndex].OutputLayerSize)
                    Array.Resize(ref output, UIRepository.Project.Networks[NetworkIndex].OutputLayerSize);

                inputSignals.Add(input);
                correctOutputSignals.Add(output);
                count++;

                text = text.Remove(startIndex, endIndex - startIndex + 1);
            }
            if (count < 1)
            {
                MessageBox.Show("Incorrect file format.", "Error");
                return false;
            }
            return true;
        }

        public void FullTablesRefresh()
        {
            RefreshSignals(true);
            RefreshFont();
            RefreshCellsAutoSize();
        }
        private void RefreshFont()
        {
            TableHandler.RefreshFont(DGVInputSignals, ViewSettings);
            TableHandler.RefreshFont(DGVCorrectOutputSignals, ViewSettings);
        }
        public void RefreshCellsAutoSize()
        {
            TableHandler.RefreshCellsAutoSize(DGVInputSignals, ViewSettings);
            TableHandler.RefreshCellsAutoSize(DGVCorrectOutputSignals, ViewSettings);
        }
        #endregion
    }
}