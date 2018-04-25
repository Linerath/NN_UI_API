using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.Core.Abstract
{
    public interface INeuralNetwork
    {
        void SetAllRandomWeights();
        void Normalize(double[] signals);
        double[] GetResponse(double[] signals);
    }
}