using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
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
    public partial class NewProductionProjectForm : Form
    {
        private List<Shared.Field> fields = new List<Shared.Field>();
        private List<Ability> abilities = new List<Ability>();
        private List<CheckBox> fieldsCtrls = new List<CheckBox>();
        private List<CheckBox> abilitiesCtrls = new List<CheckBox>();

        public NewProductionProjectForm()
        {
            InitializeComponent();

            fields = UIRepository.ProductionFields;
            abilities = UIRepository.Abilities;
        }

        #region Events
        private void NewProductionProjectForm_Load(object sender, EventArgs e)
        {
            LoadFields();

            if (GBFields.Height >= GBAbilities.Height)
                ClientSize = new Size(ClientSize.Width, GBFields.Height + 38);
            else
                ClientSize = new Size(ClientSize.Width, GBAbilities.Height + 76);
            MinimumSize = Size;
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            String name = TBName.Text.Trim();
            if (name == String.Empty)
            {
                MessageBox.Show("Invalid name.", "Error");
                TBName.Focus();
                return;
            }

            for (int i = 0; i < fieldsCtrls.Count(); i++)
            {
                if (!fieldsCtrls[i].Checked)
                    fields.RemoveAt(i--);
            }

            for (int i = 0; i < abilitiesCtrls.Count(); i++)
            {
                if (!abilitiesCtrls[i].Checked)
                    abilities.RemoveAt(i--);
            }

            List<NeuralNetworkInputProject> inputProjects = new List<NeuralNetworkInputProject>();
            List<FeedforwardNetworkSHL> networks = new List<FeedforwardNetworkSHL>();
            for (int i = 0; i < abilities.Count(); i++)
            {
                var network = new FeedforwardNetworkSHL(
                    name + "_" + abilities[i].Name,
                    fields.Count(),
                    fields.Count() * 2,
                    abilities[i].OutputCount,
                    Core.Functions.Sigmoid, 0.05);
                network.SetAllRandomWeights();

                var inputProj = new NeuralNetworkInputProject(name + "_" + abilities[i].Name, network);
                for (int j = 0; j < network.InputLayerSize; j++)
                    inputProj.CreateField(Layers.Input, fields[j].Name, fields[j].Description, network[Layers.Input][j]);

                networks.Add(network);
                inputProjects.Add(inputProj);
                UIRepository.Project.Networks.Add(network);
                UIRepository.Project.InputProjects.Add(inputProj);
            }

            var owner = Owner as MainMenuForm;
            var production = new Production
            {
                Name = name,
                InputProjects = inputProjects,
                InputValues = fields.Select(x => x.Value).ToArray(),
            };
            UIRepository.Project.ProductionProjects.Add(production);

            foreach (var n in networks)
                owner?.ShowNetwork(n);
            owner?.ShowProductionForm(production);

            Close();
        }
        #endregion

        #region Methods
        private void LoadFields()
        {
            CheckBox CreateCheckBox(String text, Point location)
            {
                return new CheckBox
                {
                    AutoSize = true,
                    Checked = true,
                    CheckState = CheckState.Checked,
                    Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = location,
                    Size = new Size(40, 24),
                    Text = text,
                    UseVisualStyleBackColor = true
                };
            };

            if (fields.Count() > 0)
            {
                CBFirstField.Text = fields.First().Description;
                fieldsCtrls.Add(CBFirstField);
            }
            bool pass = true;
            foreach (var f in fields)
            {
                if (pass)
                {
                    pass = false;
                    continue;
                }
                var location = new Point(fieldsCtrls.Last().Location.X, fieldsCtrls.Last().Location.Y + fieldsCtrls.Last().Size.Height + 6);
                CheckBox checkBox = CreateCheckBox(f.Description, location);

                fieldsCtrls.Add(checkBox);
                GBFields.Controls.Add(checkBox);
            }
            if (abilities.Count() > 0)
            {
                CBFirstAbility.Text = abilities.First().Description;
                abilitiesCtrls.Add(CBFirstAbility);
            }
            pass = true;
            foreach (var a in abilities)
            {
                if (pass)
                {
                    pass = false;
                    continue;
                }
                var location = new Point(abilitiesCtrls.Last().Location.X, abilitiesCtrls.Last().Location.Y + abilitiesCtrls.Last().Size.Height + 6);
                CheckBox checkBox = CreateCheckBox(a.Description, location);

                abilitiesCtrls.Add(checkBox);
                GBAbilities.Controls.Add(checkBox);
            }
        }
        #endregion
    }
}
