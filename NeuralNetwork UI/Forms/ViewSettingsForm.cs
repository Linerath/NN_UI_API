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
    public enum DisplayTypes
    {
        TextBox,
        CheckBox,
        DropDownList
    }

    public partial class ViewSettingsForm : Form
    {
        public ViewSettingsForm()
        {
            InitializeComponent();
        }

        #region Events
        #endregion

        #region Methods
        public void RefreshSettings(Form form, Type[] types, DisplayTypes[] displayTypes)
        {

        }
        #endregion
    }
}
