using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.Core.Abstract
{
    public interface INeuron
    {
        double GetResponse(double[] signals);
        double[] GetWeights();
        void SetWeights(double[] weights);
        void SetRandomWeights(Random random, double minValue, double maxValue);
    }
}
