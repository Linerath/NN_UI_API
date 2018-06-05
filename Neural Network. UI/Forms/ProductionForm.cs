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

        private List<NumericUpDown> fieldsCtrls = new List<NumericUpDown>();
        //private List<CheckBox> abilitiesCtrls = new List<CheckBox>();

        public ProductionForm(Production production)
        {
            InitializeComponent();

            Production = production;
        }

        #region Events
        private void ProductionForm_Load(object sender, EventArgs e)
        {
            LoadFields();

            MinimumSize = Size;
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
                for (int i = 0; i < Production.InputProjects[0].InputFieldsCount; i++)
                {
                    if (i == 0) continue;
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