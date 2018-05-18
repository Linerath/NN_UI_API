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

namespace Neural_Network.UI.Forms.Dialogs
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
            RefreshNetworks();
            BOk.PerformClick();
        }
        private void BOk_Click(object sender, EventArgs e)
        {
            int networkIndex = LBNetworks.SelectedIndex;

            if (networkIndex >= 0)
            {
                var owner = Owner as MainMenuForm;
                owner.ShowTrainingForm(networkIndex);

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