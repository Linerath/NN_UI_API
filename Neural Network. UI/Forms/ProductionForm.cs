using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural_Network.UI.Forms
{
    public partial class ProductionForm : Form
    {
        private int orderingNetworkIndex;
        private int forecastingNetworkIndex;

        public ProductionForm(int? orderingNetworkIndex, int? forecastingNetworkIndex)
        {
            InitializeComponent();

            this.orderingNetworkIndex = orderingNetworkIndex ?? -1;
            this.forecastingNetworkIndex = forecastingNetworkIndex ?? -1;
        }

        #region Events
        #endregion

        #region Methods
        #endregion
    }
}
