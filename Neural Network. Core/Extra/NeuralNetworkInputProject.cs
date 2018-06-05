using Neural_Network.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network.Core.Extra
{
    [Serializable]
    public class NeuralNetworkInputProject
    {
        public String Name { get; set; }

        public FeedforwardNetworkSHL Network { get; set; }
        private List<Field> inputLayerFields;
        private List<Field> outputLayerFields;

        public NeuralNetworkInputProject(String name, FeedforwardNetworkSHL network)
        {
            inputLayerFields = new List<Field>();
            outputLayerFields = new List<Field>();

            Name = name;
            Network = network ?? throw new ArgumentNullException("FeedforwardNetworkSHL");
        }

        #region Tested
        #endregion

        #region Not tested
        public void CreateField(Layers layer, String name, String description, Neuron neuron, double value = 0, bool replaceExistingField = true)
        {
            CreateField(layer, new Field(name, description, neuron, value), replaceExistingField);
        }
        public void CreateField(Layers layer, Field field, bool replaceExistingField = true)
        {
            if (layer == Layers.Hidden)
                throw new ArgumentException("You haven't access for the hidden layer");

            int existingFieldIndex;
            switch (layer)
            {
                case Layers.Input:
                    existingFieldIndex = inputLayerFields.FindIndex(x => x.Neuron == field.Neuron);
                    if (existingFieldIndex >= 0)
                    {
                        if (replaceExistingField)
                            inputLayerFields[existingFieldIndex] = field;
                    }
                    else
                    {
                        inputLayerFields.Add(field);
                    }
                    break;
                case Layers.Output:
                    existingFieldIndex = outputLayerFields.FindIndex(x => x.Neuron == field.Neuron);
                    if (existingFieldIndex >= 0)
                    {
                        if (replaceExistingField)
                            outputLayerFields[existingFieldIndex] = field;
                    }
                    else
                    {
                        outputLayerFields.Add(field);
                    }
                    break;
            }
        }
        public void RemoveField(Layers layer, Field field)
        {
            if (layer == Layers.Hidden)
                throw new ArgumentException("You haven't access for the hidden layer");

            switch (layer)
            {
                case Layers.Input:
                    inputLayerFields.Remove(field);
                    break;
                case Layers.Output:
                    outputLayerFields.Remove(field);
                    break;
            }
        }
        public void RemoveField(Layers layer, String name)
        {
            if (layer == Layers.Hidden)
                throw new ArgumentException("You haven't access for the hidden layer");

            List<Field> fields = new List<Field>();
            switch (layer)
            {
                case Layers.Input:
                    fields = inputLayerFields.FindAll(x => x.Name == name);
                    break;
                case Layers.Output:
                    fields = outputLayerFields.FindAll(x => x.Name == name);
                    break;
            }
            foreach (var f in fields)
                RemoveField(layer, f);
        }

        public void SetInput(double[] values)
        {
            int untill = inputLayerFields.Count() <= values.Length ? inputLayerFields.Count() : values.Length;
            for (int i = 0; i < untill; i++)
                inputLayerFields[i].Value = values[i];
        }

        public Field[] InputLayerFields
        {
            get
            {
                return inputLayerFields.ToArray();
            }
        }
        public Field[] OutputLayerFields
        {
            get
            {
                return outputLayerFields.ToArray();
            }
        }
        public int InputFieldsCount
        {
            get
            {
                return inputLayerFields.Count();
            }
        }
        public int OutputFieldsCount
        {
            get
            {
                return outputLayerFields.Count();
            }
        }
        #endregion
    }

    [Serializable]
    public class Field
    {
        private String name;
        private String description;
        private Neuron neuron;
        public double Value { get; set; }

        public Field(String name, String description, Neuron neuron, double value = 0)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid name");
            this.name = name;
            this.description = description;
            this.neuron = neuron ?? throw new ArgumentNullException("neuron");
            Value = value;
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid name");
                name = value;
            }
        }
        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public Neuron Neuron
        {
            get
            {
                return neuron;
            }
            set
            {
                neuron = value ?? throw new ArgumentNullException("neuron");
            }
        }
    }
}