using NeuralNetwork.WF.MDI.Constants;
using NeuralNetwork.WF.MDI.Constants.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork.WF.MDI.Forms
{
    public partial class MainForm : Form
    {
        #region Forms
        private MainMenuForm mainMenuForm;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Forms
            CreateAndLocateForm(FormType.MainMenuForm, FormLayout.TopStretch);
            #endregion
        }

        #region Events

        #endregion

        #region Methods

        #region This
        #endregion

        #region ExtraForms
        private void CreateAndLocateForm(FormType formType, FormLayout formLayout)
        {
            Form form;
            switch (formType)
            {
                case FormType.MainMenuForm:
                    mainMenuForm = new MainMenuForm();
                    form = mainMenuForm;
                    break;
                default:
                    form = null;
                    break;
            }

            if (form == null)
                throw new ArgumentException(Exceptions.UNKNOWN_FORM);

            form.MdiParent = this;
            form.Show();

            LocateForm(form, formLayout);
        }

        private void LocateForm(Form form, FormLayout formLayout)
        {
            if (form == null)
                throw new ArgumentException(Exceptions.UNKNOWN_FORM);

            int formHeight = form.Height + FormBorder.VERTICAL_BORDER;
            int formWidth = form.Width + FormBorder.HORIZONTAL_BORDER;
            
            switch (formLayout)
            {
                case FormLayout.TopStretch:
                    break;
                case FormLayout.TopLeft:
                    break;
                case FormLayout.TopCenter:
                    break;
                case FormLayout.TopRight:
                    break;

                case FormLayout.RightStretch:
                    break;
                case FormLayout.RightTop:
                    break;
                case FormLayout.RightCenter:
                    break;
                case FormLayout.RightBottom:
                    break;

                case FormLayout.BottomStretch:
                    break;
                case FormLayout.BottomLeft:
                    break;
                case FormLayout.BottomCenter:
                    break;
                case FormLayout.BottomRight:
                    break;

                case FormLayout.LeftStretch:
                    break;
                case FormLayout.LeftTop:
                    break;
                case FormLayout.LeftCenter:
                    break;
                case FormLayout.LeftBottom:
                    break;
            }
        }
        #endregion

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
