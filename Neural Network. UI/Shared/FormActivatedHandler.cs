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
    // don't f**king change anything here without goin' to church...

    public class FormActivatedHandler
    {
        private ViewSettingsForm settingsForm;
        private List<Form> forms;
        private List<Action<int>> OnPropertyChangedActions;
        private Form lastForm;

        public FormActivatedHandler(ViewSettingsForm settingsForm)
        {
            this.settingsForm = settingsForm ?? throw new ArgumentNullException(Exceptions.NULL_ARGUMENT + "(Form: ViewSettingsForm)");
            forms = new List<Form>();
            OnPropertyChangedActions = new List<Action<int>>();
            lastForm = null;

            settingsForm.PGLayers.PropertyValueChanged += PGLayers_PropertyValueChanged;
        }

        private void PGLayers_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (forms.Count() < 1)
                return;

            PropertyGrid propertyGrid = s as PropertyGrid;

            String[] data = propertyGrid.Tag.ToString().Split(';');
            int index = Int32.Parse(data[0]);
            int networkIndex = Int32.Parse(data[1]);

            OnPropertyChangedActions[index](networkIndex);
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
                return;

            Form activatedForm = sender as Form;
            if (lastForm == activatedForm)
                return;

            settingsForm.PGLayers.Tag = activatedForm.Tag;

            if (activatedForm is LayerForm layerForm)
            {
                settingsForm.PGLayers.SelectedObject = layerForm.ViewSettings;
                settingsForm.PGLayers.Tag += ";" + layerForm.NetworkIndex;
            }
            else if (activatedForm is TrainingForm trainingForm)
            {
                settingsForm.PGLayers.SelectedObject = trainingForm.ViewSettings;
                settingsForm.PGLayers.Tag += ";" + trainingForm.NetworkIndex;
            }
            lastForm = activatedForm;
        }

        public void RegisterForm(Form form, Action<int> onPropertyChange)
        {
            forms.Add(form);
            OnPropertyChangedActions.Add(onPropertyChange);
            int index = forms.Count() - 1;
            forms[index].Tag = index;
            form.Activated += Form_Activated;
        }
    }
}