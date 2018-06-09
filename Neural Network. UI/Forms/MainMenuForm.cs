#define TEST_MODE

using Neural_Network.UI.Constants;
using Neural_Network.UI.Shared;
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
using Neural_Network.UI.Forms.Dialogs;
using Neural_Network.UI.Constants.Form;
using Neural_Network.Core.Extra;

namespace Neural_Network.UI.Forms
{
    public partial class MainMenuForm : Form
    {
        #region Forms
        private NetworkExplorerForm networkExplorerForm;
        private ViewSettingsForm viewSettingsForm;
        private List<NetworkForm> networkForms;
        private List<InputProjectForm> inputProjectForms;
        private List<ProductionForm> productionForms;
        private List<TrainingForm> trainingForms;
        #endregion
        #region Shared
        private FormActivatedHandler formActivatedHandler;
        #endregion

        public MainMenuForm()
        {
            InitializeComponent();

            NewProject();
            RefreshProjName();
        }

        #region Events
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
#if TEST_MODE
            if (UIRepository.Project.TryOpen(@"E:\Programming\C#\Neural Network WF (Graduate Work)\Neural Network. UI\bin\Debug\1.nnproj"))
            {
                networkExplorerForm.RefreshTree();
                ShowAllNetworks();
                //ShowAllInputProjects();
                ShowAllProductionProjects();
            }
#endif
        }
        private void BNewProj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development", "Warning");
            return;
        }
        private void BOpenProj_Click(object sender, EventArgs e)
        {
            openProjToolStripMenuItem.PerformClick();
        }
        private void BSaveProj_Click(object sender, EventArgs e)
        {
            saveProjToolStripMenuItem.PerformClick();
        }
        private void BSaveProjAs_Click(object sender, EventArgs e)
        {
            saveProjAsToolStripMenuItem.PerformClick();
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
        private void BNewInputProj_Click(object sender, EventArgs e)
        {
            if (UIRepository.Project.NetworksCount < 1)
            {
                MessageBox.Show("There are no neural networks in project. Create network at first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            NewInputProjectForm newInputProjectForm = new NewInputProjectForm
            {
                Owner = this,
            };
            newInputProjectForm.FormClosed += (Sender, E) =>
            {
                networkExplorerForm.RefreshTree();
            };
            newInputProjectForm.ShowDialog();
        }
        private void BTraining_Click(object sender, EventArgs e)
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
            selectNetworkForm.ShowDialog();
        }
        private void BProduction_Click(object sender, EventArgs e)
        {
            NewProductionProjectForm newProductionProjectForm = new NewProductionProjectForm
            {
                Owner = this
            };
            newProductionProjectForm.FormClosed += (Sender, E) =>
            {
                networkExplorerForm.RefreshTree();
            };
            newProductionProjectForm.ShowDialog();
        }


        private void openProjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Neural network project(*.nnproj)|*.nnproj",
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (UIRepository.Project.TryOpen(ofd.FileName))
                {
                    NewProject();
                    networkExplorerForm.RefreshTree();
                    ShowAllNetworks();
                    ShowAllInputProjects();
                    ShowAllProductionProjects();
                }
            }
        }
        private void saveProjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UIRepository.Project.FilePath != null)
            {
                if (!UIRepository.Project.TrySave())
                    MessageBox.Show("Project was not saved.", "Error");
            }
            else
            {
                saveProjAsToolStripMenuItem.PerformClick();
            }
        }
        private void saveProjAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Neural network project(*.nnproj)|*.nnproj",
                FileName = UIRepository.Project.Name + ".nnproj"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                networkExplorerForm.RefreshTree();
                UIRepository.Project.TrySaveTo(sfd.FileName);
            }
        }
        private void networkExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            networkExplorerForm?.Show();
        }
        private void viewSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSettingsForm?.Show();
        }
        #endregion


        #region Methods

        private void NewProject()
        {
            networkExplorerForm?.Close();
            viewSettingsForm?.Close();

            if (networkForms != null && networkForms.Any())
                networkForms.ForEach(x => x.Close());
            if (inputProjectForms != null && inputProjectForms.Any())
                inputProjectForms.ForEach(x => x.Close());
            if (productionForms != null && productionForms.Any())
                productionForms.ForEach(x => x.Close());
            if (trainingForms != null && trainingForms.Any())
                trainingForms.ForEach(x => x.Close());

            (networkExplorerForm = new NetworkExplorerForm()).Owner = this;
            (viewSettingsForm = new ViewSettingsForm()).Owner = this;
            networkForms = new List<NetworkForm>();
            inputProjectForms = new List<InputProjectForm>();
            productionForms = new List<ProductionForm>();
            trainingForms = new List<TrainingForm>();

            formActivatedHandler = new FormActivatedHandler(viewSettingsForm);

            networkExplorerForm.Show();
            viewSettingsForm.Show();

            DefaultFormsLayout();
        }

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

            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Size.Height);
        }

        public void ShowAllNetworks()
        {
            foreach (var v in UIRepository.Project.Networks)
                ShowNetwork(v);
        }
        public void ShowNetwork(FeedforwardNetworkSHL network)
        {
            NetworkForm networkForm = new NetworkForm(network)
            {
                Owner = this,
                Text = network.Name,
            };
            formActivatedHandler.RegisterForm(networkForm, RefreshNetwork);

            networkForm.Show();
            if (networkForms.Any())
                networkForm.Location = new Point(networkForms.Last().Location.X + 20, networkForms.Last().Location.Y + 20);
            else
                networkForm.Location = new Point(networkExplorerForm.Location.X + networkExplorerForm.Size.Width - 5, networkExplorerForm.Location.Y);
            networkForms.Add(networkForm);
            networkForm.FullNetworkRefresh();
        }
        public void CloseNetwork(FeedforwardNetworkSHL network)
        {
            int networkFormIndex = GetNetworkFormIndex(network);
            if (networkFormIndex >= 0)
            {
                formActivatedHandler.UnregisterForm(networkForms[networkFormIndex], true);
                CloseInputProjects(network);
                networkForms.RemoveAt(networkFormIndex);
            }
            UIRepository.Project.RemoveNetwork(network);
            networkExplorerForm.RefreshTree(true);
        }
        public void RefreshNetwork(FeedforwardNetworkSHL network)
        {
            networkForms[GetNetworkFormIndex(network)]?.FullNetworkRefresh();
        }

        public int GetNetworkFormIndex(FeedforwardNetworkSHL network)
        {
            for (int i = 0; i < networkForms.Count(); i++)
            {
                if (networkForms[i].Network == network)
                    return i;
            }
            return -1;
        }
        public int GetInputProjFormIndex(NeuralNetworkInputProject inputProj)
        {
            for (int i = 0; i < inputProjectForms.Count(); i++)
            {
                if (inputProjectForms[i].InputProj == inputProj)
                    return i;
            }
            return -1;
        }
        public int GetProductionProjFormIndex(Production production)
        {
            for (int i = 0; i < productionForms.Count(); i++)
            {
                if (productionForms[i].Production == production)
                    return i;
            }
            return -1;
        }
        public int GetTrainingFormIndex(FeedforwardNetworkSHL network)
        {
            for (int i = 0; i < trainingForms.Count(); i++)
            {
                if (trainingForms[i].Network == network)
                    return i;
            }
            return -1;
        }

        public void ShowAllInputProjects()
        {
            foreach (var v in UIRepository.Project.InputProjects)
                ShowInputProject(v);
        }
        public void ShowInputProject(NeuralNetworkInputProject inputProj)
        {
            InputProjectForm projForm = new InputProjectForm(inputProj)
            {
                Owner = this,
                Text = inputProj.Network.Name + ". " + inputProj.Name,
            };

            projForm.Show();
            if (inputProjectForms.Any())
                projForm.Location = new Point(inputProjectForms.Last().Location.X + 20, inputProjectForms.Last().Location.Y + 20);
            else
                projForm.Location = new Point(viewSettingsForm.Location.X + viewSettingsForm.Size.Width - 5, viewSettingsForm.Location.Y);
            inputProjectForms.Add(projForm);
            projForm.FullRefresh();
        }
        public void CloseInputProjects(FeedforwardNetworkSHL network)
        {
            for (int i = 0; i < inputProjectForms.Count(); i++)
            {
                if (inputProjectForms[i].InputProj.Network == network)
                {
                    inputProjectForms[i].Close();
                    UIRepository.Project.InputProjects.Remove(inputProjectForms[i].InputProj);
                    inputProjectForms.RemoveAt(i--);
                }
            }
            networkExplorerForm.RefreshTree(true);
        }
        public void CloseInputProject(NeuralNetworkInputProject inputProj)
        {
            var inputProjIndex = GetInputProjFormIndex(inputProj);
            inputProjectForms[inputProjIndex].Close();
            inputProjectForms.RemoveAt(inputProjIndex);
            UIRepository.Project.InputProjects.Remove(inputProj);
            networkExplorerForm.RefreshTree(true);
        }

        public void ShowAllProductionProjects()
        {
            foreach (var v in UIRepository.Project.ProductionProjects)
                ShowProductionForm(v);
        }
        public void ShowProductionForm(Production production)
        {
            ProductionForm productionForm = new ProductionForm(production)
            {
                Owner = this,
                Text = production.Name
            };
            productionForm.Show();
            if (productionForms.Any())
                productionForm.Location = new Point(productionForms.Last().Location.X + 20, productionForms.Last().Location.Y + 20);
            productionForms.Add(productionForm);
        }
        public void CloseProductionProject(Production production)
        {
            foreach (var proj in production.InputProjects)
                CloseNetwork(proj.Network);
            var productionFormIndex = GetProductionProjFormIndex(production);
            if (productionFormIndex < 0)
                return;
            productionForms[productionFormIndex].Close();
            productionForms.RemoveAt(productionFormIndex);
            UIRepository.Project.ProductionProjects.Remove(production);
            networkExplorerForm.RefreshTree(true);
        }

        public void ShowTrainingForm(FeedforwardNetworkSHL network, Action trainingEndAction = null)
        {
            for (int i = 0; i < trainingForms.Count(); i++)
            {
                if (trainingForms[i].Network == network)
                {
                    trainingForms[i].Show();
                    return;
                }
            }
            //MessageBox.Show("Training form is already opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TrainingForm trainingForm = new TrainingForm(network, trainingEndAction)
            {
                Owner = this,
                Text = network.Name + ". Training",
            };
            trainingForms.Add(trainingForm);
            formActivatedHandler.RegisterForm(trainingForm, RefreshTrainingFormTables);
            trainingForm.Show();
        }
        public void RefreshTrainingFormTables(FeedforwardNetworkSHL network)
        {
            int index = GetTrainingFormIndex(network);
            trainingForms[index].FullTablesRefresh();
        }

        public void RefreshProjName()
        {
            Text = UIRepository.Project.Name + " - Main Menu";
        }
        #endregion
    }
}