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
    public partial class SelectNetworkForm : Form
    {
        public SelectNetworkForm()
        {
            InitializeComponent();
        }

        #region Events
        private void SelectNetworkForm_Load(object sender, EventArgs e)
        {
            TBName.Text = "InputProj_" + UIRepository.Project.InputProjectsCount;

            RefreshNetworks();
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

            int index = LBNetworks.SelectedIndex;

            if (index >= 0)
            {
                UIRepository.Project.AddInputProject(new Neural_Network.Core.Extra.NeuralNetworkInputProject(name, UIRepository.Project.Networks[index]));
                Close();
            }
            else
            {
                MessageBox.Show("Select network at first.");
            }
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Methods
        public void RefreshNetworks()
        {
            LBNetworks.Items.Clear();
            LBNetworks.Items.AddRange(UIRepository.Project.Networks.Select(x => x.Name).ToArray());
            if (UIRepository.Project.NetworksCount > 0)
                LBNetworks.SetSelected(0, true);
        }
        #endregion
    }
}
