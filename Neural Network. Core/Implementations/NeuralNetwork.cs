using Neural_Network.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.Core.Implementation
{
    public enum NetsTypes
    {
        SingleLayerPerceptron,
        MultilayerPerceptron
    }

    public enum Layers
    {
        Input,
        Hidden,
        Output
    }

    [Serializable]
    public sealed class FeedforwardNetworkSHL : INeuralNetwork
    {
        public String Name { get; set; }
        public readonly DateTime CreationDate;
        public readonly NetsTypes NetType;

        private List<Neuron> inputLayer;
        private List<Neuron> hiddenLayer;
        private List<Neuron> outputLayer;

        private double learningRate;
        public int LearningEpochs { get; private set; }

        public const double RANDOM_MIN_VALUE = 0.01;
        public const double RANDOM_MAX_VALUE = 0.99;

        public FeedforwardNetworkSHL(String name, int inputLayerSize, int hiddenLayerSize, int outputLayerSize, Functions activationFunction = Functions.Sigmoid, double learningRate = 0.02)
            : this(inputLayerSize, hiddenLayerSize, outputLayerSize, activationFunction, learningRate)
        {
            Name = name;
        }
        public FeedforwardNetworkSHL(int inputLayerSize, int hiddenLayerSize, int outputLayerSize, Functions activationFunction = Functions.None, double learningRate = 0.1)
        {
            if (inputLayerSize < 1 || hiddenLayerSize < 1 || outputLayerSize < 1)
                throw new ArgumentException("Layer size cannot be less than 1.");

            inputLayer = new List<Neuron>(inputLayerSize);
            hiddenLayer = new List<Neuron>(hiddenLayerSize);
            outputLayer = new List<Neuron>(outputLayerSize);

            for (int i = 0; i < inputLayerSize; i++)
            {
                inputLayer.Add(new Neuron(1, activationFunction));
                inputLayer[i][0] = 1;
            }
            for (int i = 0; i < hiddenLayerSize; i++)
            {
                hiddenLayer.Add(new Neuron(inputLayerSize, activationFunction));
            }
            for (int i = 0; i < outputLayerSize; i++)
            {
                outputLayer.Add(new Neuron(hiddenLayerSize, activationFunction));
            }

            this.learningRate = learningRate;

            CreationDate = DateTime.Now;
            NetType = NetsTypes.SingleLayerPerceptron;
            LearningEpochs = 0;
        }

        #region Tested
        public void SetAllRandomWeights()
        {
            Random random = new Random();
            foreach (var neuron in hiddenLayer)
                neuron.SetRandomWeights(random, RANDOM_MIN_VALUE, RANDOM_MAX_VALUE);
            foreach (var neuron in outputLayer)
                neuron.SetRandomWeights(random, RANDOM_MIN_VALUE, RANDOM_MAX_VALUE);
        }
        public void SetWeights(Layers layer, int neuronIndex, double[] weights)
        {
            if (weights == null)
                throw new ArgumentNullException("Weights");

            int length = weights.Length;
            switch (layer)
            {
                case Layers.Hidden:
                    if (neuronIndex < 0 || neuronIndex >= HiddenLayerSize)
                        throw new IndexOutOfRangeException("Index out of range (neuronIndex)");
                    hiddenLayer[neuronIndex].SetWeights(weights);
                    break;
                case Layers.Output:
                    if (neuronIndex < 0 || neuronIndex >= OutputLayerSize)
                        throw new IndexOutOfRangeException("Index out of range (neuronIndex)");
                    outputLayer[neuronIndex].SetWeights(weights);
                    break;
            }
        }
        #endregion

        #region Not tested
        public double[] GetResponse(double[] signals)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");

            double[] hiddenLayerSignals = new double[HiddenLayerSize];
            for (int i = 0; i < HiddenLayerSize; i++)
            {
                hiddenLayerSignals[i] = hiddenLayer[i].GetResponse(signals);
            }

            double[] outputLayerSignals = new double[OutputLayerSize];
            for (int i = 0; i < OutputLayerSize; i++)
            {
                outputLayerSignals[i] = outputLayer[i].GetResponse(hiddenLayerSignals);
            }

            return outputLayerSignals;
        }
        public double[] GetResponseWithNormalization(double[] signals, double[] minValues, double[] maxValues, double intervalMin = 0, double intervalMax = 1)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");
            if (minValues == null)
                throw new ArgumentNullException("minValues");
            if (maxValues == null)
                throw new ArgumentNullException("maxValues");

            var signalsCopy = Normalize(signals, minValues, maxValues);

            return GetResponse(signalsCopy);
        }
        public double[] GetErrors(double[] signals, double[] expectedOutput)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");
            if (expectedOutput == null)
                throw new ArgumentNullException("expectedOutput");
            if (expectedOutput.Length < OutputLayerSize)
                throw new ArgumentException("Expected output signals count must be equal to output layer size");

            double[] hiddenLayerSignals = new double[HiddenLayerSize];
            for (int i = 0; i < HiddenLayerSize; i++)
            {
                hiddenLayerSignals[i] = hiddenLayer[i].GetResponse(signals);
            }

            double[] outputLayerSignals = new double[OutputLayerSize];
            for (int i = 0; i < OutputLayerSize; i++)
            {
                outputLayerSignals[i] = outputLayer[i].GetResponse(hiddenLayerSignals);
            }

            double[] errors = new double[expectedOutput.Length];
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                errors[i] = Math.Abs(expectedOutput[i] - outputLayerSignals[i]);
            }

            return errors;
        }
        public double[] GetErrorsNormalize(
            double[] signals,
            double[] minValues,
            double[] maxValues,
            double[] expectedOutput)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");
            if (minValues == null)
                throw new ArgumentNullException("minValues");
            if (maxValues == null)
                throw new ArgumentNullException("maxValues");
            if (expectedOutput == null)
                throw new ArgumentNullException("expectedOutput");
            if (expectedOutput.Length < OutputLayerSize)
                throw new ArgumentException("Expected output signals count must be equal to output layer size");

            var signalsCopy = Normalize(signals, minValues, maxValues);

            double[] hiddenLayerSignals = new double[HiddenLayerSize];
            for (int i = 0; i < HiddenLayerSize; i++)
            {
                hiddenLayerSignals[i] = hiddenLayer[i].GetResponse(signalsCopy);
            }

            double[] outputLayerSignals = new double[OutputLayerSize];
            for (int i = 0; i < OutputLayerSize; i++)
            {
                outputLayerSignals[i] = outputLayer[i].GetResponse(hiddenLayerSignals);
            }

            double[] errors = new double[expectedOutput.Length];
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                errors[i] = Math.Abs(expectedOutput[i] - outputLayerSignals[i]);
            }

            return errors;
        }

        private double[] GetHiddenLayerErorrs(double[] nextLayerErrors)
        {
            int count = hiddenLayer.Count();
            double[] errors = new double[count];
            double[] outputLayerWeightsSum = outputLayer.Select(x => x.GetWeightsSum()).ToArray();

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < outputLayer.Count(); j++)
                    errors[i] += (nextLayerErrors[j] * outputLayer[j][i]) / outputLayerWeightsSum[j];
            }
            return errors;
        }
        private double[] GetHiddenLayerErorrsNew(double[] nextLayerErrors)
        {
            int count = hiddenLayer.Count();
            double[] errors = new double[count];

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < outputLayer.Count(); j++)
                    errors[i] = nextLayerErrors[j] * outputLayer[j][i];
                    //errors[i] += (nextLayerErrors[j] * outputLayer[j][i]) / outputLayerWeightsSum[j];
            }
            return errors;
        }
        public void Learn_Old(double[] signals, double[] expectedOutputs, double learningRate, bool addEpoch = false)
        {
            LearningRate = learningRate;
            Learn_Old(signals, expectedOutputs, addEpoch);
        }
        public void Learn(double[] signals, double[] expectedOutputs, double learningRate, bool addEpoch = false)
        {
            LearningRate = learningRate;
            Learn(signals, expectedOutputs, addEpoch);
        }
        public void Learn_Old(double[] signals, double[] expectedOutputs, bool addEpoch = false)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");

            int hiddenCount = hiddenLayer.Count();
            int outputCount = outputLayer.Count();

            // 0
            double[] hiddenLayerSignals = new double[hiddenCount];
            for (int i = 0; i < hiddenCount; i++)
                hiddenLayerSignals[i] = hiddenLayer[i].GetResponse(signals);

            double[] outputLayerSignals = new double[outputCount];
            for (int i = 0; i < outputCount; i++)
                outputLayerSignals[i] = outputLayer[i].GetResponse(hiddenLayerSignals);

            // 1
            double[] outputErrors = new double[outputCount];
            for (int i = 0; i < outputErrors.Length; i++)
                outputErrors[i] = expectedOutputs[i] - outputLayerSignals[i];

            double[] hiddenErrors = GetHiddenLayerErorrs(outputErrors);

            // 2
            for (int i = 0; i < outputCount; i++)
                outputLayer[i].Learn_Old(hiddenLayerSignals, outputErrors[i], learningRate);

            for (int i = 0; i < hiddenCount; i++)
                hiddenLayer[i].Learn_Old(signals, hiddenErrors[i], learningRate);

            if (addEpoch)
                LearningEpochs++;
        }
        public void Learn(double[] signals, double[] expectedOutputs, bool addEpoch = false)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");

            int hiddenCount = hiddenLayer.Count();
            int outputCount = outputLayer.Count();

            // 0
            double[] hiddenLayerSignals = new double[hiddenCount];
            for (int i = 0; i < hiddenCount; i++)
                hiddenLayerSignals[i] = hiddenLayer[i].GetResponse(signals);

            double[] outputLayerSignals = new double[outputCount];
            for (int i = 0; i < outputCount; i++)
                outputLayerSignals[i] = outputLayer[i].GetResponse(hiddenLayerSignals);

            // 1
            double[] outputErrors = new double[outputCount];
            for (int i = 0; i < outputErrors.Length; i++)
                outputErrors[i] = expectedOutputs[i] - outputLayerSignals[i];

            double[] hiddenErrors = GetHiddenLayerErorrsNew(outputErrors);

            // 2
            for (int i = 0; i < outputCount; i++)
                outputLayer[i].Learn(hiddenLayerSignals, outputErrors[i], learningRate);

            for (int i = 0; i < hiddenCount; i++)
                hiddenLayer[i].Learn(signals, hiddenErrors[i], learningRate);

            if (addEpoch)
                LearningEpochs++;
        }

        public double[] Normalize(double[] signals, double[] minValues, double[] maxValues)
        {
            var signalsCopy = new double[signals.Length];
            signals.CopyTo(signalsCopy, 0);

            for (int i = 0; i < signalsCopy.Length; i++)
            {
                signalsCopy[i] = Normalize(signalsCopy[i], minValues[i], maxValues[i]);
                
            }

            return signalsCopy;
        }
        public double Normalize(double signal, double minValue, double maxValue, double intervalMin = 0, double intervalMax = 1)
        {
            return ((signal - minValue) * (intervalMax - intervalMin)) / (maxValue - minValue) + intervalMin;
        }
        #endregion

        public override string ToString()
        {
            return Name;
            //return $"{Name} ({NetType.ToString()}). Creation Date: {CreationDate.ToString()}.";
        }

        public Neuron[] this[Layers layer]
        {
            get
            {
                switch (layer)
                {
                    case Layers.Input:
                        return inputLayer.ToArray();
                    case Layers.Hidden:
                        return hiddenLayer.ToArray();
                    case Layers.Output:
                        return outputLayer.ToArray();
                    default:
                        return null;
                }
            }
        }
        public Neuron[] InputLayer
        {
            get
            {
                return this[Layers.Input];
            }
        }
        public Neuron[] HiddenLayer
        {
            get
            {
                return this[Layers.Hidden];
            }
        }
        public Neuron[] OutputLayer
        {
            get
            {
                return this[Layers.Output];
            }
        }
        public int InputLayerSize
        {
            get
            {
                return inputLayer.Count;
            }
        }
        public int HiddenLayerSize
        {
            get
            {
                return hiddenLayer.Count;
            }
        }
        public int OutputLayerSize
        {
            get
            {
                return outputLayer.Count;
            }
        }
        public double LearningRate
        {
            get
            {
                return learningRate;
            }
            set
            {
                learningRate = (value > 0 && value <= 1) ?
                    value : throw new ArgumentException("Learning rate must be in the interval (0;1]");
            }
        }
    }
}