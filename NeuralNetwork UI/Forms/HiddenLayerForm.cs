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
    public partial class HiddenLayerForm : Form
    {
        #region View settings
        public int FontSize { get; set; } = 17;
        public bool AdaptCellsSize { get; set; } = true;
        public int DecimalPlaces { get; set; } = 2;
        public Form FollowedForm { get; set; }
        public FormRelativeLayout FollowedFormRelativeLayout { get; set; }
        #endregion

        public HiddenLayerForm()
        {
            InitializeComponent();
        }

        #region Events
        private void InputLayerForm_Load(object sender, EventArgs e)
        {
        }
        private void FollowedForm_Move(object sender, EventArgs e)
        {
            if (FollowedForm == null)
                return;

            switch (FollowedFormRelativeLayout)
            {
                case FormRelativeLayout.TopLeft:
                    break;
                case FormRelativeLayout.TopRight:
                    break;

                case FormRelativeLayout.RightTop:
                    Location = new Point(FollowedForm.Location.X + FollowedForm.ClientSize.Width, FollowedForm.Location.Y);
                    break;
                case FormRelativeLayout.RightBottom:
                    break;

                case FormRelativeLayout.BottomLeft:
                    break;
                case FormRelativeLayout.BottomRight:
                    break;

                case FormRelativeLayout.LeftTop:
                    Location = new Point(FollowedForm.Location.X - ClientSize.Width, FollowedForm.Location.Y);
                    break;
                case FormRelativeLayout.LeftBottom:
                    break;
            }
        }
        #endregion

        #region Methods
        public void FullLayerRefresh()
        {
            LayersHandler.RefreshLayerValues(DGVLayer, Neural_Network.Core.Implementation.Layers.Hidden, DecimalPlaces, true);
            LayersHandler.RefreshFontSize(DGVLayer, FontSize);
            LayersHandler.RefreshCellsAutoSize(DGVLayer, AdaptCellsSize);
        }
        public void RefreshLayerValues(bool rewriteValues = false)
        {
            LayersHandler.RefreshLayerValues(DGVLayer, Neural_Network.Core.Implementation.Layers.Hidden, DecimalPlaces, rewriteValues);
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
                FollowedForm.Move -= FollowedForm_Move;

            FollowedForm.Move += FollowedForm_Move;
        }
        #endregion
    }
}
