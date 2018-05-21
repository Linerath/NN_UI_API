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

            settingsForm.PGProperties.PropertyValueChanged += PGProperties_PropertyValueChanged;
        }

        private void PGProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
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

            settingsForm.PGProperties.Tag = activatedForm.Tag.ToString().Split(' ')[1];

            if (activatedForm is NetworkForm networkForm)
            {
                settingsForm.PGProperties.SelectedObject = networkForm.ViewSettings;
                settingsForm.PGProperties.Tag += ";" + networkForm.NetworkIndex;
            }
            else if (activatedForm is TrainingForm trainingForm)
            {
                settingsForm.PGProperties.SelectedObject = trainingForm.ViewSettings;
                settingsForm.PGProperties.Tag += ";" + trainingForm.NetworkIndex;
            }
            lastForm = activatedForm;
        }

        public void RegisterForm(Form form, Action<int> onPropertyChange)
        {
            forms.Add(form);
            OnPropertyChangedActions.Add(onPropertyChange);
            int index = forms.Count() - 1;
            forms[index].Tag += " " + index;
            form.Activated += Form_Activated;
        }
        public void UnregisterForm(Form form)
        {
            int index = -1;
            for (int i = 0; i < forms.Count(); i++)
            {
                if (forms[i] == form)
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                forms[index].Activated -= Form_Activated;
                forms.RemoveAt(index);
                OnPropertyChangedActions.RemoveAt(index);
            }
        }
        public void UnregisterForm(int networkIndex, bool close = false)
        {
            for (int i = 0; i < forms.Count(); i++)
            {
                if (forms[i].Tag.ToString().Split(' ')[0] == networkIndex.ToString())
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
    }
}