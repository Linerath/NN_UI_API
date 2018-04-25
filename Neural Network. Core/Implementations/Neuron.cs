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
        public Functions ActivationFunction { get; private set; }

        private double[] weights;
        private double bias;
        private bool usingActivationFunction;

        public Neuron(int inputCount, Functions activationFunction = Functions.None)
        {
            if (inputCount < 1)
                throw new ArgumentException("Neuron input count cannot be less than 1.");

            weights = new double[inputCount];
            ActivationFunction = activationFunction;
        }
        
        #region Tested
        public void SetWeights(double[] weights)
        {
            if (weights == null)
                throw new ArgumentNullException("Null argument (weights).");
            if (weights.Length != this.weights.Length)
                throw new ArgumentException("Weight count must be equals to neuron weight count.");

            for (int i = 0; i < this.weights.Length; i++)
                this.weights[i] = weights[i];
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
        public double GetResponse(double[] signals)
        {
            if (signals == null)
                throw new ArgumentNullException("Null argument (signals).");
            if (signals.Length != weights.Length)
                throw new ArgumentException("Signal count must be equals to neuron weight count.");
            
            double response = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                response += weights[i] * signals[i];
            }

            if (ActivationFunction != Functions.None)
                response = ApplyActivationFunction(response);

            return response;
        }
        public void Resize(int newSize)
        {
            if (newSize < 1)
                throw new ArgumentException("Invalid new size.");

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
        #endregion


        #region Not tested
        #endregion



        public int InputCount => weights.Length;
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= InputCount)
                    throw new IndexOutOfRangeException("Index out of range.");

                return weights[index];
            }
            set
            {
                if (index < 0 || index >= InputCount)
                    throw new IndexOutOfRangeException("Index out of range.");

                weights[index] = value;
            }
        }
    }

    public class OldNeuron
    {
        private Boolean useActivationFunction;
        private Double[] weights;
        private Double bias;
        private Functions function = Functions.Sigmoid;

        public void Learn(Double[] signals, Double expectedResponse, Double learningRate)
        {
            //if (signals == null)
            //    throw new ArgumentNullException("Null argument.");
            //if (signals.Length != weights.Length)
            //    throw new ArgumentException("Signals count must be equal to weights count.");

            //Double response = GetResponse(signals);

            //Double error = expectedResponse - response;

            //for (Int32 i = 0; i < weights.Length; i++)
            //{
            //    weights[i] = signals[i] * error * learningRate;
            //}
        }
        
        public void SetRandomNullWeights(Double min, Double max, Random random)
        {
            //for (Int32 i = 0; i < weights.Length; i++)
            //{
            //    if (weights[i] == nullLink)
            //        weights[i] = (random.NextDouble() * (max - min) + min);
            //}
        }

        //public object Clone()
        //{
            //return new OldNeuron(InputCount)
            //{
            //    weights = weights,
            //    bias = bias
            //};
        //}
    }
}