using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Shared.Controls
{
    public class FocusedTreeView : TreeView
    {
        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            TreeNodeStates treeState = e.State;
            Font treeFont = e.Node.NodeFont ?? e.Node.TreeView.Font;

            // Colors.
            Color foreColor = e.Node.ForeColor;
            string strDeselectedColor = @"#6B6E77", strSelectedColor = @"#94C7FC";
            Color selectedColor = ColorTranslator.FromHtml(strSelectedColor);
            Color deselectedColor = ColorTranslator.FromHtml(strDeselectedColor);

            // New brush.
            SolidBrush selectedTreeBrush = new SolidBrush(selectedColor);
            SolidBrush deselectedTreeBrush = new SolidBrush(deselectedColor);

            // Set default font color.
            if (foreColor == Color.Empty)
                foreColor = e.Node.TreeView.ForeColor;

            // Draw bounding box and fill.
            if (e.Node == e.Node.TreeView.SelectedNode)
            {
                // Use appropriate brush depending on if the tree has focus.
                if (Focused)
                {
                    foreColor = SystemColors.HighlightText;
                    e.Graphics.FillRectangle(selectedTreeBrush, e.Bounds);
                    ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, foreColor, SystemColors.Highlight);
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                                 foreColor, TextFormatFlags.GlyphOverhangPadding);
                }
                else
                {
                    foreColor = SystemColors.HighlightText;
                    e.Graphics.FillRectangle(deselectedTreeBrush, e.Bounds);
                    ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, foreColor, SystemColors.Highlight);
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                                 foreColor, TextFormatFlags.GlyphOverhangPadding);
                }
            }
            else
            {
                if ((e.State & TreeNodeStates.Hot) == TreeNodeStates.Hot)
                {
                    e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont, e.Bounds,
                                                 Color.Black, TextFormatFlags.GlyphOverhangPadding);
                }
                else
                {
                    e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                    TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                                 foreColor, TextFormatFlags.GlyphOverhangPadding);
                }
            }
        }
    }
}
