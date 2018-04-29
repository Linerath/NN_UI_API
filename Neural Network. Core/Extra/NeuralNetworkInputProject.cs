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

        private FeedforwardNetworkSHL network;
        public List<Field> inputLayerFields;
        private List<Field> outputLayerFields;

        public NeuralNetworkInputProject(String name, FeedforwardNetworkSHL network)
        {
            inputLayerFields = new List<Field>();
            outputLayerFields = new List<Field>();

            Name = name;
            this.network = network ?? throw new ArgumentNullException("Null argument (FeedforwardNetworkSHL)");
        }

        #region Tested
        #endregion

        #region Not tested
        public void CreateField(Layers layer, String name, int neuronIndex, bool replaceExistingField = true)
        {
            if (layer == Layers.Hidden)
                throw new ArgumentException("You cannot create fields for the hidden layer");

            CreateField(layer, new Field(name, neuronIndex), replaceExistingField);
        }
        public void CreateField(Layers layer, Field field, bool replaceExistingField = true)
        {
            if (layer == Layers.Hidden)
                throw new ArgumentException("You cannot create fields for the hidden layer");

            switch (layer)
            {
                case Layers.Input:
                    var existingFieldIndex = inputLayerFields.FindIndex(x => x.NeuronIndex == field.NeuronIndex);
                    if (existingFieldIndex >= 0)
                    {
                        Console.WriteLine("Field already exists!");
                        if (replaceExistingField)
                        {
                            inputLayerFields[existingFieldIndex] = field;
                            Console.WriteLine("Replaced!");
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        inputLayerFields.Add(field);
                    }
                    break;
                case Layers.Output:
                    outputLayerFields.Add(field);
                    break;
            }
        }
        public void RemoveField(Layers layer, String name, int neuronIndex)
        {

        }
        public void RemoveField(Layers layer, Field field)
        {

        }

        //public Field? this[Layers layer, int neuronIndex]
        //{
            //get
            //{
            //    if (layer == Layers.Hidden)
            //        throw new ArgumentException("You do not have access to the hidden layer!");

            //    switch (layer)
            //    {
            //        case Layers.Input:
            //            var existingFieldIndex = inputLayerFields.FindIndex(x => x.NeuronIndex == neuronIndex);
            //            if (existingFieldIndex >= 0)
            //                return inputLayerFields[existingFieldIndex];
            //            else
            //                return null;
            //        case Layers.Output:
            //            return outputLayerFields.Find(x => x.NeuronIndex == neuronIndex);
            //        default:
            //            return new Field("Not existing field", -1);
            //    }
            //}
        //}
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

    public struct Field
    {
        private String name;
        private int neuronIndex;

        public Field(String name, int neuronIndex)
        {
            this.name = name ?? throw new ArgumentNullException("Null argument (Field name)");
            this.neuronIndex = (neuronIndex >= 0) ? neuronIndex : throw new IndexOutOfRangeException("Index out of range.");
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Null argument (InputProject Field name)");
                if (value.Trim() == String.Empty)
                    throw new ArgumentException("Empty field name");

                name = value;
            }
        }
        public int NeuronIndex
        {
            get
            {
                return neuronIndex;
            }
            set
            {
                if (value < 0)
                    throw new IndexOutOfRangeException("Index out of range.");
                neuronIndex = value;
            }
        }
    }
}