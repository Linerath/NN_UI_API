using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Neural_Network.UI.Shared.Controls
{
    public class NonFocusButton : Button
    {
        public NonFocusButton()
        {
            SetStyle(ControlStyles.Selectable, false);
            Size = new Size(34, 30);
            FlatStyle = FlatStyle.Flat;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 229, 229);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
            FlatAppearance.BorderSize = 0;
        }
    }
}