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

        private List<NumericUpDown> fieldsCtrls = new List<NumericUpDown>();
        private List<Panel> sectionsCtrls = new List<Panel>();
        private List<Label> sectionLabelsCtrls = new List<Label>();

        public ProductionForm(Production production)
        {
            InitializeComponent();

            Production = production;
            foreach (var p in GBBody.Controls.OfType<Panel>())
                sectionsCtrls.Add(p);
        }

        #region Events
        private void ProductionForm_Load(object sender, EventArgs e)
        {
            LoadFields();
            LoadSections();
            CheckEpochs();

            MinimumSize = Size;
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
                    selectedNetworkSection = section.Tag as NetworkFunction?;
                    LoadPanel();
                    break;
                }
            }
        }

        private void BTraining_Click(object sender, EventArgs e)
        {
            var owner = Owner as MainMenuForm;
            foreach (var proj in Production.InputProjects)
                owner?.ShowTrainingForm(proj.Network);
        }
        #endregion

        #region Methods
        private void LoadFields()
        {
            NumericUpDown CreateField(double value, Point location)
            {
                return new NumericUpDown
                {
                    Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = location,
                    Margin = new Padding(3, 2, 3, 2),
                    Maximum = new decimal(new int[] { 1000000, 0, 0, 0 }),
                    Size = new Size(79, 23),
                    Value = (decimal)value,
                };
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
                NUDField0.Value = (decimal)Production.InputProjects[0].InputLayerFields[0].Value;
                LField0.Text = Production.InputProjects[0].InputLayerFields[0].Description;
                fieldsCtrls.Add(NUDField0);

                Label prevLabel = LField0;
                for (int i = 1; i < Production.InputProjects[0].InputFieldsCount; i++)
                {
                    var location = new Point(fieldsCtrls.Last().Location.X, fieldsCtrls.Last().Location.Y + fieldsCtrls.Last().Size.Height + 4);
                    var labelLocation = new Point(prevLabel.Location.X, prevLabel.Location.Y + prevLabel.Height + 10);
                    NumericUpDown field = CreateField(Production.InputProjects[0].InputLayerFields[i].Value, location);
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
        private void CheckEpochs()
        {
            List<FeedforwardNetworkSHL> notTrainedNets = new List<FeedforwardNetworkSHL>();
            for (int i = 0; i < Production.InputProjects.Count(); i++)
            {
                if (Production.InputProjects[i].Network.LearningEpochs < 1000)
                    notTrainedNets.Add(Production.InputProjects[i].Network);
            }
            if (notTrainedNets.Count() > 0)
                selectedNetworkSection = null;
            else
                selectedNetworkSection = NetworkFunction.FailureChance;
            LoadPanel();
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
                    if (sectionLabelsCtrls[i] != null)
                        sectionLabelsCtrls[i].BackColor = SystemColors.Control;
                }
            }
        }
        #endregion
    }
}