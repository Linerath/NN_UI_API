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
    public partial class InputProjectForm : Form
    {
        private int networkIndex;
        private int inputProjIndex;
        public TableViewSettings ViewSettings { get; private set; }

        public InputProjectForm(int networkIndex, int inputProjIndex)
        {
            InitializeComponent();

            this.networkIndex = networkIndex;
            this.inputProjIndex = inputProjIndex;
            ViewSettings = new TableViewSettings();
        }

        #region Events
        #endregion

        #region Methods
        public void FullRefresh()
        {
            RefreshProjects();
            RefreshFont();
            RefreshCellsAutoSize();
        }
        public void RefreshProjects()
        {
            var projects = NeuralNetworkService.GetInputProjectsForNetwork(UIRepository.Project.InputProjects.ToArray(), UIRepository.Project.Networks[networkIndex]);
            for (int i = 0; i < projects.Length; i++)
            {

            }
        }
        public void RefreshFont()
        {
            TableHandler.RefreshFont(DGVInputFields, ViewSettings);
        }
        public void RefreshCellsAutoSize()
        {
            TableHandler.RefreshCellsAutoSize(DGVInputFields, ViewSettings);
        }
        #endregion
    }
}
