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
            TBName.Text += "_" + UIRepository.Project.NetworksCount;
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

            int inputCount = (int)NUDInput.Value;
            int hiddenCount = (int)NUDHidden.Value;
            int outputCount = (int)NUDOutput.Value;

            int index = UIRepository.Project.AddNetwork(new Neural_Network.Core.Implementation.FeedforwardNetworkSHL(name, inputCount, hiddenCount, outputCount));

            if (CBRandomWeights.Checked)
                UIRepository.Project.Networks[index].SetAllRandomWeights();

            var owner = Owner as MainMenuForm;
            owner.ShowNetwork(index);

            if (CBCreateAnother.Checked)
            {
                TBName.Text = "Net_" + UIRepository.Project.NetworksCount;
                Focus();
            }
            else
            {
                Close();
            }
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Methods
        #endregion
    }
}
