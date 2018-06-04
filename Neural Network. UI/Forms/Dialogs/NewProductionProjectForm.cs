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
        private Dictionary<String, int> fields = new Dictionary<string, int>();
        private List<Ability> abilities = new List<Ability>();
        private List<CheckBox> fieldsCtrls = new List<CheckBox>();
        private List<CheckBox> abilitiesCtrls = new List<CheckBox>();

        public NewProductionProjectForm()
        {
            InitializeComponent();

            fields = UIRepository.ProductionFields;
            abilities = UIRepository.Abilities;
        }

        private void NewProductionProjectForm_Load(object sender, EventArgs e)
        {
            if (fields.Count() > 0)
            {
                CBFirstField.Text = fields.First().Key;
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
                CheckBox checkBox = new CheckBox()
                {
                    AutoSize = true,
                    Checked = true,
                    CheckState = CheckState.Checked,
                    Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(fieldsCtrls.Last().Location.X, fieldsCtrls.Last().Location.Y + fieldsCtrls.Last().Size.Height + 6),
                    Size = new Size(40, 24),
                    Text = f.Key,
                    UseVisualStyleBackColor = true
                };
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
                CheckBox checkBox = new CheckBox()
                {
                    AutoSize = true,
                    Checked = true,
                    CheckState = CheckState.Checked,
                    Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Location = new Point(abilitiesCtrls.Last().Location.X, abilitiesCtrls.Last().Location.Y + abilitiesCtrls.Last().Size.Height + 6),
                    Size = new Size(40, 24),
                    Text = a.Description,
                    UseVisualStyleBackColor = true
                };
                abilitiesCtrls.Add(checkBox);
                GBAbilities.Controls.Add(checkBox);
            }

            ClientSize = new Size(ClientSize.Width, GBFields.Height + 38);
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
                {
                    fieldsCtrls.RemoveAt(i--);
                    fields.Remove
                }
            }
            for (int i = 0; i < abilitiesCtrls.Count(); i++)
            {
                if (!abilitiesCtrls[i].Checked)
                    abilitiesCtrls.RemoveAt(i--);
            }
            FeedforwardNetworkSHL[] abilities = new FeedforwardNetworkSHL[abilitiesCtrls.Count()];
            for (int i = 0; i < abilities.Length; i++)
            {
                abilities[i] = new FeedforwardNetworkSHL(name + "_" + abilities[i].Name, fieldsCtrls.Count(), fieldsCtrls.Count()*2, abilities[i]);
            }

            //!!!!!!
            int detailsTypesCount = 3;
            //!!!!!!


            if (CBFirstAbility.Checked)
            {
                orderingNetwork = new FeedforwardNetworkSHL(name + "_Ordering", inputCount, inputCount * 2, detailsTypesCount, Core.Functions.Sigmoid, 0.05);
                orderingNetwork.SetAllRandomWeights();
                UIRepository.Project.Networks.Add(orderingNetwork);
            }
            if (CBForecasting.Checked)
            {
                forecastingNetwork = new FeedforwardNetworkSHL(name + "_Forecasting", inputCount, inputCount * 2, 2, Core.Functions.Sigmoid, 0.05);
                forecastingNetwork.SetAllRandomWeights();
                UIRepository.Project.Networks.Add(forecastingNetwork);
            }
            var owner = Owner as MainMenuForm;
            var production = new Production
            {
                Name = name,
                Details = details,
                Speed = speed,
                Employees = employees,
                Rhythm = rhythm,
                Tact = tact,
                OrderingNetwork = orderingNetwork,
                ForecastingNetwork = forecastingNetwork
            };
            UIRepository.Project.ProductionProjects.Add(production);

            if (orderingNetwork != null)
                owner?.ShowNetwork(orderingNetwork);
            if (forecastingNetwork != null)
                owner?.ShowNetwork(forecastingNetwork);
            owner?.ShowProductionForm(production);

            Close();
        }
    }
}
