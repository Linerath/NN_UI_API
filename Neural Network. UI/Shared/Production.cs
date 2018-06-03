using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.UI.Shared
{
    public class Production
    {
        public String Name { get; set; }
        public int Details;
        public int Speed;
        public int Employees;
        public int Rhythm;
        public int Tact;
        public int? OrderingNetworkIndex;
        public int? ForecastingNetworkIndex;
    }
}