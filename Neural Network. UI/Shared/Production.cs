﻿using Neural_Network.Core;
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
        public double[] Input { get; private set; }
        public double[] AdditionalInput { get; private set; }
        public double[] Output { get; private set; }

        public void SetInput(double[] commonInput = null, double[] additionalInput = null, bool recalculate = true)
        {
            if (commonInput != null)
                Input = commonInput;
            if (additionalInput != null)
                AdditionalInput = additionalInput;
            if (recalculate)
            {
                double[] signals = Input.Concat(AdditionalInput).ToArray();
                foreach (var v in InputProjects)
                    Output = v.SetInput(signals);
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