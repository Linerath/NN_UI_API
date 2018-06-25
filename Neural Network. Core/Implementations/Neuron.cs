using Neural_Network.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.Core
{
    public enum Functions
    {
        Sigmoid,
        None
    };

    [Serializable]
    public sealed class Neuron : INeuron
    {
        private double[] weights;
        public Functions ActivationFunction { get; private set; }

        public Neuron(int inputCount, Functions activationFunction = Functions.Sigmoid)
        {
            if (inputCount < 1)
                throw new ArgumentException("Neuron input count cannot be less than 1.");

            weights = new double[inputCount];
            ActivationFunction = activationFunction;
        }

        public double GetResponse(double[] signals)
        {
            if (signals == null)
                throw new ArgumentNullException("signals");

            int length = signals.Length;
            if (weights.Length < length)
                length = weights.Length;
            
            double response = 0;

            for (int i = 0; i < length; i++)
                response += weights[i] * signals[i];

            if (ActivationFunction != Functions.None)
                response = ApplyActivationFunction(response);

            return response;
        }
        
        public void Learn_Old(double[] signals, double error, double learningRate)
        {
            double response = GetResponse(signals);
            double delta = -error * response * (1 - response);
            for (int i = 0; i < weights.Length; i++)
                weights[i] = weights[i] - learningRate * (signals[i] * delta);
        }
        public void Learn(double[] signals, double error, double learningRate)
        {
            double response = GetResponse(signals);
            double delta = error * GetDerivative(response);
            for (int i = 0; i < weights.Length; i++)
                weights[i] = weights[i] + learningRate * (signals[i] * delta);
        }

        public void SetWeights(double[] newWeights)
        {
            if (newWeights == null)
                throw new ArgumentNullException("newWeights");

            int length = newWeights.Length;
            if (weights.Length < length)
                length = weights.Length;

            for (int i = 0; i < length; i++)
                weights[i] = newWeights[i];
        }
        public void SetRandomWeights(Random random, double minValue, double maxValue)
        {
            for (int i = 0; i < weights.Length; i++)
                weights[i] = (random.NextDouble() * (maxValue - minValue) + minValue);
        }

        public double[] GetWeights()
        {
            double[] copy = new double[weights.Length];
            weights.CopyTo(copy, 0);
            return copy;
        }
        public double GetWeightsSum()
        {
            return weights.Sum();
        }

        public void Resize(int newSize)
        {
            if (newSize < 1)
                throw new ArgumentException("New size must be more than 0");

            Array.Resize(ref weights, newSize);
        }

        private double ApplyActivationFunction(double signal)
        {
            switch (ActivationFunction)
            {
                case Functions.Sigmoid:
                    return 1 / (1 + Math.Pow(Math.E, -signal));
                default:
                    return signal;
            }
        }
        private double GetDerivative(double signal)
        {
            switch (ActivationFunction)
            {
                case Functions.Sigmoid:
                    return (signal * (1 - signal));
                default:
                    return signal;
            }
        }

        public int InputCount => weights.Length;
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= weights.Length)
                    throw new IndexOutOfRangeException("Index out of range.");

                return weights[index];
            }
            set
            {
                if (index < 0 || index >= weights.Length)
                    throw new IndexOutOfRangeException("Index out of range.");

                weights[index] = value;
            }
        }
    }
}