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

            MinimumSize = Size;
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
            var proj = UIRepository.Project.InputProjects[inputProjIndex];

            DGVInputFields.RowCount = 0;
            DGVOutputFields.RowCount = 0;

            DGVInputFields.RowCount = proj.InputFieldsCount;
            DGVOutputFields.RowCount = proj.OutputFieldsCount;

            for (int i = 0; i < DGVInputFields.RowCount; i++)
            {
                DGVInputFields[0, i].Value = (i + 1).ToString();
            }
        }
        public void RefreshFont()
        {
            TableHandler.RefreshFont(DGVInputFields, ViewSettings);
        }
        public void RefreshCellsAutoSize()
        {
            //TableHandler.RefreshCellsAutoSize(DGVInputFields, ViewSettings);
        }
        #endregion
    }
}
