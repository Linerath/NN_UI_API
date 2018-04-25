using Neural_Network.Core.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network_WF__Graduate_Work_.Forms
{
    public partial class NetworkSchemeForm : Form
    {
        private FeedforwardNetworkSHL network;

        public NetworkSchemeForm(FeedforwardNetworkSHL network)
        {
            this.network = network;
            InitializeComponent();
        }


    }
}