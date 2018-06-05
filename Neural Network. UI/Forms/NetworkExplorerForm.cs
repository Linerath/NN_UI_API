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
        private void NFBView_Click(object sender, EventArgs e)
        {

        }
        private void BRemove_Click(object sender, EventArgs e)
        {
            if (TVNetworks.SelectedNode == null || TVNetworks.SelectedNode.Parent == null)
                return;

            TreeNode node = TVNetworks.SelectedNode;
            while (node.Parent != null)
                node = node.Parent;

            var index = TVNetworks.SelectedNode.Index;
            if (index < 0)
                return;

            if (node.Text == "Neural networks")
            {
                if (TVNetworks.SelectedNode.Parent.Parent == null)
                {
                    var network = UIRepository.Project.Networks[index];
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
                        owner.CloseNetwork(network);
                    }
                }
                else
                {
                    var parentIndex = TVNetworks.SelectedNode.Parent.Index;
                    var network = UIRepository.Project.Networks[parentIndex];
                    var inputProj = UIRepository.Project.GetNetworkInputProjects(network)[TVNetworks.SelectedNode.Index];

                    var dialogResult = MessageBox.Show(
                    "Are you sure want to delete selected input project:\n" + inputProj.Name + " " +
                    "\n" + inputProj.Network.InputLayerSize.ToString() + " " + inputProj.Network.OutputLayerSize.ToString(),
                    "Deleting",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        var owner = Owner as MainMenuForm;
                        owner.CloseInputProject(inputProj);
                    }
                }
            }
            else if (node.Text == "Productions")
            {
                var production = UIRepository.Project.ProductionProjects[index];
                var dialogResult = MessageBox.Show(
                    "Are you sure want to delete selected production project:\n" + production.Name,
                    "Deleting",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    );

                if (dialogResult == DialogResult.Yes)
                {
                    var owner = Owner as MainMenuForm;
                    owner.CloseProductionProject(production);
                }
            }
        }
        private void NetworkExplorerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        #endregion

        #region Methods
        public void RefreshTree(bool expand = false)
        {
            TVNetworks.Nodes.Clear();

            TreeNode networkSection = new TreeNode("Neural networks");
            TreeNode productionSection = new TreeNode("Productions");

            TreeNode[] networks = new TreeNode[UIRepository.Project.NetworksCount];
            for (int i = 0; i < UIRepository.Project.NetworksCount; i++)
            {
                var projects = (NeuralNetworkService.GetInputProjectsForNetwork(
                    UIRepository.Project.InputProjects.ToArray(),
                    UIRepository.Project.Networks[i]))
                    .Select(x => new TreeNode(x.Name)).ToArray();
                networks[i] = new TreeNode(UIRepository.Project.Networks[i].Name, projects);
            }
            networkSection.Nodes.AddRange(networks);

            TreeNode[] productionProjects = new TreeNode[UIRepository.Project.ProductionProjectsCount];
            var prodProjects = UIRepository.Project.ProductionProjects;
            for (int i = 0; i < prodProjects.Count(); i++)
                productionProjects[i] = new TreeNode(prodProjects[i].Name);
            productionSection.Nodes.AddRange(productionProjects);

            TVNetworks.Nodes.Add(networkSection);
            TVNetworks.Nodes.Add(productionSection);

            if (expand)
                TVNetworks.ExpandAll();

            //TVNetworks.Nodes.AddRange(
            //    UIRepository.Project.Networks.Select(n => new TreeNode(n.Name,
            //        (NeuralNetworkService.GetInputProjectsForNetwork(UIRepository.Project.InputProjects.ToArray(), n))
            //            .Select(p => new TreeNode(p.Name)).ToArray()
            //    )).ToArray());
        }
        #endregion
    }
}