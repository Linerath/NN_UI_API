using Neural_Network.Core.Implementation;
using Neural_Network_WF__Graduate_Work_.Networks;
using System;
using System.Windows.Forms;

namespace Neural_Network_WF__Graduate_Work_.Forms.Dialogs
{
    public partial class NewNetworkFormDialog : Form
    {
        public NewNetworkFormDialog()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            NeuralNetwork.Network= new FeedforwardNetworkSHL(
                (int)NUDInput.Value,
                (int)NUDHidden.Value,
                (int)NUDOutput.Value)
            {
                Name = TBName.Text.Trim() == String.Empty ? "Unnamed" : TBName.Text
            };

            Close();
        }
    }
}