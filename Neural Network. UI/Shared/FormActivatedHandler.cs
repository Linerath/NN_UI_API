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

            settingsForm.PGProperties.PropertyValueChanged += PGProperties_PropertyValueChanged;
        }

        private void PGProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (forms.Count() < 1)
                return;

            PropertyGrid propertyGrid = s as PropertyGrid;

            String[] data = settingsForm.Tag.ToString().Split(' ');
            int networkIndex = Int32.Parse(data[0]);
            int index = Int32.Parse(data[1]);

            OnPropertyChangedActions[index](networkIndex);
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
                return;

            Form activatedForm = sender as Form;
            if (lastForm == activatedForm)
                return;

            if (activatedForm is NetworkForm networkForm)
            {
                settingsForm.PGProperties.SelectedObject = networkForm.ViewSettings;
                settingsForm.Tag = networkForm.NetworkIndex + " " + GetFormByNetworkIndex(networkForm.NetworkIndex, typeof(NetworkForm));
            }
            else if (activatedForm is TrainingForm trainingForm)
            {
                settingsForm.PGProperties.SelectedObject = trainingForm.ViewSettings;
                settingsForm.Tag = trainingForm.NetworkIndex + " " + GetFormByNetworkIndex(trainingForm.NetworkIndex, typeof(TrainingForm));
            }
            lastForm = activatedForm;
        }

        public void RegisterForm(Form form, Action<int> onPropertyChange)
        {
            forms.Add(form);
            OnPropertyChangedActions.Add(onPropertyChange);
            form.Activated += Form_Activated;
        }
        public void UnregisterForm(Form form, bool close = false)
        {
            for (int i = 0; i < forms.Count(); i++)
            {
                if (forms[i] == form)
                {
                    forms[i].Activated -= Form_Activated;
                    if (close)
                        forms[i].Close();
                    forms.RemoveAt(i);
                    OnPropertyChangedActions.RemoveAt(i);
                    i--;
                }
            }
        }

        private int GetFormByNetworkIndex(int networkIndex, Type formType)
        {
            for (int i = 0; i < forms.Count(); i++)
            {
                if (forms[i].Tag.ToString() == networkIndex.ToString() && forms[i].GetType() == formType)
                    return i;
            }
            return -1;
        }
    }
}