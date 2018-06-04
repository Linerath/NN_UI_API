using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
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
        public FeedforwardNetworkSHL Network { get; set; }
        public TableViewSettings ViewSettings { get; private set; }
        private String FilePath { get; set; } = null;

        public TrainingForm(FeedforwardNetworkSHL network)
        {
            inputSignals = new List<double[]>();
            correctOutputSignals = new List<double[]>();
            Network = network;
            ViewSettings = new TableViewSettings()
            {
                NeuronsSorting = NeuronsSorting.Vertical,
            };

            InitializeComponent();
        }

        #region Events
        private void TrainingForm_Load(object sender, EventArgs e)
        {
            LCreationDate0.Text += "\n" + Network.CreationDate.ToString();
            LLearningEpochs1.Text = Network.LearningEpochs.ToString();
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
        private void NFBSave_Click(object sender, EventArgs e)
        {
            if (FilePath != null)
            {
                if (!TrySave())
                    MessageBox.Show("Training data was not saved.", "Error");
            }
            else
            {
                SaveAs();
            }
        }
        private void NFBSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void NFBRandomize0_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < inputSignals.Count(); i++)
                for (int j = 0; j < inputSignals[i].Length; j++)
                    inputSignals[i][j] = GetRandomValue(random, FeedforwardNetworkSHL.RANDOM_MIN_VALUE, FeedforwardNetworkSHL.RANDOM_MAX_VALUE);
            RefreshSignals();
        }
        private void NFBRandomize1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < correctOutputSignals.Count(); i++)
                for (int j = 0; j < correctOutputSignals[i].Length; j++)
                    correctOutputSignals[i][j] = GetRandomValue(random, FeedforwardNetworkSHL.RANDOM_MIN_VALUE, FeedforwardNetworkSHL.RANDOM_MAX_VALUE);
            RefreshSignals();
        }
        private void NFBAdd_Click(object sender, EventArgs e)
        {
            inputSignals.Add(new double[Network.InputLayerSize]);
            correctOutputSignals.Add(new double[Network.OutputLayerSize]);
            FullTablesRefresh();
        }
        private void NFBRemove_Click(object sender, EventArgs e)
        {
            if (inputSignals.Count() < 2) return;
            inputSignals.RemoveAt(inputSignals.Count() - 1);
            correctOutputSignals.RemoveAt(correctOutputSignals.Count() - 1);
            FullTablesRefresh();
        }
        private void BLearn_Click(object sender, EventArgs e)
        {
            double learningRate = (double)NUDLearningRate.Value;
            int epochs = (int)NUDEpochs.Value;
            bool randomize = CBRandomize.Checked;

            PBLearningProgress.Maximum = epochs - 1;
            NeuralNetworkService.TrainNetwork(
                Network,
                inputSignals, correctOutputSignals,
                epochs,
                learningRate,
                randomize,
                out double startError, out double endError,
                x => PBLearningProgress.Value = x);

            LStartError1.Text = Math.Round(startError, 4).ToString();
            LEndError1.Text = Math.Round(endError, 4).ToString();

            LCompleted1.Text = epochs.ToString();
            LLearningEpochs1.Text = Network.LearningEpochs.ToString();
            GlobalNetworkRefresh();
        }
        #endregion

        #region Methods
        private void RefreshSignals()
        {
            if (inputSignals.Count() < 1)
            {
                inputSignals.Add(new double[Network.InputLayerSize]);
                correctOutputSignals.Add(new double[Network.OutputLayerSize]);
            }

            if (ViewSettings.NeuronsSorting == NeuronsSorting.Horizontal)
            {
                DGVInputSignals.RowCount = inputSignals.Count();
                DGVInputSignals.ColumnCount = Network.InputLayerSize;
                DGVCorrectOutputSignals.RowCount = correctOutputSignals.Count();
                DGVCorrectOutputSignals.ColumnCount = Network.OutputLayerSize;

                for (int i = 0; i < inputSignals.Count(); i++)
                    for (int j = 0; j < inputSignals[i].Length; j++)
                        DGVInputSignals[j, i].Value = Math.Round(inputSignals[i][j], ViewSettings.DecimalPlaces).ToString();
                for (int i = 0; i < correctOutputSignals.Count(); i++)
                    for (int j = 0; j < correctOutputSignals[i].Length; j++)
                        DGVCorrectOutputSignals[j, i].Value = Math.Round(correctOutputSignals[i][j], ViewSettings.DecimalPlaces).ToString();
            }
            else
            {
                DGVInputSignals.RowCount = Network.InputLayerSize;
                DGVInputSignals.ColumnCount = inputSignals.Count();
                DGVCorrectOutputSignals.RowCount = Network.OutputLayerSize;
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
            List<double[]> tempInput = new List<double[]>();
            List<double[]> tempOutput = new List<double[]>();

            while ((startIndex = text.IndexOf('{')) >= 0 && (endIndex = text.IndexOf('}')) >= 0)
            {
                if (startIndex >= endIndex)
                {
                    MessageBox.Show("Incorrect file format.", "Error");
                    return false;
                }
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
                if (input.Length != Network.InputLayerSize)
                    Array.Resize(ref input, Network.InputLayerSize);

                if (output.Length != Network.OutputLayerSize)
                    Array.Resize(ref output, Network.OutputLayerSize);

                tempInput.Add(input);
                tempOutput.Add(output);
                count++;

                text = text.Remove(startIndex, endIndex - startIndex + 1);
            }
            if (count < 1)
            {
                MessageBox.Show("Incorrect file format.", "Error");
                return false;
            }
            inputSignals = tempInput;
            correctOutputSignals = tempOutput;
            return true;
        }

        public void FullTablesRefresh()
        {
            RefreshSignals();
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

        private void GlobalNetworkRefresh()
        {
            var owner = Owner as MainMenuForm;
            owner?.RefreshNetwork(Network);
        }

        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = "*.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TrySaveTo(sfd.FileName);
            }
        }
        private bool TrySave()
        {
            if (FilePath != null)
            {
                return TrySaveTo(FilePath);
            }
            return false;
        }
        private bool TrySaveTo(String filePath)
        {
            StreamWriter streamWriter;

            using (streamWriter = new StreamWriter(filePath))
            {
                for (int i = 0; i < inputSignals.Count(); i++)
                {
                    streamWriter.Write("{");
                    for (int j = 0; j < inputSignals[i].Length; j++)
                    {
                        if (j != inputSignals[i].Length - 1)
                            streamWriter.Write(inputSignals[i][j] + ",");
                        else
                            streamWriter.Write(inputSignals[i][j]);
                    }
                    streamWriter.Write(":");
                    for (int j = 0; j < correctOutputSignals[i].Length; j++)
                    {
                        if (j != correctOutputSignals[i].Length - 1)
                            streamWriter.Write(correctOutputSignals[i][j] + ",");
                        else
                            streamWriter.Write(correctOutputSignals[i][j]);
                    }
                    streamWriter.Write("}");
                }
            }

            FilePath = filePath;
            return true;
        }

        private double GetRandomValue(Random random, double minValue, double maxValue)
        {
            return (random.NextDouble() * (maxValue - minValue) + minValue);
        }
        #endregion
    }
}