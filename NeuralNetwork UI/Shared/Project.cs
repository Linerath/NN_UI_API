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
    public static class Project
    {
        public static List<FeedforwardNetworkSHL> Networks { get; private set; } 
            = new List<FeedforwardNetworkSHL>();
        public static List<NeuralNetworkInputProject> InputProjects { get; private set; } 
            = new List<NeuralNetworkInputProject>();

        public static void CreateNewProject()
        {
            Networks = new List<FeedforwardNetworkSHL>();
            InputProjects = new List<NeuralNetworkInputProject>();
        }

        public static int AddNetwork(FeedforwardNetworkSHL network)
        {
            Networks.Add(network);
            return Networks.Count() - 1;
        }
        public static void AddInputProject(NeuralNetworkInputProject inputProject)
        {
            InputProjects.Add(inputProject);
        }

        public static int NetworksCount
        {
            get
            {
                return Networks.Count();
            }
        }
        public static int InputProjectsCount
        {
            get
            {
                return InputProjects.Count();
            }
        }
    }
}
