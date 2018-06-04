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
        public NewProductionProjectForm()
        {
            InitializeComponent();
        }

        private void NewProductionProjectForm_Load(object sender, EventArgs e)
        {
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

            bool details = CBDetails.Checked,
                speed = CBSpeed.Checked,
                employees = CBEmployees.Checked,
                rhythm = CBRhythm.Checked,
                tact = CBTact.Checked;
            bool ordering = CBOrdering.Checked,
                forecasting = CBForecasting.Checked;

            int inputCount = Convert.ToInt32(details) +
                Convert.ToInt32(speed) +
                Convert.ToInt32(employees) +
                Convert.ToInt32(rhythm) +
                Convert.ToInt32(tact);

            //!!!!!!
            int detailsTypesCount = 3;
            //!!!!!!

            int? orderingNetworkIndex, forecastingNetworkIndex;
            orderingNetworkIndex = forecastingNetworkIndex = null;
            if (CBOrdering.Checked)
            {
                var network = new FeedforwardNetworkSHL(name + "_Ordering", inputCount, inputCount * 2, detailsTypesCount, Core.Functions.Sigmoid, 0.05);
                network.SetAllRandomWeights();
                orderingNetworkIndex = UIRepository.Project.AddNetwork(network);
            }
            if (CBForecasting.Checked)
            {
                var network = new FeedforwardNetworkSHL(name + "_Forecasting", inputCount, inputCount * 2, 2, Core.Functions.Sigmoid, 0.05);
                network.SetAllRandomWeights();
                forecastingNetworkIndex = UIRepository.Project.AddNetwork(network);
            }
            var owner = Owner as MainMenuForm;
            var production = new Production
            {
                Name = name,
                OrderingNetworkIndex = orderingNetworkIndex,
                ForecastingNetworkIndex = forecastingNetworkIndex
            };
            int productionProjIndex = UIRepository.Project.AddProductionProject(production);
            if (orderingNetworkIndex.HasValue)
                owner?.ShowNetwork(orderingNetworkIndex.Value);
            if (forecastingNetworkIndex.HasValue)
                owner?.ShowNetwork(forecastingNetworkIndex.Value);
            owner?.ShowProductionForm(productionProjIndex);

            Close();
        }
    }
}
