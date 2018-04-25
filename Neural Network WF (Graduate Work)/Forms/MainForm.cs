using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural_Network.Core.Implementation;
using Neural_Network_WF__Graduate_Work_.Forms;
using Neural_Network_WF__Graduate_Work_.Forms.Dialogs;
using Neural_Network_WF__Graduate_Work_.Networks;

namespace Neural_Network_WF__Graduate_Work_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            NeuralNetwork.Network = new FeedforwardNetworkSHL(3, 4, 2);
            RefreshInformation();
        }

        #region Methods
        private void RefreshInformation()
        {
            if (NeuralNetwork.Network == null)
            {
                TBName.Enabled = false;
                BViewEdit.Enabled = false;
                BPractice.Enabled = false;
                BTraining.Enabled = false;
                return;
            }

            NeuralNetwork.Network.SetAllRandomWeights();

            TBName.Text = NeuralNetwork.Network.Name;
            LCreationDate1.Text = NeuralNetwork.Network.CreationDate.ToString();
            LType1.Text = NeuralNetwork.Network.NetType.ToString();
            TBName.Enabled = true;
            BViewEdit.Enabled = true;
            BPractice.Enabled = true;
            BTraining.Enabled = true;
            BViewEdit.Focus();
        }
        #endregion

        #region Events
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNetworkFormDialog form = new NewNetworkFormDialog();
            form.FormClosing += (s, args) =>
            {
                RefreshInformation();
            };
            form.ShowDialog(this);
        }

        private void BViewEdit_Click(object sender, EventArgs e)
        {
            NetworkViewForm form = new NetworkViewForm();
            form.FormClosing += (s, args) =>
            {
                Show();
            };
            Hide();
            form.ShowDialog(this);
        }
        private void BPractice_Click(object sender, EventArgs e)
        {
            PracticeNetworkForm form = new PracticeNetworkForm();
            form.FormClosing += (s, args) =>
            {
                Show();
            };
            Hide();
            form.ShowDialog(this);
        }
        #endregion

        private void BTraining_Click(object sender, EventArgs e)
        {

        }
    }
}