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
        private int productionProjIndex;

        public ProductionForm(int productionProjIndex)
        {
            InitializeComponent();

            this.productionProjIndex = productionProjIndex;
            NUDDetails.Value = UIRepository.Project.ProductionProjects[productionProjIndex].Details;
            NUDSpeed.Value = UIRepository.Project.ProductionProjects[productionProjIndex].Speed;
            NUDEmployeees.Value = UIRepository.Project.ProductionProjects[productionProjIndex].Employees;
            NUDRhythm.Value = UIRepository.Project.ProductionProjects[productionProjIndex].Rhythm;
            NUDTact.Value = UIRepository.Project.ProductionProjects[productionProjIndex].Tact;
        }

        #region Events
        #endregion

        #region Methods
        #endregion

        private void NUDDetails_ValueChanged(object sender, EventArgs e) =>
            UIRepository.Project.ProductionProjects[productionProjIndex].Details = (int)NUDDetails.Value;

        private void NUDSpeed_ValueChanged(object sender, EventArgs e) =>
            UIRepository.Project.ProductionProjects[productionProjIndex].Speed = (int)NUDSpeed.Value;

        private void NUDEmployeees_ValueChanged(object sender, EventArgs e) =>
            UIRepository.Project.ProductionProjects[productionProjIndex].Employees = (int)NUDEmployeees.Value;

        private void NUDRhythm_ValueChanged(object sender, EventArgs e) =>
            UIRepository.Project.ProductionProjects[productionProjIndex].Rhythm = (int)NUDRhythm.Value;
        private void NUDTact_ValueChanged(object sender, EventArgs e) =>
            UIRepository.Project.ProductionProjects[productionProjIndex].Tact = (int)NUDTact.Value;
    }
}