using Neural_Network.Core.Implementation;
using Neural_Network.UI.Constants;
using Neural_Network.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Shared
{
    public class FormActivatedHandler
    {
        private ViewSettingsForm settingsForm;
        private List<Form> forms;
        private Form lastForm;

        public FormActivatedHandler(ViewSettingsForm settingsForm)
        {
            this.settingsForm = settingsForm ?? throw new ArgumentNullException(Exceptions.NULL_ARGUMENT + "(Form: ViewSettingsForm)");
            forms = new List<Form>();
            lastForm = null;

            settingsForm.PGLayers.PropertyValueChanged += PGLayers_PropertyValueChanged;
        }

        private void PGLayers_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (forms.Count() < 1)
                return;

            PropertyGrid propertyGrid = s as PropertyGrid;
            int networkIndex = (int)propertyGrid.Tag;

            var mainForm = settingsForm.Owner as MainMenuForm;
            mainForm.RefreshNetworkLayer(networkIndex);
        }

        private void LayerForm_Activated(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
                return;
            Form activatedForm = sender as Form;
            if (lastForm == activatedForm)
                return;
            if (activatedForm is LayerForm layerForm)
            {
                settingsForm.PGLayers.SelectedObject = layerForm.ViewSettings;
                settingsForm.PGLayers.Tag = layerForm.NetworkIndex;
            }
            lastForm = activatedForm;
        }

        public void RegisterForm(Form form)
        {
            if (form is LayerForm layerForm)
            {
                layerForm.Activated += LayerForm_Activated;
                forms.Add(layerForm);
            }
        }
    }
}