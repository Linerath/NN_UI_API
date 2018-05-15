using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neural_Network.Core;
using Neural_Network.Core.Extra;
using Neural_Network.Core.Implementation;

namespace Neural_Network.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NeuronTests
            //NeuronTests.CtorTest();
            //NeuronTests.RandomizeTest();
            //NeuronTests.IndexerTest();
            //NeuronTests.SetWeights();
            //NeuronTests.ResponseTest();
            //NeuronTests.ResponseWithFuncTest();
            //NeuronTests.ResizeTest();
            #endregion

            #region FeedforwardNetworkTests
            //FeedforwardNetworkTests.Ctor();
            //FeedforwardNetworkTests.SetRandom();
            //FeedforwardNetworkTests.Response0();
            FeedforwardNetworkTests.Response1();
            //FeedforwardNetworkTests.PrintResponse();
            //FeedforwardNetworkTests.SetWeights();
            #endregion

            #region NeuralNetworkInputProjectTests
            //NeuralNetworkInputProjectTests.CtorTest();
            //NeuralNetworkInputProjectTests.CreatingFieldsTest();
            #endregion

            #region NeuralNetworkServiceTests
            //NeuralNetworkServiceTests.GetInputProjectsTest();
            #endregion

            ConsoleKeyInfo key;
            while ((key = Console.ReadKey()).KeyChar != 'q')
            {
                Console.WriteLine();

            }
        }
    }

    static class NeuronTests
    {
        public static void CtorTest()
        {
            Neuron neuron = new Neuron(5);
            Console.WriteLine(neuron.InputCount);
            Console.WriteLine(neuron[-1]);
        }
        public static void RandomizeTest()
        {
            Neuron neuron = new Neuron(5);
            Random random = new Random();
            neuron.SetRandomWeights(random, 0.1, 0.9);

            ShowPatternArray(neuron.GetWeights());
        }
        public static void IndexerTest()
        {
            Neuron n = new Neuron(5);
            var w = n.GetWeights();
            w[0] = 228;

            n[1] = 228;
            w = n.GetWeights();
            ShowArray(w);
        }
        public static void SetWeights()
        {
            Neuron n = new Neuron(5);
            n.SetWeights(null);
            n.SetWeights(new double[] { 0.1, 0.1 });
            n.SetWeights(new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 });
            var w = n.GetWeights();
            ShowArray(w);
        }
        public static void ResponseTest()
        {
            Neuron n = new Neuron(5);

            double[] signals = { 0.1, 0.1, 0.1, 0.1, 0.1 };

            n.SetWeights(new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 });

            //n.GetResponse(new double[] {0.1});
            double r = n.GetResponse(new double[] { 0.1, 0.2, 0.3, 0.4, 0.5 });

            Console.WriteLine(r);
        }
        public static void ResponseWithFuncTest()
        {
            Neuron n = new Neuron(5, Functions.Sigmoid);

            double[] signals = { 0.1, 0.1, 0.1, 0.1, 0.1 };

            n.SetWeights(new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 });

            //n.GetResponse(new double[] { 0.1 });
            double r = n.GetResponse(new double[] { 0.1, 0.2, 0.3, 0.4, 0.5 });

            Console.WriteLine(r);
        }
        public static void ResizeTest()
        {
            var n = new Neuron(5);
            Random random = new Random();
            n.SetRandomWeights(random, 0.1, 0.9);

            ShowArray(n.GetWeights());
            n.Resize(10);

            ShowArray(n.GetWeights());
        }


        public static void ShowPatternArray(double[] weights)
        {
            for (int i = 0; i < weights.Length; i++)
            {
                Console.Write("{0:##.####} ", weights[i]);
            }
            Console.WriteLine();
        }
        public static void ShowArray(double[] weights)
        {
            for (int i = 0; i < weights.Length; i++)
            {
                Console.Write("{0} ", weights[i]);
            }
            Console.WriteLine();
        }
    }

    static class FeedforwardNetworkTests
    {
        public static void Ctor()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 3, 1);

            ShowNetwork(f);
        }
        public static void SetRandom()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 3, 1);
            f.SetAllRandomWeights();

            ShowNetwork(f);
        }
        public static void Response0()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 3, 1);
            f.SetAllRandomWeights();

            ShowNetwork(f);

            var rs = f.GetResponse(new double[] { 0.1, 0.1 });

            Console.WriteLine("Response:");
            foreach (var r in rs)
                Console.Write(r + " ");
        }
        public static void Response1()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(3, 3, 3, Functions.Sigmoid);
            
            f.SetWeights(Layers.Hidden, 0, new double[]{ 0.9, 0.3, 0.4 });
            f.SetWeights(Layers.Hidden, 1, new double[]{ 0.2, 0.8, 0.2 });
            f.SetWeights(Layers.Hidden, 2, new double[]{ 0.1, 0.5, 0.6 });

            f.SetWeights(Layers.Output, 0, new double[] { 0.3, 0.7, 0.5 });
            f.SetWeights(Layers.Output, 1, new double[] { 0.6, 0.5, 0.2 });
            f.SetWeights(Layers.Output, 2, new double[] { 0.8, 0.1, 0.9 });


            ShowNetwork(f);

            var rs = f.GetResponse(new double[] { 0.9, 0.1, 0.8 });

            Console.WriteLine("Response:");
            foreach (var r in rs)
                Console.Write(r + " ");
        }
        public static void PrintResponse()
        {
            StreamWriter sw = new StreamWriter(@"E:\net.txt");
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 3, 1);
            f.SetAllRandomWeights();

            PrintNetwork(f, sw);

            var rs = f.GetResponse(new double[] { 0.1, 0.1 });

            sw.WriteLine("Response:");
            foreach (var r in rs)
                sw.Write(r + " ");
            sw.Close();
        }
        public static void SetWeights()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(3, 3, 3);

            f.SetAllRandomWeights();
            ShowNetwork(f);
            //f.SetWeights(Layers.Hidden, 0, new double[] { 0.9, 0.3, 0 });
            //f.SetWeights(Layers.Hidden, 0, new double[] { });
            //f.SetWeights(Layers.Hidden, 0, new double[] { 0.9, 0.3, 0, 228, 1337 });
            //f.SetWeights(Layers.Hidden, 0, null);

            f.SetWeights(Layers.Output, 0, new double[] { 0.9, 0.3, 0 });
            //f.SetWeights(Layers.Output, 0, new double[] { });
            //f.SetWeights(Layers.Output, 0, new double[] { 0.9, 0.3, 0, 228, 1337 });
            //f.SetWeights(Layers.Output, 0, null);
            ShowNetwork(f);
        }

        public static void PrintNetwork(FeedforwardNetworkSHL n, StreamWriter sw)
        {
            sw.WriteLine(new String('-', 100));

            sw.WriteLine("\nInput layer:");
            PrintLayer(n[Layers.Input], sw);
            sw.WriteLine("Hidden layer:");
            PrintLayer(n[Layers.Hidden], sw);
            sw.WriteLine("Output layer:");
            PrintLayer(n[Layers.Output], sw);

            sw.WriteLine(new String('-', 100));

        }
        public static void PrintLayer(Neuron[] layer, StreamWriter sw)
        {
            foreach (var v in layer)
            {
                sw.Write("(");
                var ws = v.GetWeights();
                for (int i = 0; i < ws.Length; i++)
                {
                    sw.Write(ws[i]);
                    if (i != ws.Length - 1)
                        sw.Write(", ");
                }
                sw.Write(")\t");
            }
            sw.WriteLine("\n");
        }
        public static void ShowNetwork(FeedforwardNetworkSHL n)
        {
            Console.WriteLine(new String('-', 100));

            Console.WriteLine("\nInput layer:");
            ShowLayer(n[Layers.Input]);
            Console.WriteLine("Hidden layer:");
            ShowLayer(n[Layers.Hidden]);
            Console.WriteLine("Output layer:");
            ShowLayer(n[Layers.Output]);

            Console.WriteLine(new String('-', 100));
        }
        public static void ShowLayer(Neuron[] layer)
        {
            foreach (var v in layer)
            {
                Console.Write("(");
                var ws = v.GetWeights();
                for (int i = 0; i < ws.Length; i++)
                {
                    Console.Write(ws[i]);
                    if (i != ws.Length - 1)
                        Console.Write(", ");
                }
                Console.Write(")\t");
            }
            Console.WriteLine("\n");
        }
    }

    static class NeuralNetworkInputProjectTests
    {
        public static void CtorTest()
        {
            FeedforwardNetworkSHL network = new FeedforwardNetworkSHL(3, 4, 2);
            NeuralNetworkInputProject inputProject = new NeuralNetworkInputProject("Test name", network);

            Console.WriteLine(inputProject.InputFieldsCount);
            Console.WriteLine(inputProject.OutputFieldsCount);
        }
        public static void CreatingFieldsTest()
        {
            FeedforwardNetworkSHL network = new FeedforwardNetworkSHL(3, 4, 2);
            NeuralNetworkInputProject inputProject = new NeuralNetworkInputProject("Test name", network);

            inputProject.CreateField(Layers.Input, "MyField", 0);

            //var f = inputProject[Layers.Input, 1];
            //Console.WriteLine(f.Name + " " + f.NeuronIndex);
        }
    }

    static class NeuralNetworkServiceTests
    {
        public static void GetInputProjectsTest()
        {
            FeedforwardNetworkSHL network0 = new FeedforwardNetworkSHL("Mynet", 3, 4, 2);
            FeedforwardNetworkSHL network1 = new FeedforwardNetworkSHL("iNet", 3, 4, 2);
            FeedforwardNetworkSHL network2 = new FeedforwardNetworkSHL("SkyNet", 3, 4, 2);

            NeuralNetworkInputProject[] inputProjects = new NeuralNetworkInputProject[]
            {
                new NeuralNetworkInputProject("MyProj0", network0),
                new NeuralNetworkInputProject("MyProj1", network0),
                new NeuralNetworkInputProject("iProj", network1),
                new NeuralNetworkInputProject("SkyProj", network2),
            };

            var projects = NeuralNetworkService.GetInputProjectsForNetwork(inputProjects, network0);
            foreach (var proj in projects)
            {
                Console.WriteLine(proj.Network.Name + " " + proj.Name);
            }
        }
    }
}