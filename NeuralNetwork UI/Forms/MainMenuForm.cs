using NeuralNetwork_UI.Constants;
using NeuralNetwork_UI.Forms.Constants;
using NeuralNetwork_UI.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural_Network.Core.Implementation;
using NeuralNetwork_UI.Forms.Dialogs;

namespace NeuralNetwork_UI.Forms
{
    public partial class MainMenuForm : Form
    {
        #region Forms
        private NetworkExplorerForm networkExplorerForm;
        private ViewSettingsForm viewSettingsForm;
        private List<LayerForm> inputLayerForms;
        private List<LayerForm> hiddenLayerForms;
        private List<LayerForm> outputLayerForms;
        private InputProjectsForm inputProjectsForm;
        #endregion
        #region Shared
        private FormActivatedHandler formActivatedHandler;
        #endregion

        public MainMenuForm()
        {
            InitializeComponent();

            (networkExplorerForm = new NetworkExplorerForm()).Owner = this;
            (viewSettingsForm = new ViewSettingsForm()).Owner = this;
            inputLayerForms = new List<LayerForm>();
            hiddenLayerForms = new List<LayerForm>();
            outputLayerForms = new List<LayerForm>();
            (inputProjectsForm = new InputProjectsForm()).Owner = this;

            formActivatedHandler = new FormActivatedHandler(viewSettingsForm);
        }

        #region Events

        #region This
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            //LocateForm(this, FormAbsoluteLayout.TopStretch);
            //LocateForm(networkExplorerForm, this, FormRelativeLayout.BottomLeft);
            //LocateForm(viewSettingsForm, networkExplorerForm, FormRelativeLayout.BottomLeft);

            networkExplorerForm.Show();
            viewSettingsForm.Show();
            DefaultFormsLayout();
        }
        private void BNewNetwork_Click(object sender, EventArgs e)
        {
            NewNetworkForm newNetworkForm = new NewNetworkForm
            {
                Owner = this,
            };
            newNetworkForm.FormClosed += (Sender, E) =>
            {
                networkExplorerForm.RefreshTree();
            };
            newNetworkForm.ShowDialog();

            //int networkIndex = Project.AddNetwork(new FeedforwardNetworkSHL("Net_" + (Project.NetworksCount).ToString(), 3, 4, 2));
            //Project.Networks[networkIndex].SetAllRandomWeights();
            //ShowNetwork(networkIndex);
            //networkExplorerForm.RefreshTree();
        }
        private void BOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            ofd.ShowDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                }
                catch (IOException exp)
                {
                    MessageBox.Show("IOexception was thrown. Message: " + exp.Message);
                }
            }
        }
        private void BNewInputProj_Click(object sender, EventArgs e)
        {
            if (UIRepository.Project.NetworksCount < 1)
            {
                MessageBox.Show("There are no neural networks in project. Create network at first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            SelectNetworkForm selectNetworkForm = new SelectNetworkForm
            {
                Owner = this,
            };
            selectNetworkForm.FormClosed += (Sender, E) =>
            {
                networkExplorerForm.RefreshTree();
            };
            selectNetworkForm.ShowDialog();
        }
        #endregion

        #region ExtraForms

        #endregion

        #endregion

        #region Methods

        // Not-ended trash
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
        // Not-ended trash
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
        private void DefaultFormsLayout()
        {
            DesktopLocation = new Point(0, 0);
            networkExplorerForm.Location = new Point(Location.X, Location.Y + Height);
            viewSettingsForm.Location = new Point(Location.X, networkExplorerForm.Location.Y + networkExplorerForm.Height);
            inputProjectsForm.Location = new Point(viewSettingsForm.Location.X + viewSettingsForm.Size.Width - 5, viewSettingsForm.Location.Y);

            inputProjectsForm.Size = new Size(inputProjectsForm.Width, viewSettingsForm.Size.Height);

            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Size.Height);
        }

        private LayerForm CreateLayerForm(Layers layer, int networkIndex, String text, bool registerActivatedEvent = true)
        {
            var layerForm = new LayerForm(layer, networkIndex)
            {
                Owner = this,
                Text = text,
            };

            if (registerActivatedEvent)
                formActivatedHandler.RegisterForm(layerForm);

            return layerForm;
        }
        public void ShowNetwork(int networkIndex)
        {
            LayerForm newLayerForm = CreateLayerForm(Layers.Input, networkIndex, "Input Layer (" + UIRepository.Project.Networks[networkIndex].Name + ")");
            inputLayerForms.Add(newLayerForm);
            newLayerForm.Show();
            newLayerForm.Location = new Point(networkExplorerForm.Location.X + networkExplorerForm.ClientSize.Width + 50, networkExplorerForm.Location.Y);
            newLayerForm.FullLayerRefresh();

            newLayerForm = CreateLayerForm(Layers.Hidden, networkIndex, "Hidden Layer (" + UIRepository.Project.Networks[networkIndex].Name + ")");
            hiddenLayerForms.Add(newLayerForm);
            newLayerForm.Show();
            newLayerForm.Location = new Point(inputLayerForms[inputLayerForms.Count() - 1].Location.X + inputLayerForms[inputLayerForms.Count() - 1].ClientSize.Width, inputLayerForms[inputLayerForms.Count() - 1].Location.Y);
            newLayerForm.FullLayerRefresh();

            newLayerForm = CreateLayerForm(Layers.Output, networkIndex, "Output Layer (" + UIRepository.Project.Networks[networkIndex].Name + ")");
            outputLayerForms.Add(newLayerForm);
            newLayerForm.Show();
            newLayerForm.Location = new Point(hiddenLayerForms[inputLayerForms.Count() - 1].Location.X + hiddenLayerForms[inputLayerForms.Count() - 1].ClientSize.Width, hiddenLayerForms[inputLayerForms.Count() - 1].Location.Y);
            newLayerForm.FullLayerRefresh();

            inputLayerForms[inputLayerForms.Count() - 1].SetFollowedForm(hiddenLayerForms[inputLayerForms.Count() - 1], FormRelativeLayout.LeftTop);
            newLayerForm.SetFollowedForm(hiddenLayerForms[inputLayerForms.Count() - 1], FormRelativeLayout.RightTop);

            hiddenLayerForms[inputLayerForms.Count() - 1].Focus();
        }
        public void ShowInputProject(int inputProjectIndex)
        {

        }

        public void RefreshNetworkLayer(int networkIndex)
        {
            inputLayerForms[networkIndex].FullLayerRefresh();
            hiddenLayerForms[networkIndex].FullLayerRefresh();
            outputLayerForms[networkIndex].FullLayerRefresh();
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