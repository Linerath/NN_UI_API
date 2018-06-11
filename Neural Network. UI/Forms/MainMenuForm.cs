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
#if DEBUG
            if (UIRepository.Project.TryOpen(@"E:\Programming\C#\Neural Network WF (Graduate Work)\Neural Network. UI\bin\Debug\1.nnproj"))
            {
                networkExplorerForm.RefreshTree();
                ShowAllNetworks();
                //ShowAllInputProjects();
                ShowAllProductionProjects();
            }

            BProduction.PerformClick();
#endif
        }
        private void BNewProj_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Are you sure want to create new project?",
                "New project",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                if (UIRepository.Project.Networks.Count() > 0)
                {
                    var result = MessageBox.Show(
                        "Save current project?",
                        "Saving",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                        saveProjToolStripMenuItem.PerformClick();
                    NewProject();
                }
            }
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
                    NewProject(false);
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

        private void NewProject(bool newProject = true)
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

            if (newProject)
                UIRepository.Project = new Project();

            DefaultFormsLayout();

            networkExplorerForm.RefreshTree();
        }

        private void DefaultFormsLayout()
        {
            int expHeight = (int)((Screen.PrimaryScreen.WorkingArea.Height - Size.Height) * 0.4);
            int settingsHeight = (int)((Screen.PrimaryScreen.WorkingArea.Height - Size.Height) * 0.6);


            DesktopLocation = new Point(0, 0);
            networkExplorerForm.Location = new Point(Location.X, Location.Y + Height);
            networkExplorerForm.Size = new Size(networkExplorerForm.Size.Width, expHeight);
            viewSettingsForm.Location = new Point(Location.X, networkExplorerForm.Location.Y + networkExplorerForm.Height);
            viewSettingsForm.Size = new Size(viewSettingsForm.Size.Width, settingsHeight);
        }

        public void ShowAllNetworks()
        {
            foreach (var v in UIRepository.Project.Networks)
                ShowNetwork(v);
        }
        public void ShowNetwork(FeedforwardNetworkSHL network)
        {
            foreach (var n in networkForms)
            {
                if (n.Network == network)
                {
                    n.Show();
                    return;
                }
            }

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
                CloseTrainingForm(network);
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
            foreach (var p in inputProjectForms)
            {
                if (p.InputProj == inputProj)
                {
                    p.Show();
                    return;
                }
            }

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
            if (inputProjIndex >= 0)
            {
                inputProjectForms[inputProjIndex].Close();
                inputProjectForms.RemoveAt(inputProjIndex);
                UIRepository.Project.InputProjects.Remove(inputProj);
                networkExplorerForm.RefreshTree(true);
            }
        }

        public void ShowAllProductionProjects()
        {
            foreach (var v in UIRepository.Project.ProductionProjects)
                ShowProductionForm(v);
        }
        public void ShowProductionForm(Production production)
        {
            foreach (var p in productionForms)
            {
                if (p.Production == production)
                {
                    p.Show();
                    return;
                }
            }

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
            var productionFormIndex = GetProductionProjFormIndex(production);
            if (productionFormIndex >= 0)
            {
                foreach (var proj in production.InputProjects)
                    CloseNetwork(proj.Network);
                productionForms[productionFormIndex].Close();
                productionForms.RemoveAt(productionFormIndex);
                UIRepository.Project.ProductionProjects.Remove(production);
                networkExplorerForm.RefreshTree(true);
            }
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
        public void CloseTrainingForm(FeedforwardNetworkSHL network)
        {
            int trainingFormIndex = GetTrainingFormIndex(network);
            if (trainingFormIndex >= 0)
            {
                trainingForms[trainingFormIndex].Close();
                trainingForms.RemoveAt(trainingFormIndex);
            }
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