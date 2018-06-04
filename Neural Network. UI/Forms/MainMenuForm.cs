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
        private TrainingForm trainingForm;
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
            if (UIRepository.Project.TryOpen(@"D:\Programming\C#\NeuralNetwork_Core_UI\Neural Network. UI\bin\Debug\hades.nnproj"))
            {
                networkExplorerForm.RefreshTree();
                ShowAllNetworks();
                ShowAllInputProjects();
                ShowAllProductionProjects();
            }
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
        private void BOpenNetwork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development", "Warning");
            return;
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory()
            };

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
        private void BOpenInputProj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development", "Warning");
            return;
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
            trainingForm?.Close();

            (networkExplorerForm = new NetworkExplorerForm()).Owner = this;
            (viewSettingsForm = new ViewSettingsForm()).Owner = this;
            networkForms = new List<NetworkForm>();
            inputProjectForms = new List<InputProjectForm>();
            productionForms = new List<ProductionForm>();

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
            for (int i = 0; i < UIRepository.Project.NetworksCount; i++)
                ShowNetwork(i, i == 0);
        }
        public void ShowNetwork(int networkIndex, bool first = false)
        {
            NetworkForm networkForm = new NetworkForm(networkIndex)
            {
                Owner = this,
                Text = UIRepository.Project.Networks[networkIndex].Name,
                Tag = networkIndex.ToString(),
            };
            formActivatedHandler.RegisterForm(networkForm, RefreshNetwork);

            networkForm.Show();
            if (networkForms.Any() && !first)
            {
                if (networkForms.Count > networkForms.Count() - 1)
                    networkForm.Location = new Point(networkForms.Last().Location.X + 20, networkForms.Last().Location.Y + 20);
            }
            else
                networkForm.Location = new Point(networkExplorerForm.Location.X + networkExplorerForm.Size.Width - 5, networkExplorerForm.Location.Y);
            networkForms.Add(networkForm);
            networkForm.FullNetworkRefresh();
        }
        public void CloseNetwork(int networkIndex)
        {
            int networkFormIndex = GetNetworkFormIndex(networkIndex);
            if (networkFormIndex >= 0)
            {
                // TODO: DECREASE INPUTPRJ NETWORK INDEX
                for (int i = networkFormIndex; i < networkForms.Count(); i++)
                {
                    networkForms[i].DecreaseNetworkIndex();
                    DecreaseInputProjectsNetworkIndex(i);
                }
                formActivatedHandler.UnregisterForm(networkForms[networkFormIndex], true);
                networkForms.RemoveAt(networkFormIndex);
                CloseInputProjects(networkIndex);
                for (int i = networkFormIndex; i < networkForms.Count(); i++)
                {
                    DecreaseInputProjectsNetworkIndex(i);
                }
            }
        }
        public void RefreshNetwork(int networkIndex)
        {
            networkForms[networkIndex]?.FullNetworkRefresh();
        }
        public int GetNetworkFormIndex(int networkIndex)
        {
            for (int i = 0; i < networkForms.Count(); i++)
            {
                if (networkForms[i].NetworkIndex == networkIndex)
                    return i;
            }
            return -1;
        }
        public int[] GetInputProjFormIndices(int networkIndex)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < inputProjectForms.Count(); i++)
            {
                if (inputProjectForms[i].NetworkIndex == networkIndex)
                    indices.Add(i);
            }
            return indices.ToArray();
        }

        public int GetInputProjFormIndex(int inputProjIndex)
        {
            for (int i = 0; i < inputProjectForms.Count(); i++)
            {
                if (inputProjectForms[i].InputProjIndex == inputProjIndex)
                    return i;
            }
            return -1;
        }

        public void ShowAllInputProjects()
        {
            for (int i = 0; i < UIRepository.Project.InputProjectsCount; i++)
                ShowInputProject(NeuralNetworkService.GetNetworkIndexForInputProject(UIRepository.Project.InputProjects[i], UIRepository.Project.Networks.ToArray()), i, i == 0);
        }
        public void ShowInputProject(int networkIndex, int inputProjIndex, bool first = false)
        {
            InputProjectForm projForm = new InputProjectForm(networkIndex, inputProjIndex)
            {
                Owner = this,
                Text = UIRepository.Project.Networks[networkIndex].Name + ". " + UIRepository.Project.InputProjects[inputProjIndex].Name,
            };

            projForm.Show();
            if (inputProjectForms.Any() && !first)
                projForm.Location = new Point(inputProjectForms.Last().Location.X + 20, inputProjectForms.Last().Location.Y + 20);
            else
                projForm.Location = new Point(viewSettingsForm.Location.X + viewSettingsForm.Size.Width - 5, viewSettingsForm.Location.Y);
            inputProjectForms.Add(projForm);
            projForm.FullRefresh();
        }
        public void CloseInputProjects(int networkIndex)
        {
            int[] inputProjIndices = GetInputProjFormIndices(networkIndex);
            if (inputProjIndices.Length < 1)
                return;
            inputProjectForms.ForEach(x =>
            {
                if (x.NetworkIndex == networkIndex)
                    x.Close();
            });
            for (int i = inputProjIndices[0]; i < inputProjectForms.Count(); i++)
            {
                inputProjectForms[i].NetworkIndex--;
            }
            inputProjectForms.RemoveRange(inputProjIndices[0], inputProjIndices.Length);
        }
        private void DecreaseInputProjectsNetworkIndex(int networkIndex)
        {
            inputProjectForms.ForEach(x =>
            {
                if (x.NetworkIndex == networkIndex)
                    x.NetworkIndex--;
            });
        }

        public void ShowAllProductionProjects()
        {
            for (int i = 0; i < UIRepository.Project.ProductionProjectsCount; i++)
                ShowProductionForm(i);
        }
        public void ShowProductionForm(int productionProjIndex, bool first = false)
        {
            ProductionForm productionForm = new ProductionForm(productionProjIndex)
            {
                Owner = this,
                Text = UIRepository.Project.ProductionProjects[productionProjIndex].Name
            };
            productionForm.Show();
            if (productionForms.Any() && !first)
                productionForm.Location = new Point(productionForms.Last().Location.X + 20, productionForms.Last().Location.Y + 20);
            else
                productionForms.Add(productionForm);
        }


        public void ShowTrainingForm(int networkIndex)
        {
            if (trainingForm != null)
            {
                if (trainingForm.NetworkIndex == networkIndex)
                {
                    MessageBox.Show("Training form is already opened!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trainingForm.Focus();
                    return;
                }
                trainingForm.Close();
            }
            trainingForm = new TrainingForm(networkIndex)
            {
                Owner = this,
                Text = UIRepository.Project.Networks[networkIndex].Name + ". Training",
                Tag = networkIndex.ToString(),
            };
            formActivatedHandler.RegisterForm(trainingForm, RefreshTrainingFormTables);
            trainingForm.Show();
        }
        public void RefreshTrainingFormTables(int networkIndex)
        {
            trainingForm?.FullTablesRefresh();
        }

        public void RefreshProjName()
        {
            Text = UIRepository.Project.Name + " - Main Menu";
        }

        #endregion
    }
}