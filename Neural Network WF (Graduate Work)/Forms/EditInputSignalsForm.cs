using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural_Network.Core.Implementation;
using Neural_Network_WF__Graduate_Work_.Repository;

namespace Neural_Network_WF__Graduate_Work_.Forms
{
    public partial class EditInputSignalsForm : Form
    {
        private double[] signals;

        public EditInputSignalsForm(double[] signals)
        {
            this.signals = signals;

            InitializeComponent();
        }

        #region Events
        private void EditInputSignalsForm_Load(object sender, EventArgs e)
        {
            UpdateNetwork(true);
        }
        private void DGVInputSignals_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateNetwork();
        }
        private void CBAdaptCellSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCellsAutoSize();
        }
        private void NUDFontSize_ValueChanged(object sender, EventArgs e)
        {
            UpdateNetwork();
        }
        private void BGo_Click(object sender, EventArgs e)
        {
            if (NeuralNetwork.Network == null || signals == null)
                return;

            double[] response = NeuralNetwork.Network.GetResponse(signals);
            String str = "";
            foreach (var s in response)
                str += s + ";\n";
            MessageBox.Show("Response:\n" + str);
        }
        #endregion

        #region Methods
        private void UpdateNetwork(bool rewriteValues = false)
        {
            DGVInputSignals.RowCount = 1;
            DGVInputSignals.ColumnCount = NeuralNetwork.Network[0].Count();

            if (rewriteValues)
            {
                for (int i = 0; i < signals.Count(); i++)
                    DGVInputSignals[i, 0].Value = signals[i];
            }

            UpdateFontSize();
            UpdateCellsAutoSize();

            int width = 0;
            foreach (DataGridViewColumn col in DGVInputSignals.Columns)
            {
                width += col.Width;
            }

            if (CBAdaptFormSize.Checked)
                ClientSize = new Size(width + 5, ClientSize.Height);
        }
        private void UpdateFontSize()
        {
            foreach (DataGridViewColumn col in DGVInputSignals.Columns)
            {
                col.DefaultCellStyle.Font = new Font("Consolas", (int)NUDFontSize.Value, GraphicsUnit.Pixel);
            }
        }
        private void UpdateCellsAutoSize()
        {
            foreach (DataGridViewColumn col in DGVInputSignals.Columns)
            {
                if (CBAdaptCellSize.Checked)
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
        #endregion
    }
}
