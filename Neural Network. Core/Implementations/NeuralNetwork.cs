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

        public const double RANDOM_MIN_VALUE = 0.1;
        public const double RANDOM_MAX_VALUE = 0.9;

        public FeedforwardNetworkSHL(String name, int inputLayerSize, int hiddenLayerSize, int outputLayerSize, Functions activationFunction = Functions.None, double learningRate = 0.1)
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
                throw new ArgumentNullException("Null argument (signals)");

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
        // FOR MULTILAYER
        //private double[] GetHiddenLayerErorrs(double[] nextLayerErrors, double[,] nextLayerWeights)
        //{
        //    int count = hiddenLayer.Count();
        //    double[] errors = new double[count];
        //    double[] outputLayerWeightsSum = outputLayer.Select(x => x.GetWeightsSum()).ToArray();

        //    for (int i = 0; i < count; i++)
        //    {
        //        for (int j = 0; j < outputLayer.Count(); j++)
        //        {
        //            errors[i] += (nextLayerErrors[j] * nextLayerWeights[j, i]) / outputLayerWeightsSum[j];
        //        }
        //    }
        //    return errors;
        //}
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
        public void Learn(double[] signals, double[] expectedOutputs)
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
                outputLayer[i].Learn(hiddenLayerSignals, outputErrors[i], learningRate);

            for (int i = 0; i < hiddenCount; i++)
                hiddenLayer[i].Learn(signals, hiddenErrors[i], learningRate);
        }
        public void Normalize(double[] signals)
        {
            throw new NotImplementedException();
        }
        #endregion

        public override string ToString()
        {
            return $"{Name} ({NetType.ToString()}). Creation Date: {CreationDate.ToString()}.";
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

    //internal sealed class FeedforwardNetwork
    //{
    //    public void Resize(Int32 layerIndex, Int32 newNeuronCount)
    //    {
    //        if (layerIndex < 0 || layerIndex >= LayerCount)
    //            throw new ArgumentOutOfRangeException("Invalid layer index");
    //        if (newNeuronCount < 0)
    //            throw new ArgumentException("Invalid size.");

    //        if (layerIndex == 0)
    //        {
    //            if (newNeuronCount > inputLayer.Count)
    //            {
    //                while (newNeuronCount > inputLayer.Count)
    //                    inputLayer.Add(new OldNeuron(1));
    //            }
    //            else if (newNeuronCount < inputLayer.Count)
    //            {
    //                while (newNeuronCount < inputLayer.Count)
    //                    inputLayer.RemoveAt(inputLayer.Count - 1);
    //            }
    //        }
    //        else if (layerIndex == 1)
    //        {
    //            if (newNeuronCount > hiddenLayer.Count)
    //            {
    //                while (newNeuronCount > hiddenLayer.Count)
    //                    hiddenLayer.Add(new OldNeuron(inputLayer.Count, true));
    //            }
    //            else if (newNeuronCount < hiddenLayer.Count)
    //            {
    //                while (newNeuronCount < hiddenLayer.Count)
    //                    hiddenLayer.RemoveAt(hiddenLayer.Count - 1);
    //            }
    //        }
    //        else if (layerIndex == 2)
    //        {
    //            if (newNeuronCount > outputLayer.Count)
    //            {
    //                while (newNeuronCount > outputLayer.Count)
    //                    outputLayer.Add(new OldNeuron(hiddenLayer.Count, true));
    //            }
    //            else if (newNeuronCount < outputLayer.Count)
    //            {
    //                while (newNeuronCount < outputLayer.Count)
    //                    outputLayer.RemoveAt(outputLayer.Count - 1);
    //            }
    //        }
    //    }

    //}
}