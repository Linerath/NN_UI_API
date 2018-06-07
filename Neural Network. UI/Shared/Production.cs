using Neural_Network.Core;
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
        public List<NeuralNetworkInputProject> InputProjects { get; set; }
        public List<NetworkOutput> NetworksOutputs { get; set; }
        private double[] inputValues;

        public double[] InputValues
        {
            get
            {
                return inputValues;
            }
            set
            {
                inputValues = value;
                foreach (var proj in InputProjects)
                    proj.SetInput(value);
            }
        }
    }

    [Serializable]
    public class NetworkOutput
    {
        public NetworkFunction NetworkFunction { get; set; }
        public String Description { get; set; }
        public int OutputCount { get; set; }
    }

    public enum NetworkFunction
    {
        FailureChance,
        AssessmentOfCompleting,
        SaleChance,
    }
}