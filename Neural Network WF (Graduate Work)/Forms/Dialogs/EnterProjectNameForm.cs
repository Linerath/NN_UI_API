using Neural_Network_WF__Graduate_Work_.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network_WF__Graduate_Work_.Forms.Dialogs
{
    public partial class EnterProjectNameForm : Form
    {
        public EnterProjectNameForm()
        {
            InitializeComponent();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            var owner = Owner as PracticeNetworkForm;
            if (String.IsNullOrWhiteSpace(TBProjectName.Text))
            {
                MessageBox.Show("Invalid project name. Try again.", "Error");
                owner.CreatedNewProject = false;
                return;
            }
            NeuralNetwork.InputProject = new Neural_Network.Core.Extra.NeuralNetworkInputProject(TBProjectName.Text, NeuralNetwork.Network);
            owner.CreatedNewProject = true;
            Close();
        }
    }
}
