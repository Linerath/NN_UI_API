using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;
using NeuralNetwork_UI.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork_UI.Shared
{
    [Serializable]
    public class Project
    {
        public List<FeedforwardNetworkSHL> Networks { get; private set; }
        public List<NeuralNetworkInputProject> InputProjects { get; private set; }
        public String FilePath { get; set; } = null;

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
                if (TrySaveTo(FilePath))
                    return true;
                else
                    return false;
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
    }
}
