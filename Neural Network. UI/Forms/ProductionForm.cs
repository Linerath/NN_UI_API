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
            if (Production.OrderingNetwork != null)
                owner.ShowTrainingForm(Production.OrderingNetwork);
            if (Production.ForecastingNetwork != null)
                owner.ShowTrainingForm(Production.ForecastingNetwork);
        }
        #endregion

        #region Methods
        #endregion
    }
}