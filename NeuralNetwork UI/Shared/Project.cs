using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
using NeuralNetwork_UI.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork_UI.Shared
{
    public class Project
    {
        public List<FeedforwardNetworkSHL> Networks { get; private set; } 
            = new List<FeedforwardNetworkSHL>();
        public List<NeuralNetworkInputProject> InputProjects { get; private set; } 
            = new List<NeuralNetworkInputProject>();

        public Project()
        {
            Networks = new List<FeedforwardNetworkSHL>();
            InputProjects = new List<NeuralNetworkInputProject>();
        }

        public int AddNetwork(FeedforwardNetworkSHL network)
        {
            Networks.Add(network);
            return Networks.Count() - 1;
        }
        public void AddInputProject(NeuralNetworkInputProject inputProject)
        {
            InputProjects.Add(inputProject);
        }

        public int NetworksCount
        {
            get
            {
                return Networks.Count();
            }
        }
        public int InputProjectsCount
        {
            get
            {
                return InputProjects.Count();
            }
        }
    }
}
