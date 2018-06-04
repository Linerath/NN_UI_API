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

namespace Neural_Network.UI.Forms
{
    public partial class ViewSettingsForm : Form
    {
        public FeedforwardNetworkSHL Network { get; set; }
        public Action<FeedforwardNetworkSHL> OnPropertyChangeAction { get; set; }

        public ViewSettingsForm()
        {
            InitializeComponent();
        }

        #region Events
        private void ViewSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        #endregion

        #region Methods
        #endregion
    }
}
