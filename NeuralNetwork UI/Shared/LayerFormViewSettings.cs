using NeuralNetwork_UI.Forms.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_UI.Shared
{
    public class LayerFormViewSettings
    {
        public bool AdaptCellsSize { get; set; } = true;
        public int DecimalPlaces { get; set; } = 2;
        public Font Font { get; set; } = new Font("Consolas", 13, GraphicsUnit.Point);
        [Browsable(false)]
        public Form FollowedForm { get; set; }
        [Browsable(false)]
        public FormRelativeLayout FollowedFormRelativeLayout { get; set; }
    }
}
