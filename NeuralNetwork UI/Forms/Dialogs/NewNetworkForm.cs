using NeuralNetwork_UI.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_UI.Forms.Dialogs
{
    public partial class NewNetworkForm : Form
    {
        public NewNetworkForm()
        {
            InitializeComponent();
        }

        #region Events
        private void NewNetworkForm_Load(object sender, EventArgs e)
        {
            TBName.Text += "_" + Project.NetworksCount;
        }
        private void BOk_Click(object sender, EventArgs e)
        {
            String name = TBName.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Invalid name.");
                TBName.Focus();
                return;
            }

            int inputCount = (int)NUDInput.Value;
            int hiddenCount = (int)NUDHidden.Value;
            int outputCount = (int)NUDOutput.Value;

            int index = Project.AddNetwork(new Neural_Network.Core.Implementation.FeedforwardNetworkSHL(name, inputCount, hiddenCount, outputCount));

            if (CBRandomWeights.Checked)
                Project.Networks[index].SetAllRandomWeights();

            var owner = Owner as MainMenuForm;
            owner.ShowNetwork(index);

            if (CBCreateAnother.Checked)
            {
                TBName.Text = "Net_" + Project.NetworksCount;
                Focus();
            }
            else
            {
                Close();
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
