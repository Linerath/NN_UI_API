using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
using Neural_Network.UI.Forms.Dialogs;
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
    public partial class ProductionForm : Form
    {
        public Production Production { get; private set; }
        private NetworkFunction? selectedNetworkSection;
        private bool readFields = false;
        private double[] commonInput;

        private List<NumericUpDown> fieldsCtrls = new List<NumericUpDown>();
        private List<Panel> sectionsCtrls = new List<Panel>();
        private List<Label> sectionLabelsCtrls = new List<Label>();

        public ProductionForm(Production production)
        {
            InitializeComponent();

            Production = production;
            commonInput = new double[Production.Input.Length];
            foreach (var p in GBBody.Controls.OfType<Panel>())
                sectionsCtrls.Add(p);
        }

        #region Events
        private void ProductionForm_Load(object sender, EventArgs e)
        {
            LoadFields();
            LoadSections();
            LoadRandomSectionPanel();

            MinimumSize = Size;
            readFields = true;
        }
        private void NUDField_ValueChanged(object sender, EventArgs e)
        {
            if (readFields)
                RefreshCommonInput();
        }
        private void LSection_Click(object sender, EventArgs e)
        {
            if (selectedNetworkSection == null)
                return;

            Label section = sender as Label;
            if (section == null)
                return;

            for (int i = 0; i < sectionLabelsCtrls.Count(); i++)
            {
                if (section == sectionLabelsCtrls[i])
                {
                    var func = section.Tag as NetworkFunction?;
                    if (func.HasValue)
                        TrySelect(func.Value);
                    LoadPanel();
                    break;
                }
            }
        }

        private void BTraining_Click(object sender, EventArgs e)
        {
            var owner = Owner as MainMenuForm;
            foreach (var proj in Production.InputProjects)
                owner?.ShowTrainingForm(proj.Network, LoadRandomSectionPanel);
        }

        private void BEvaluateCompleting_Click(object sender, EventArgs e)
        {
            double[] additionalInput = new double[]
            {
                (double)NUDSupposedCount0.Value,
                (double)NUDSupposedTime0.Value,
            };

            NeuralNetworkInputProject inputProj = null;
            try
            {
                inputProj = Production.InputProjects[Production.NetworksOutputs.FindIndex(x => x.NetworkFunction == NetworkFunction.AssessmentOfCompleting)];
                if (inputProj == null)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error");
                return;
            }
            var output = Production.GetOutput(inputProj, commonInput, additionalInput);
            try
            {
                var chance = Math.Round(output[0] * 100, 0);
                LCompletingChance1.Text = chance.ToString() + "%";
                if (chance < 30)
                    LCompletingChance1.ForeColor = Color.Red;
                else if (chance >= 30 && chance < 70)
                    LCompletingChance1.ForeColor = Color.Orange;
                else if (chance >= 70)
                    LCompletingChance1.ForeColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error");
                return;
            }
        }
        private void BEvaluateSale_Click(object sender, EventArgs e)
        {
            double[] additionalInput = new double[]
            {
                (double)NUDSupposedCount1.Value,
                (double)NUDSupposedTime1.Value,
            };

            NeuralNetworkInputProject inputProj = null;
            try
            {
                inputProj = Production.InputProjects[Production.NetworksOutputs.FindIndex(x => x.NetworkFunction == NetworkFunction.SaleChance)];
                if (inputProj == null)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error");
                return;
            }
            var output = Production.GetOutput(inputProj, commonInput, additionalInput);
            try
            {
                LSaleChance1.Text = output[0].ToString();
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error");
                return;
            }
        }
        private void BEvaluateFailure_Click(object sender, EventArgs e)
        {
            NeuralNetworkInputProject inputProj = null;
            try
            {
                inputProj = Production.InputProjects[Production.NetworksOutputs.FindIndex(x => x.NetworkFunction == NetworkFunction.FailureChance)];
                if (inputProj == null)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error");
                return;
            }
            var output = Production.GetOutput(inputProj, commonInput);
            try
            {
                LFailureChance1.Text = output[0].ToString();
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error");
                return;
            }
        }
        private void ProductionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        #endregion

        #region Methods
        private void LoadFields()
        {
            NumericUpDown CreateField(double value, double minimum, double maximum, Point location)
            {
                NumericUpDown nud = new NumericUpDown
                {
                    Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = location,
                    Margin = new Padding(3, 2, 3, 2),
                    Size = new Size(100, 23),
                    Value = (decimal)value,
                    Minimum = (decimal)minimum,
                    Maximum = (decimal)maximum,
                    DecimalPlaces = 2,
                };
                nud.ValueChanged += NUDField_ValueChanged;
                return nud;
            };
            Label CreateFieldLabel(String text, Point location)
            {
                return new Label
                {
                    AutoSize = true,
                    Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = location,
                    Size = new Size(18, 20),
                    Text = text,
                };
            };

            if (Production.InputProjects.Count() > 0)
            {
                NUDField0.Value = (decimal)Production.Input[0];
                commonInput[0] = Production.Input[0];
                LField0.Text = Production.InputProjects[0].InputLayerFields[0].Description;
                fieldsCtrls.Add(NUDField0);

                Label prevLabel = LField0;
                for (int i = 1; i < Production.InputProjects[0].InputFieldsCount; i++)
                {
                    var location = new Point(fieldsCtrls.Last().Location.X, fieldsCtrls.Last().Location.Y + fieldsCtrls.Last().Size.Height + 4);
                    var labelLocation = new Point(prevLabel.Location.X, prevLabel.Location.Y + prevLabel.Height + 10);
                    NumericUpDown field = CreateField(Production.Input[i], Production.InputProjects[0].InputLayerFields[i].MinValue, Production.InputProjects[0].InputLayerFields[i].MaxValue, location);
                    commonInput[i] = Production.Input[i];
                    Label label = CreateFieldLabel(Production.InputProjects[0].InputLayerFields[i].Description, labelLocation);
                    prevLabel = label;

                    fieldsCtrls.Add(field);
                    GBFields.Controls.Add(field);
                    GBFields.Controls.Add(label);
                }
            }
        }
        private void LoadSections()
        {
            sectionLabelsCtrls.Add(null);
            Label CreateLabel(String text, Point location, object tag)
            {
                var label = new Label
                {
                    BackColor = SystemColors.Control,
                    Location = location,
                    Text = text,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Top,
                    Tag = tag
                };
                label.Click += LSection_Click;
                return label;
            };

            if (Production.NetworksOutputs.Count() > 0)
            {
                LFunction0.Text = Production.NetworksOutputs[0].Description;
                LFunction0.Tag = Production.NetworksOutputs[0].NetworkFunction;
                sectionLabelsCtrls.Add(LFunction0);

                Label prevSection = LFunction0;
                for (int i = 1; i < Production.NetworksOutputs.Count(); i++)
                {
                    var location = new Point(prevSection.Location.X, prevSection.Location.Y + prevSection.Height);
                    Label section = CreateLabel(Production.NetworksOutputs[i].Description, location, Production.NetworksOutputs[i].NetworkFunction);
                    prevSection = section;

                    sectionLabelsCtrls.Add(section);
                    GBSections.Controls.Add(section);
                }
            }
        }
        public bool TrySelect(NetworkFunction? networkFunction, bool assignNotSelected = false)
        {
            if (networkFunction == null)
            {
                if (assignNotSelected)
                    selectedNetworkSection = null;
                return false;
            }
            for (int i = 0; i < Production.InputProjects.Count(); i++)
            {
                if (Production.NetworksOutputs[i].NetworkFunction == networkFunction)
                {
                    if (Production.InputProjects[i].Network.LearningEpochs >= 1000)
                    {
                        selectedNetworkSection = networkFunction;
                        return true;
                    }
                    else
                    {
                        if (assignNotSelected)
                            selectedNetworkSection = null;
                        return false;
                    }
                }
            }
            selectedNetworkSection = null;
            return false;
        }
        private void LoadPanel()
        {
            for (int i = 0; i < sectionsCtrls.Count(); i++)
            {
                bool curr = false;
                switch (selectedNetworkSection)
                {
                    case NetworkFunction.FailureChance:
                        if (sectionsCtrls[i] == PFailureChance)
                            curr = true;
                        break;
                    case NetworkFunction.AssessmentOfCompleting:
                        if (sectionsCtrls[i] == PAssessmentOfCompleting)
                            curr = true;
                        break;
                    case NetworkFunction.SaleChance:
                        if (sectionsCtrls[i] == PSaleChance)
                            curr = true;
                        break;
                    case null:
                        if (sectionsCtrls[i] == PNotTrained)
                            curr = true;
                        break;
                }
                if (curr)
                {
                    sectionsCtrls[i].Visible = true;
                    sectionsCtrls[i].Dock = DockStyle.Fill;
                    if (sectionLabelsCtrls[i] != null)
                        sectionLabelsCtrls[i].BackColor = Color.Orange;
                }
                else
                {
                    sectionsCtrls[i].Visible = false;
                    if (i < sectionLabelsCtrls.Count() && sectionLabelsCtrls[i] != null)
                        sectionLabelsCtrls[i].BackColor = SystemColors.Control;
                }
            }
        }
        private void LoadRandomSectionPanel()
        {
            if (TrySelect(NetworkFunction.AssessmentOfCompleting) ||
                TrySelect(NetworkFunction.FailureChance) ||
                TrySelect(NetworkFunction.SaleChance, true))
                LoadPanel();
            else
                LoadPanel();
        }

        private void RefreshCommonInput()
        {
            for (int i = 0; i < commonInput.Length; i++)
                commonInput[i] = (double)fieldsCtrls[i].Value;
        }
        #endregion
    }
}