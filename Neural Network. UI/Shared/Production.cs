using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.UI.Shared
{
    [Serializable]
    public class Production
    {
        public String Name { get; set; }
        public NeuralNetworkInputProject InputProject { get; set; }
        public FeedforwardNetworkSHL OrderingNetwork;
        public FeedforwardNetworkSHL ForecastingNetwork;
    }
}