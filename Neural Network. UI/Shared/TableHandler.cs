using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Shared
{
    public static class TableHandler
    {
        public static void RefreshCellsAutoSize(DataGridView dataGridView, TableViewSettings ViewSettings)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (ViewSettings.AdaptCellsSize)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    int oldWidth = col.Width;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Width = oldWidth;
                }
            }
        }

        public static void RefreshFont(DataGridView dataGridView, TableViewSettings ViewSettings)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.DefaultCellStyle.Font = ViewSettings.Font;
            }
        }

        public static void RefreshTableResize(DataGridView dataGridView, TableViewSettings viewSettings)
        {

        }
    }
}