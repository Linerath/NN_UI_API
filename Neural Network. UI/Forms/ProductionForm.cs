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
            if (Production.Details.HasValue)
            {
                NUDDetails.Value = Production.Details.Value;
            }
            else
            {
                NUDDetails.Visible = false;
                LDetails.Visible = false;
            }

            if (Production.Speed.HasValue)
            {
                NUDSpeed.Value = Production.Speed.Value;
            }
            else
            {
                NUDSpeed.Visible = false;
                LSpeed.Visible = false;
            }

            if (Production.Employees.HasValue)
            {
                NUDEmployeees.Value = Production.Employees.Value;
            }
            else
            {
                NUDEmployeees.Visible = false;
                LEmployees.Visible = false;
            }

            if (Production.Rhythm.HasValue)
            {
                NUDRhythm.Value = Production.Rhythm.Value;
            }
            else
            {
                NUDRhythm.Visible = false;
                LRhythm.Visible = false;
            }

            if (Production.Tact.HasValue)
            {
                NUDTact.Value = Production.Tact.Value;
            }
            else
            {
                NUDTact.Visible = false;
                LTact.Visible = false;
            }
        }
        private void NUDDetails_ValueChanged(object sender, EventArgs e) =>
            Production.Details = (int)NUDDetails.Value;
        private void NUDSpeed_ValueChanged(object sender, EventArgs e) =>
            Production.Speed = (int)NUDSpeed.Value;
        private void NUDEmployeees_ValueChanged(object sender, EventArgs e) =>
            Production.Employees = (int)NUDEmployeees.Value;
        private void NUDRhythm_ValueChanged(object sender, EventArgs e) =>
            Production.Rhythm = (int)NUDRhythm.Value;
        private void NUDTact_ValueChanged(object sender, EventArgs e) =>
            Production.Tact = (int)NUDTact.Value;
        #endregion

        #region Methods
        #endregion
    }
}