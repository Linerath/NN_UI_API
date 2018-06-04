using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
using Neural_Network.UI.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.UI.Shared
{
    [Serializable]
    public class Project
    {
        public String Name { get; set; }
        public List<FeedforwardNetworkSHL> Networks { get; private set; }
        public List<NeuralNetworkInputProject> InputProjects { get; private set; }
        public List<Production> ProductionProjects { get; private set; }
        public String FilePath { get; set; } = null;

        public Project(String name = "UnnamedProj")
        {
            Name = String.IsNullOrWhiteSpace(name) ? "UnnamedProj" : name;

            Networks = new List<FeedforwardNetworkSHL>();
            InputProjects = new List<NeuralNetworkInputProject>();
            ProductionProjects = new List<Production>();
        }

        public int AddNetwork(FeedforwardNetworkSHL network)
        {
            Networks.Add(network);
            return Networks.Count() - 1;
        }
        public int AddInputProject(NeuralNetworkInputProject inputProject)
        {
            InputProjects.Add(inputProject);
            return InputProjects.Count() - 1;
        }
        public int AddProductionProject(Production production)
        {
            ProductionProjects.Add(production);
            return ProductionProjects.Count() - 1;
        }

        public bool TryOpen(String filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    object obj = bf.Deserialize(fs);
                    if (obj is Project prj)
                    {
                        UIRepository.Project = prj;
                        UIRepository.Project.FilePath = filePath;
                    }
                    else
                    {
                        throw new NotSupportedException(Exceptions.INVALID_PROJ_FILE);
                    }
                }
            }
            catch (NotSupportedException e)
            {
                System.Windows.Forms.MessageBox.Show("NotSupportedException. Reason: " + e.Message, "Error");
                FilePath = null;
                return false;
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("IOException. Reason: " + e.Message, "Error");
                FilePath = null;
                return false;
            }
            catch (SerializationException e)
            {
                System.Windows.Forms.MessageBox.Show("Serialization exception. Reason: " + e.Message, "Error");
                FilePath = null;
                return false;
            }
            return true;
        }
        public bool TrySave()
        {
            if (FilePath != null)
            {
                return TrySaveTo(FilePath);
            }
            return false;
        }
        public bool TrySaveTo(String filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    bf.Serialize(fs, this);
                }
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("IOException. Reason: " + e.Message, "Error");
                FilePath = null;
                return false;
            }
            catch (SerializationException e)
            {
                System.Windows.Forms.MessageBox.Show("Serialization exception. Reason: " + e.Message, "Error");
                FilePath = null;
                return false;
            }
            FilePath = filePath;
            return true;
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
        public int ProductionProjectsCount
        {
            get
            {
                return ProductionProjects.Count();
            }
        }
    }
}
