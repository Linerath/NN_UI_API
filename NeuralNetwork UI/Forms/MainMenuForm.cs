using NeuralNetwork_UI.Constants;
using NeuralNetwork_UI.Forms.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_UI.Forms
{
    public partial class MainMenuForm : Form
    {
        #region Forms
        private NetworkExplorerForm networkExplorerForm;
        private ViewSettingsForm viewSettingsForm;
        #endregion

        public MainMenuForm()
        {
            InitializeComponent();

            (networkExplorerForm = new NetworkExplorerForm()).Owner = this;
            networkExplorerForm.Show();
            (viewSettingsForm = new ViewSettingsForm()).Owner = this;
            viewSettingsForm.Show();
        }

        #region Events

        #region This
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            LocateForm(this, FormAbsoluteLayout.TopStretch);
            LocateForm(networkExplorerForm, this, FormRelativeLayout.BottomLeft);
            LocateForm(viewSettingsForm, networkExplorerForm, FormRelativeLayout.BottomLeft);
        }
        private void BNew_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region ExtraForms
        #endregion

        #endregion

        #region Methods

        private Form LocateForm(Form form, FormAbsoluteLayout formLayout)
        {
            if (form == null)
                throw new ArgumentException(Exceptions.UNKNOWN_FORM);

            int formHeight = form.Height;
            int formWidth = form.Width;

            // ToDo: change width
            switch (formLayout)
            {
                case FormAbsoluteLayout.TopStretch:
                    form.DesktopLocation = new Point(0, 0);
                    break;
                case FormAbsoluteLayout.TopLeft:
                    form.DesktopLocation = new Point(0, 0);
                    break;
                case FormAbsoluteLayout.TopRight:
                    break;

                case FormAbsoluteLayout.RightStretch:
                    break;
                case FormAbsoluteLayout.RightTop:
                    break;
                case FormAbsoluteLayout.RightBottom:
                    break;

                case FormAbsoluteLayout.BottomStretch:
                    break;
                case FormAbsoluteLayout.BottomLeft:
                    break;
                case FormAbsoluteLayout.BottomRight:
                    break;

                case FormAbsoluteLayout.LeftStretch:
                    break;
                case FormAbsoluteLayout.LeftTop:
                    break;
                case FormAbsoluteLayout.LeftBottom:
                    break;
            }
            return form;
        }
        private Form LocateForm(Form form, Form relativeForm, FormRelativeLayout formRelativeLayout)
        {
            if (form == null || relativeForm == null)
                throw new ArgumentException(Exceptions.UNKNOWN_FORM);

            //relativeForm.DesktopBounds

            switch (formRelativeLayout)
            {
                case FormRelativeLayout.TopLeft:
                    break;
                case FormRelativeLayout.TopRight:

                    break;

                case FormRelativeLayout.RightTop:
                    form.DesktopLocation = new Point(relativeForm.DesktopBounds.X + relativeForm.DesktopBounds.Width, relativeForm.DesktopBounds.Y);
                    break;
                case FormRelativeLayout.RightBottom:
                    break;

                case FormRelativeLayout.BottomLeft:
                    form.DesktopLocation = new Point(relativeForm.DesktopBounds.X, relativeForm.DesktopBounds.Y + relativeForm.DesktopBounds.Height);
                    break;
                case FormRelativeLayout.BottomRight:
                    break;

                case FormRelativeLayout.LeftTop:
                    form.DesktopLocation = new Point(relativeForm.DesktopBounds.X - form.Width, relativeForm.DesktopBounds.Y);
                    break;
                case FormRelativeLayout.LeftBottom:
                    break;
            }
            return form;
        }

        #endregion

        private void MainMenuForm_Click(object sender, EventArgs e)
        {
            
        }



        private void panel1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DesktopBounds.Width + "x" + DesktopBounds.Height);

            //int oldW = Width;
            //int oldH = Height;
            //int pOldW = panel1.Width;
            //int pOldH = panel1.Height;

            //Size = new Size(373, 296);

            //int newW = Width;
            //int newH = Height;
            //int pNewW = panel1.Width;
            //int pNewH = panel1.Height;

            //MessageBox.Show("Old size:\n" + oldW + "x" + oldH + ". " + pOldW + "x" + pOldH + "\nNew size:\n" + 
            //    newW + "x" + newH + ". " + pNewW + "x" + pNewH);
        }
    }
}
