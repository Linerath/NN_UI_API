using Neural_Network.Core.Extra;
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
    public partial class NetworkExplorerForm : Form
    {
        public NetworkExplorerForm()
        {
            InitializeComponent();
        }

        #region Events
        private void TVNetworks_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }
        private void BRemove_Click(object sender, EventArgs e)
        {
            if (TVNetworks.SelectedNode == null)
                return;
            var networkIndex = TVNetworks.SelectedNode.Index;
            if (networkIndex < 0)
                return;

            var network = UIRepository.Project.Networks[networkIndex];

            var dialogResult = MessageBox.Show(
                "Are you sure want to delete selected network:\n" + network.Name + " " +
                network.InputLayerSize.ToString() + " " + network.HiddenLayerSize.ToString() + " " + network.OutputLayerSize.ToString() + ".\nCreated on " +
                network.CreationDate.ToString(),
                "Deleting",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );

            if (dialogResult == DialogResult.Yes)
            {
                var owner = Owner as MainMenuForm;
                owner.CloseNetwork(networkIndex);
                UIRepository.Project.Networks.RemoveAt(networkIndex);
                RefreshTree();
            }
        }
        #endregion

        #region Methods
        public void RefreshTree()
        {
            // More Readable

            //TreeNode[] nodes = new TreeNode[Project.NetworksCount];
            //for (int i = 0; i < Project.NetworksCount; i++)
            //{
            //    var projects = (NeuralNetworkService.GetInputProjectsForNetwork(Project.InputProjects.ToArray(), Project.Networks[i])).Select(x => new TreeNode(x.Name)).ToArray();
            //    nodes[i] = new TreeNode(Project.Networks[i].Name, projects);
            //}
            //TVNetworks.Nodes.AddRange(nodes);

            TVNetworks.Nodes.Clear();

            TVNetworks.Nodes.AddRange(
                UIRepository.Project.Networks.Select(n => new TreeNode(n.Name,
                    (NeuralNetworkService.GetInputProjectsForNetwork(UIRepository.Project.InputProjects.ToArray(), n))
                        .Select(p => new TreeNode(p.Name)).ToArray()
                )).ToArray());
        }
        #endregion
    }
}
