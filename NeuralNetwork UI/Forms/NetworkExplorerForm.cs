using Neural_Network.Core.Extra;
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

namespace NeuralNetwork_UI.Forms
{
    public partial class NetworkExplorerForm : Form
    {
        public NetworkExplorerForm()
        {
            InitializeComponent();
        }

        #region Events
        #endregion

        #region Methods
        public void RefreshTree()
        {
            // Readable
            //TreeNode[] nodes = new TreeNode[Project.NetworksCount];
            //for (int i = 0; i < Project.NetworksCount; i++)
            //{
            //    var projects = (NeuralNetworkService.GetInputProjectsForNetwork(Project.InputProjects.ToArray(), Project.Networks[i])).Select(x => new TreeNode(x.Name)).ToArray();
            //    nodes[i] = new TreeNode(Project.Networks[i].Name, projects);
            //}
            //TVNetworks.Nodes.AddRange(nodes);

            TVNetworks.Nodes.Clear();

            TVNetworks.Nodes.AddRange(
                Project.Networks.Select(n => new TreeNode(n.Name,
                    (NeuralNetworkService.GetInputProjectsForNetwork(Project.InputProjects.ToArray(), n))
                        .Select(p => new TreeNode(p.Name)).ToArray()
                )).ToArray());
        }
        #endregion

        private void TVNetworks_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }
    }
}
