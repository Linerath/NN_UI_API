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
        double Normalize(double signal, double minValue, double maxValue, double intervalMin = 0, double intervalMax = 1);
        double[] GetResponse(double[] signals);
    }
}