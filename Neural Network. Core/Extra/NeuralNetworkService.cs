using Neural_Network.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.Core.Extra
{
    public static class NeuralNetworkService
    {
        public static NeuralNetworkInputProject[] GetInputProjectsForNetwork(NeuralNetworkInputProject[] inputProjects, FeedforwardNetworkSHL network)
        {
            if (inputProjects == null || network == null)
                return null;

            List<NeuralNetworkInputProject> projects = new List<NeuralNetworkInputProject>();
            
            foreach (var proj in inputProjects)
            {
                if (network == proj.Network)
                    projects.Add(proj);
            }

            return projects.ToArray();
        }
    }
}