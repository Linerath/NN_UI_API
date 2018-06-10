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

#if DEBUG
            LBNetworks.SelectedIndex = 3;
            BOk.PerformClick();
#endif
        }
        private void BOk_Click(object sender, EventArgs e)
        {
            if (LBNetworks.SelectedIndex < 0)
            {
                MessageBox.Show("Select network at first.");
                return;
            }
            if (LBNetworks.SelectedItem is FeedforwardNetworkSHL network)
            {
                var owner = Owner as MainMenuForm;
                owner.ShowTrainingForm(network);
                Close();
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
            LBNetworks.Items.AddRange(UIRepository.Project.Networks.ToArray());
            if (LBNetworks.Items.Count > 0)
                LBNetworks.SetSelected(0, true);
        }
        #endregion
    }
}