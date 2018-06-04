using Neural_Network.UI.Constants.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Shared
{
    public enum NeuronsSorting
    {
        Vertical,
        Horizontal
    }

    public class TableViewSettings
    {
        [Category("Appearance")]
        [DisplayName("Adapt cells size")]
        public bool AdaptCellsSize { get; set; } = true;

        [Category("Appearance")]
        [DisplayName("Decimal places")]
        public int DecimalPlaces { get; set; } = 2;

        [Category("Appearance")]
        public Font Font { get; set; } = new Font("Consolas", 13, GraphicsUnit.Point);

        [Category("Appearance")]
        public NeuronsSorting NeuronsSorting { get; set; } = NeuronsSorting.Horizontal;

        [Category("Appearance")]
        [DisplayName("Input table anchor")]
        public AnchorStyles InputTableAnchor { get; set; } = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

        [Category("Appearance")]
        [DisplayName("Hidden table anchors")]
        public AnchorStyles[] HiddenTableAnchors { get; set; } = new AnchorStyles[] { AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left };

        [Category("Appearance")]
        [DisplayName("Output table anchor")]
        public AnchorStyles OutputTableAnchor { get; set; } = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
    }
}
