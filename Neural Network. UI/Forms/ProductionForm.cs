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

            this.Production = production;
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
            Production.Details = (int)NUDDetails.Value;

        private void NUDSpeed_ValueChanged(object sender, EventArgs e) =>
            Production.Speed = (int)NUDSpeed.Value;

        private void NUDEmployeees_ValueChanged(object sender, EventArgs e) =>
            Production.Employees = (int)NUDEmployeees.Value;

        private void NUDRhythm_ValueChanged(object sender, EventArgs e) =>
            Production.Rhythm = (int)NUDRhythm.Value;
        private void NUDTact_ValueChanged(object sender, EventArgs e) =>
            Production.Tact = (int)NUDTact.Value;
    }
}