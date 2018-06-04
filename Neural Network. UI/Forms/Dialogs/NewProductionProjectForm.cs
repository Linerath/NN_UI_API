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

            bool detailsInclude = CBDetails.Checked,
                speedInclude = CBSpeed.Checked,
                employeesInclude = CBEmployees.Checked,
                rhythmInclude = CBRhythm.Checked,
                tactInclude = CBTact.Checked;
            bool orderingInclude = CBOrdering.Checked,
                forecastingInclude = CBForecasting.Checked;

            int inputCount = Convert.ToInt32(detailsInclude) +
                Convert.ToInt32(speedInclude) +
                Convert.ToInt32(employeesInclude) +
                Convert.ToInt32(rhythmInclude) +
                Convert.ToInt32(tactInclude);

            int? details, speed, employees, rhythm, tact;
            if (detailsInclude)
                details = 0;
            else
                details = null;
            if (speedInclude)
                speed = 0;
            else
                speed = null;
            if (employeesInclude)
                employees = 0;
            else
                employees = null;
            if (rhythmInclude)
                rhythm = 0;
            else
                rhythm = null;
            if (tactInclude)
                tact = 0;
            else
                tact = null;


            //!!!!!!
            int detailsTypesCount = 3;
            //!!!!!!

            FeedforwardNetworkSHL orderingNetwork, forecastingNetwork;
            orderingNetwork = forecastingNetwork = null;
            if (CBOrdering.Checked)
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
