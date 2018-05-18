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
    public partial class TrainingForm : Form
    {
        private List<double[]> inputSignals;
        private List<double[]> correctOutputSignals;

        private int networkIndex;

        public TrainingForm(int networkIndex)
        {
            inputSignals = new List<double[]>();
            this.networkIndex = networkIndex;

            InitializeComponent();
        }

        #region Events
        private void TrainingForm_Load(object sender, EventArgs e)
        {
            LCreationDate0.Text += "\n" + UIRepository.Project.Networks[networkIndex].CreationDate.ToString();
            LLearningEpochs1.Text = UIRepository.Project.Networks[networkIndex].LearningEpochs.ToString();

            MinimumSize = Size;
        }
        #endregion

        #region Methods
        private void RefreshSignals()
        {

        }
        #endregion
    }
}

//new Font("Consolas", 13, GraphicsUnit.Point);