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

        public ProductionForm(Production production)
        {
            InitializeComponent();

            Production = production;
        }

        #region Events
        private void ProductionForm_Load(object sender, EventArgs e)
        {
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

            /*
            if (Production.InputProjects.Count() > 0)
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
            */
        }
        #endregion
    }
}