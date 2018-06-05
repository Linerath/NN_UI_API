using Neural_Network.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Neural_Network.Core.Extra
{
    public static class NeuralNetworkService
    {
        public static NeuralNetworkInputProject[] GetInputProjectsForNetwork(NeuralNetworkInputProject[] inputProjects, FeedforwardNetworkSHL network)
        {
            if (inputProjects == null || network == null)
                return null;

            List<NeuralNetworkInputProject> projects = new List<NeuralNetworkInputProject>();

            foreach (var proj in inputProjects)
            {
                if (network == proj.Network)
                    projects.Add(proj);
            }

            return projects.ToArray();
        }

        public static int GetNetworkIndexForInputProject(NeuralNetworkInputProject inputProject, FeedforwardNetworkSHL[] networks)
        {
            for (int i = 0; i < networks.Length; i++)
            {
                if (inputProject.Network == networks[i])
                    return i;
            }
            return -1;
        }

        public static void TrainNetwork(
            FeedforwardNetworkSHL network,
            List<double[]> inputSignals,
            List<double[]> correctOutputSignals,
            int epochs,
            double learningRate,
            bool randomize,
            out double startError,
            out double endError,
            Action<int> progressAction)
        {
            startError = 0;
            endError = 0;

            double[] startErrors = new double[correctOutputSignals.Count()];
            for (int i = 0; i < inputSignals.Count(); i++)
                startErrors[i] = network.GetErrors(inputSignals[i], correctOutputSignals[i]).Average();
            startError = startErrors.Average();

            Random random = new Random();
            for (int i = 0; i < epochs; i++)
            {
                if (randomize)
                    Shuffle(inputSignals, correctOutputSignals, random);

                for (int j = 0; j < inputSignals.Count(); j++)
                {
                    network.Learn(inputSignals[j], correctOutputSignals[j], learningRate, (j == inputSignals.Count() - 1));
                }

                progressAction?.Invoke(i);
            }

            double[] endErrors = new double[correctOutputSignals.Count()];
            for (int i = 0; i < inputSignals.Count(); i++)
                endErrors[i] = network.GetErrors(inputSignals[i], correctOutputSignals[i]).Average();
            endError += endErrors.Average();
        }
        public static void Shuffle(List<double[]> input, List<double[]> output, Random random)
        {
            for (int i = input.Count() - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp0 = input[j];
                var temp1 = output[j];
                input[j] = input[i];
                input[i] = temp0;
                output[j] = output[i];
                output[i] = temp1;
            }
        }

    }
}