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
            //FeedforwardNetworkTests.Response1();
            //FeedforwardNetworkTests.Response2();
            //FeedforwardNetworkTests.Response3();
            //FeedforwardNetworkTests.PrintResponse();
            //FeedforwardNetworkTests.SetWeights();
            //FeedforwardNetworkTests.Learn0();
            //FeedforwardNetworkTests.Learn1();
            //FeedforwardNetworkTests.Learn2();
            //FeedforwardNetworkTests.Learn3();
            //FeedforwardNetworkTests.Normalize0();
            //FeedforwardNetworkTests.Learn4();
            FeedforwardNetworkTests.Learn5();

            //FeedforwardNetworkTests.XOR();
            //FeedforwardNetworkTests.OR();
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

            f.SetWeights(Layers.Hidden, 0, new double[] { 0.9, 0.3, 0.4 });
            f.SetWeights(Layers.Hidden, 1, new double[] { 0.2, 0.8, 0.2 });
            f.SetWeights(Layers.Hidden, 2, new double[] { 0.1, 0.5, 0.6 });

            f.SetWeights(Layers.Output, 0, new double[] { 0.3, 0.7, 0.5 });
            f.SetWeights(Layers.Output, 1, new double[] { 0.6, 0.5, 0.2 });
            f.SetWeights(Layers.Output, 2, new double[] { 0.8, 0.1, 0.9 });


            ShowNetwork(f);

            var rs = f.GetResponse(new double[] { 0.9, 0.1, 0.8 });

            Console.WriteLine("Response:");
            foreach (var r in rs)
                Console.Write(r + " ");
        }
        public static void Response2()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(3, 2, 1, Functions.Sigmoid);

            f.SetWeights(Layers.Hidden, 0, new double[] { 0.79, 0.44, 0.43 });
            f.SetWeights(Layers.Hidden, 1, new double[] { 0.85, 0.43, 0.29 });

            f.SetWeights(Layers.Output, 0, new double[] { 0.5, 0.52 });


            ShowNetwork(f);

            var rs = f.GetResponse(new double[] { 1, 1, 0 });

            Console.WriteLine("Response:");
            foreach (var r in rs)
                Console.Write(r + " ");
        }
        public static void Response3()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 3, 2, Functions.Sigmoid);

            f.SetWeights(Layers.Hidden, 0, new double[] { 0.3, 0.1 });
            f.SetWeights(Layers.Hidden, 1, new double[] { 0.2, 0.4 });
            f.SetWeights(Layers.Hidden, 2, new double[] { 0.6, 0.5 });

            f.SetWeights(Layers.Output, 0, new double[] { 0.7, 0.3, 0.5 });
            f.SetWeights(Layers.Output, 1, new double[] { 0.7, 0.1, 0.2 });

            ShowNetwork(f);

            var rs = f.GetResponse(new double[] { 0.3, 0.5 });

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
        public static void Learn0()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 2, 2);
            f.SetWeights(Layers.Hidden, 0, new double[] { 3, 2 });
            f.SetWeights(Layers.Hidden, 1, new double[] { 1, 7 });
            f.SetWeights(Layers.Output, 0, new double[] { 2, 3 });
            f.SetWeights(Layers.Output, 1, new double[] { 1, 4 });
            ShowNetwork(f);

            //0.9, 0.1, 0.8
        }
        public static void Learn1()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(3, 2, 1, Functions.Sigmoid);

            f.SetWeights(Layers.Hidden, 0, new double[] { 0.79, 0.44, 0.43 });
            f.SetWeights(Layers.Hidden, 1, new double[] { 0.85, 0.43, 0.29 });
            f.SetWeights(Layers.Output, 0, new double[] { 0.5, 0.52 });
            f.SetAllRandomWeights();

            ShowNetwork(f);

            double x = 0.01;
            double y = 0.9;

            ShowResponse(f, new double[] { x, x, x });

            for (int i = 0; i < 5000; i++)
            {
                f.Learn_Old(new double[] { x, x, x }, new double[] { x });
                f.Learn_Old(new double[] { x, x, y }, new double[] { y });
                f.Learn_Old(new double[] { x, y, x }, new double[] { x });
                f.Learn_Old(new double[] { x, y, y }, new double[] { y });
                f.Learn_Old(new double[] { y, x, x }, new double[] { x });
                f.Learn_Old(new double[] { y, x, y }, new double[] { y });
                f.Learn_Old(new double[] { y, y, x }, new double[] { x });
                f.Learn_Old(new double[] { y, y, y }, new double[] { y });
            }

            ShowNetwork(f);

            ShowResponse(f, new double[] { x, x, x });
            //ShowResponse(f, new double[] { 0.9, 0.9, 0.9 });
        }
        public static void Learn2()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 3, 2, Functions.Sigmoid);

            //f.SetWeights(Layers.Hidden, 0, new double[] { 0.3, 0.1 });
            //f.SetWeights(Layers.Hidden, 1, new double[] { 0.2, 0.4 });
            //f.SetWeights(Layers.Hidden, 2, new double[] { 0.6, 0.5 });
            //f.SetWeights(Layers.Output, 0, new double[] { 0.7, 0.3, 0.5 });
            //f.SetWeights(Layers.Output, 1, new double[] { 0.7, 0.1, 0.2 });
            f.SetAllRandomWeights();

            var in0 = new double[] { 0.7, 0.3 };
            var in1 = new double[] { 0.2, 0.6 };
            var out0 = new double[] { 0.5, 0.5 };
            var out1 = new double[] { 0.3, 0.9 };

            //ShowNetwork(f);
            ShowResponseAndError(f, in0, out0);
            ShowResponseAndError(f, in1, out1);

            for (int i = 0; i < 10000; i++)
            {
                f.Learn_Old(in0, out0);
                f.Learn_Old(in1, out1);
            }

            Console.WriteLine(new String('/', 100));
            Console.WriteLine("Learnt...");
            Console.WriteLine(new String('/', 100) + "\n");
            ShowResponseAndError(f, in0, out0, false);
            ShowResponseAndError(f, in1, out1, false);
            ShowNetwork(f);
        }
        public static void Learn3()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(5, 10, 1, Functions.Sigmoid);

            f.SetAllRandomWeights();

            // 10250 деталей
            // 327 деталей на холодос
            // 557 деталей в час
            // 5 работников
            double[][] inputData = new double[][]
            {
                new double[] { 10250, 327, 557, 5 },
                new double[] { 10250, 327, 557, 5 },
            };
            double[][] minValues = new double[][]
            {
                new double[] {  }
            };
            double[][] maxValues = new double[][]
            {
                new double[] {  }
            };
            double[][] outputData = new double[][]
            {
                new double[] { },
            };

            //ShowNetwork(f);
            ShowResponseAndError(f, inputData[0], outputData[0]);
            ShowResponseAndError(f, inputData[1], outputData[1]);

            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < inputData.Length; j++)
                    //f.LearnWithNormalization(inputData[j], outputData[j]);
                    f.Learn_Old(inputData[j], outputData[j]);
                NeuralNetworkService.Shuffle(inputData.ToList(), outputData.ToList(), random);
            }

            //ShowNetwork(f);
            Console.WriteLine(new String('/', 100));
            Console.WriteLine("Learnt...");
            Console.WriteLine(new String('/', 100) + "\n");
            ShowResponseAndError(f, inputData[0], outputData[0], false);
            ShowResponseAndError(f, inputData[1], outputData[1], false);
        }
        public static void Learn4()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(9, 19, 2, Functions.Sigmoid, 0.01);

            f.SetAllRandomWeights();

            double[][] inputData = new double[][]
            {
                new double[] { 30000, 93, 89, 15, 1.1, 1, 3, 300, 310 },
                new double[] { 60000, 93, 89, 15, 1.1, 1, 3, 600, 620 },
                new double[] { 15000, 93, 89, 15, 1.1, 1, 3, 150, 155 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 10, 300, 310 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 30, 300, 310 },
                new double[] { 10000, 93, 89, 15, 1.1, 1, 2, 100, 110 },
                new double[] { 10000, 93, 89, 10, 1.1, 1, 15, 100, 110 },
                new double[] { 15000, 93, 89, 10, 1.1, 1, 1, 100, 105 },
                new double[] { 1000, 93, 89, 10, 1.1, 1, 0, 9, 9 },
                new double[] { 1000, 93, 89, 10, 1.1, 1, 10, 9, 9 },
                new double[] { 15000, 100, 89, 15, 1.1, 1, 1, 150, 155 },
                new double[] { 15000, 100, 100, 15, 1.1, 1, 1, 150, 150 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 1, 190, 200 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 1, 100, 200 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 1, 50, 200 },
                new double[] { 20000, 100, 88, 15, 1.1, 1, 1, 200, 200 },
                new double[] { 20000, 100, 88, 15, 1.1, 1, 0, 200, 200 },
                new double[] { 15000, 100, 88, 15, 1.1, 1, 2, 50, 100 },
                new double[] { 10000, 88, 83, 15, 1.1, 1, 2, 40, 50 },
                new double[] { 5000, 88, 83, 15, 1.1, 1, 2, 40, 50 },
            };
            double[] minValues = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] maxValues = new double[] { 100000, 200, 200, 50, 5, 1.50, 100, 5000, 1000 };
            double[][] outputData = new double[][]
            {
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 0 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
            };
            double[][] testInputData = new double[][]
            {
                new double[] { 10000, 93, 89, 15, 1.1, 1, 3, 100, 110 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 3, 600, 120 },
            };
            double[][] testOutputData = new double[][]
            {
                new double[] { 1, 0 },
                new double[] { 0, 1 },
            };

            for (int i = 0; i < inputData.Length; i++)
            {
                inputData[i] = f.Normalize(inputData[i], minValues, maxValues);
            }
            for (int i = 0; i < testInputData.Length; i++)
            {
                testInputData[i] = f.Normalize(testInputData[i], minValues, maxValues);
            }

            //ShowNetwork(f);
            ShowResponseAndError(f, testInputData[0], testOutputData[0]);
            ShowResponseAndError(f, testInputData[1], testOutputData[1]);

            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < inputData.Length; j++)
                    //f.LearnWithNormalization(inputData[j], outputData[j]);
                    f.Learn(inputData[j], outputData[j]);
                NeuralNetworkService.Shuffle(inputData.ToList(), outputData.ToList(), random);
            }

            //ShowNetwork(f);
            Console.WriteLine(new String('/', 100));
            Console.WriteLine("Learnt...");
            Console.WriteLine(new String('/', 100) + "\n");
            ShowResponseAndError(f, testInputData[0], testOutputData[0], false);
            ShowResponseAndError(f, testInputData[1], testOutputData[1], false);
        }
        public static void Learn5()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(9, 19, 1, Functions.Sigmoid, 0.05);

            f.SetAllRandomWeights();

            double[][] inputData = new double[][]
            {
                new double[] { 30000, 93, 89, 15, 1.1, 1, 3, 300, 310 },
                new double[] { 60000, 93, 89, 15, 1.1, 1, 3, 600, 620 },
                new double[] { 15000, 93, 89, 15, 1.1, 1, 3, 150, 155 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 3, 300, 310 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 3, 300, 310 },
                new double[] { 10000, 93, 89, 15, 1.1, 1, 3, 100, 110 },
                new double[] { 10000, 93, 89, 10, 1.1, 1, 3, 100, 110 },
                new double[] { 15000, 93, 89, 10, 1.1, 1, 3, 100, 105 },
                new double[] { 1000, 93, 89, 10, 1.1, 1, 3, 9, 9 },
                new double[] { 1000, 93, 89, 10, 1.1, 1, 3, 9, 9 },
                new double[] { 15000, 100, 89, 15, 1.1, 1, 3, 150, 155 },
                new double[] { 15000, 100, 100, 15, 1.1, 1, 3, 150, 150 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 3, 190, 200 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 3, 100, 200 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 3, 50, 200 },
                new double[] { 20000, 100, 88, 15, 1.1, 1, 3, 200, 200 },
                new double[] { 20000, 100, 88, 15, 1.1, 1, 3, 200, 200 },
                new double[] { 15000, 100, 88, 15, 1.1, 1, 3, 50, 100 },
                new double[] { 10000, 88, 83, 15, 1.1, 1, 3, 40, 50 },
                new double[] { 5000, 88, 83, 15, 1.1, 1, 3, 40, 50 },

                new double[] { 30000, 93, 89, 15, 1.1, 1, 90, 300, 310 },
                new double[] { 60000, 93, 89, 15, 1.1, 1, 90, 600, 620 },
                new double[] { 15000, 93, 89, 15, 1.1, 1, 90, 150, 155 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 90, 300, 310 },
                new double[] { 30000, 93, 89, 15, 1.1, 1, 90, 300, 310 },
                new double[] { 10000, 93, 89, 15, 1.1, 1, 90, 100, 110 },
                new double[] { 10000, 93, 89, 10, 1.1, 1, 90, 100, 110 },
                new double[] { 15000, 93, 89, 10, 1.1, 1, 90, 100, 105 },
                new double[] { 1000, 93, 89, 10, 1.1, 1, 90, 9, 9 },
                new double[] { 1000, 93, 89, 10, 1.1, 1, 90, 9, 9 },
                new double[] { 15000, 100, 89, 15, 1.1, 1, 90, 150, 155 },
                new double[] { 15000, 100, 100, 15, 1.1, 1, 90, 150, 150 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 90, 190, 200 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 90, 100, 200 },
                new double[] { 20000, 90, 88, 15, 1.1, 1, 90, 50, 200 },
                new double[] { 20000, 100, 88, 15, 1.1, 1, 90, 200, 200 },
                new double[] { 20000, 100, 88, 15, 1.1, 1, 90, 200, 200 },
                new double[] { 15000, 100, 88, 15, 1.1, 1, 90, 50, 100 },
                new double[] { 10000, 88, 83, 15, 1.1, 1, 90, 40, 50 },
                new double[] { 5000, 88, 83, 15, 1.1, 1, 90, 40, 50 },
            };
            double[] minValues = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] maxValues = new double[] { 100000, 200, 200, 50, 5, 1.50, 100, 5000, 1000 };
            double[][] outputData = new double[][]
            {
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 0 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 1 },

                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
                new double[] { 0 },
            };

            for (int i = 0; i < inputData.Length; i++)
            {
                inputData[i] = f.Normalize(inputData[i], minValues, maxValues);
            }

            //ShowNetwork(f);
            ShowResponseAndError(f, inputData[0], outputData[0]);
            ShowResponseAndError(f, inputData[23], outputData[23]);

            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < inputData.Length; j++)
                    //f.LearnWithNormalization(inputData[j], outputData[j]);
                    f.Learn(inputData[j], outputData[j]);
                NeuralNetworkService.Shuffle(inputData.ToList(), outputData.ToList(), random);
            }

            Console.WriteLine(new String('/', 100));
            Console.WriteLine("Learnt...");
            Console.WriteLine(new String('/', 100) + "\n");
            ShowResponseAndError(f, inputData[0], outputData[0], false);
            ShowResponseAndError(f, inputData[23], outputData[23], false);
            ShowNetwork(f);
        }

        public static void XOR()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 5, 1, Functions.Sigmoid, 0.1);
            f.SetAllRandomWeights();

            double[][] inputData = new double[][]
            {
                new double[] { 0, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 1 },
            };
            double[][] outputData = new double[][]
            {
                new double[] { 0 },
                new double[] { 1 },
                new double[] { 1 },
                new double[] { 0 },
            };

            //ShowResponseAndError(f, inputData[0], outputData[0]);
            //ShowResponseAndError(f, inputData[1], outputData[1]);
            //ShowResponseAndError(f, inputData[2], outputData[2]);
            //ShowResponseAndError(f, inputData[3], outputData[3]);

            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < inputData.Length; j++)
                    f.Learn(inputData[j], outputData[j]);
                NeuralNetworkService.Shuffle(inputData.ToList(), outputData.ToList(), random);
            }

            //ShowNetwork(f);
            //Console.WriteLine(new String('/', 100));
            //Console.WriteLine("Learnt...");
            //Console.WriteLine(new String('/', 100) + "\n");
            ShowResponseAndError(f, inputData[0], outputData[0], false);
            ShowResponseAndError(f, inputData[1], outputData[1], false);
            ShowResponseAndError(f, inputData[2], outputData[2], false);
            ShowResponseAndError(f, inputData[3], outputData[3], false);

            //ShowNetwork(f);
        }
        public static void OR()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(2, 5, 1, Functions.Sigmoid, 0.1);
            f.SetAllRandomWeights();

            double[][] inputData = new double[][]
            {
                new double[] { 0, 0},
                new double[] { 1, 0},
                new double[] { 0, 1},
                new double[] { 1, 1},
            };
            double[][] outputData = new double[][]
            {
                new double[] { 0 },
                new double[] { 1 },
                new double[] { 1},
                new double[] { 1 },
            };

            //ShowNetwork(f);
            ShowResponseAndError(f, inputData[0], outputData[0]);
            ShowResponseAndError(f, inputData[1], outputData[1]);
            ShowResponseAndError(f, inputData[2], outputData[2]);
            ShowResponseAndError(f, inputData[3], outputData[3]);

            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < inputData.Length; j++)
                    f.Learn(inputData[j], outputData[j]);
                NeuralNetworkService.Shuffle(inputData.ToList(), outputData.ToList(), random);
            }

            //ShowNetwork(f);
            Console.WriteLine(new String('/', 100));
            Console.WriteLine("Learnt...");
            Console.WriteLine(new String('/', 100) + "\n");
            ShowResponseAndError(f, inputData[0], outputData[0], false);
            ShowResponseAndError(f, inputData[1], outputData[1], false);
            ShowResponseAndError(f, inputData[2], outputData[2], false);
            ShowResponseAndError(f, inputData[3], outputData[3], false);
        }

        public static void Normalize0()
        {
            FeedforwardNetworkSHL f = new FeedforwardNetworkSHL(5, 10, 1, Functions.Sigmoid);

            f.SetAllRandomWeights();

            double[] signals = new double[] { 10250, 327, 557, 5 };
            double[] minValues = new double[] { 100, 10, 35, 0 };
            double[] maxValues = new double[] { 23000, 500, 999, 10 };

            f.GetResponseWithNormalization(signals, minValues, maxValues);
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
        public static void ShowResponse(FeedforwardNetworkSHL f, double[] signals)
        {
            var rs = f.GetResponse(signals);

            Console.WriteLine(new String('*', 50));

            Console.Write("Input: ");
            Array.ForEach(signals, x => Console.Write(x + "  "));
            Console.WriteLine();

            Console.WriteLine("Response:");
            foreach (var r in rs)
                Console.Write(r + " ");
            Console.WriteLine("\n");
            Console.Write(new String('*', 50));
            Console.WriteLine("\n");
        }
        public static void ShowResponseAndError(FeedforwardNetworkSHL f, double[] signals, double[] expectedOutputs, bool round = true)
        {
            var rs = f.GetResponse(signals);

            Console.WriteLine(new String('*', 50));

            Console.Write("Input: ");
            Array.ForEach(signals, x => Console.Write(x + "  "));
            Console.WriteLine();

            Console.WriteLine("Response:");
            foreach (var r in rs)
                Console.Write(r + " ");
            Console.WriteLine();

            var errors = f.GetErrors(signals, expectedOutputs);
            Console.WriteLine("Errors:");
            foreach (var e in errors)
            {
                if (round)
                    Console.Write("{0:#.##} ", e);
                else
                    Console.Write(e + " ");
            }
            Console.WriteLine("");

            Console.Write(new String('*', 50));
            Console.WriteLine("\n");
        }
        public static void ShowXOR(FeedforwardNetworkSHL f, double[] signals, double[] expectedOutputs, bool round = true)
        {
            var rs = f.GetResponse(signals);

            Console.WriteLine(signals[0] + " XOR " + signals[1] + " = " + rs[0]);
        }

    }

    static class NeuralNetworkInputProjectTests
    {
        public static void CtorTest()
        {
            FeedforwardNetworkSHL network = new FeedforwardNetworkSHL(3, 4, 2);
            NeuralNetworkInputProject inputProject = new NeuralNetworkInputProject("Test name", network);

            Console.WriteLine(inputProject.Network.InputLayerSize);
            Console.WriteLine(inputProject.Network.OutputLayerSize);
        }
        public static void CreatingFieldsTest()
        {
            FeedforwardNetworkSHL network = new FeedforwardNetworkSHL(3, 4, 2);
            NeuralNetworkInputProject inputProject = new NeuralNetworkInputProject("Test name", network);

            inputProject.CreateField(Layers.Input, "MyField", "MyField", network[Layers.Input][0]);

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