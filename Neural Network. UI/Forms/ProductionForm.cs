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
        private Production production;

        public ProductionForm(Production production)
        {
            InitializeComponent();

            this.production = production;
            NUDDetails.Value = production.Details;
            NUDSpeed.Value = production.Speed;
            NUDEmployeees.Value = production.Employees;
            NUDRhythm.Value = production.Rhythm;
            NUDTact.Value = production.Tact;
        }

        #region Events
        #endregion

        #region Methods
        #endregion

        private void NUDDetails_ValueChanged(object sender, EventArgs e) =>
            production.Details = (int)NUDDetails.Value;

        private void NUDSpeed_ValueChanged(object sender, EventArgs e) =>
            production.Speed = (int)NUDSpeed.Value;

        private void NUDEmployeees_ValueChanged(object sender, EventArgs e) =>
            production.Employees = (int)NUDEmployeees.Value;

        private void NUDRhythm_ValueChanged(object sender, EventArgs e) =>
            production.Rhythm = (int)NUDRhythm.Value;
        private void NUDTact_ValueChanged(object sender, EventArgs e) =>
            production.Tact = (int)NUDTact.Value;
    }
}