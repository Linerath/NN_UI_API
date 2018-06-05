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
}