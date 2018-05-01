using Neural_Network.Core.Implementation;
using NeuralNetwork_UI.Constants;
using NeuralNetwork_UI.Forms.Constants;
using NeuralNetwork_UI.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_UI.Forms
{
    public partial class LayerForm : Form
    {
        private Layers layer;
        public int NetworkIndex { get; private set; }
        #region View settings
        public int FontSize { get; set; } = 17;
        public bool AdaptCellsSize { get; set; } = true;
        public int DecimalPlaces { get; set; } = 2;
        public Form FollowedForm { get; set; }
        public FormRelativeLayout FollowedFormRelativeLayout { get; set; }
        #endregion

        public LayerForm(Layers layer, int networkIndex)
        {
            InitializeComponent();

            this.layer = layer;
            NetworkIndex = networkIndex;
        }

        #region Events
        private void FollowedForm_Move(object sender, EventArgs e)
        {
            LayersHandler.OnFollowedForm_Move(this, FollowedForm, FollowedFormRelativeLayout);
        }
        #endregion

        #region Methods
        public void FullLayerRefresh()
        {
            LayersHandler.RefreshLayerValues(NetworkIndex, DGVLayer, layer, DecimalPlaces, true);
            LayersHandler.RefreshFontSize(DGVLayer, FontSize);
            LayersHandler.RefreshCellsAutoSize(DGVLayer, AdaptCellsSize);
        }
        public void RefreshLayerValues(bool rewriteValues = false)
        {
            LayersHandler.RefreshLayerValues(NetworkIndex, DGVLayer, layer, DecimalPlaces, rewriteValues);
        }
        public void RefreshFontSize()
        {
            LayersHandler.RefreshFontSize(DGVLayer, FontSize);
        }
        public void RefreshCellsAutoSize()
        {
            LayersHandler.RefreshCellsAutoSize(DGVLayer, AdaptCellsSize);
        }
        public void SetFollowedForm(Form form, FormRelativeLayout relativeLayout)
        {
            FollowedForm = form ?? throw new ArgumentNullException(Exceptions.NULL_ARGUMENT + "(Form: " + Name + ")");
            FollowedFormRelativeLayout = relativeLayout;

            if (FollowedForm != null)
            {
                FollowedForm.Move -= FollowedForm_Move;
                FollowedForm.Resize -= FollowedForm_Move;
            }

            FollowedForm.Move += FollowedForm_Move;
            FollowedForm.Resize += FollowedForm_Move;
        }
        #endregion
    }
}
