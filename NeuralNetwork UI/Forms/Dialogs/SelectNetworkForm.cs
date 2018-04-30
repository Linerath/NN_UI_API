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
            TBName.Text = "InputProj_" + Project.InputProjectsCount;

            RefreshNetworks();
        }
        private void BOk_Click(object sender, EventArgs e)
        {
            String name = TBName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Invalid name.");
                return;
            }

            int index = LBNetworks.SelectedIndex;

            if (index >= 0)
            {
                Project.AddInputProject(new Neural_Network.Core.Extra.NeuralNetworkInputProject(name, Project.Networks[index]));
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
            LBNetworks.Items.AddRange(Project.Networks.Select(x => x.Name).ToArray());
            if (Project.NetworksCount > 0)
                LBNetworks.SetSelected(0, true);
        }
        #endregion
    }
}
