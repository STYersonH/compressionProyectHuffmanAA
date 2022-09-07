
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
namespace Algorithm_Implementation
{
    public class HuffmanTree
    {
        private List<Node> node = new List<Node>();
        public Node rootNode { get; set; }
        public Dictionary<char, int> frequency = new Dictionary<char, int>();


        // build the huffman tree of the input file
        public void Build_Tree(string input, string ocurrencia, string caracteres)
        {
            string path = ocurrencia;
            string pathChar = caracteres;

            for (int i = 0; i < input.Length; i++)
            {
                // check the tree contains character or not
                if (!frequency.ContainsKey(input[i]))
                {
                    // add the character in tree
                    frequency.Add(input[i], 0);
                }

                frequency[input[i]]++;
            }

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (KeyValuePair<char, int> caracter in frequency)
                    {
                        sw.WriteLine(caracter.Value);
                    }
                }
            }

            // Obtener los caracteres como tal
            UTF8Encoding utf8 = new UTF8Encoding();

            string caracteresUsados = "";
            foreach (KeyValuePair<char, int> caracter in frequency)
            {
                caracteresUsados = caracteresUsados + caracter.Key;
            }

            // Encode the string.
            Byte[] encodedBytes = utf8.GetBytes(caracteresUsados);
            // write all the bits from byte array in bin file
            File.WriteAllBytes(pathChar, encodedBytes);


            foreach (KeyValuePair<char, int> symbol in frequency)
            {
                node.Add(new Node() { character = symbol.Key, frequency = symbol.Value });
            }



            while (node.Count > 1)
            {
                // ordering the nodes on the basis of frequency
                List<Node> orderedNodes = node.OrderBy(node => node.frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    List<Node> takenNode = orderedNodes.Take(2).ToList<Node>();

                    // Create a parent node by combining the frequencies
                    Node parent = new Node()
                    {
                        character = '*',
                        frequency = takenNode[0].frequency + takenNode[1].frequency,
                        leftNode = takenNode[0],
                        rightNode = takenNode[1]
                    };

                    node.Remove(takenNode[0]);
                    node.Remove(takenNode[1]);
                    node.Add(parent);
                }

                this.rootNode = node.FirstOrDefault();

            }

        }

        public void Build_TreeDes(string ocurrencias, string caracteres)
        {
            UTF8Encoding utf8 = new UTF8Encoding();

            string path = ocurrencias;
            string pathChar = caracteres;

            byte[] bytes2 = File.ReadAllBytes(pathChar);
            // Decode bytes back to string.
            String decodedString = utf8.GetString(bytes2);

            Dictionary<char, int> ocurrencia = new Dictionary<char, int>();

            int[] cantidades = new int[decodedString.Length];
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int i = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    cantidades[i] = Int32.Parse(s);
                    i++;
                }
            }

            for (int i = 0; i < decodedString.Length; i++)
            {
                ocurrencia[decodedString[i]] = cantidades[i];
            }


            foreach (KeyValuePair<char, int> symbol in ocurrencia)
            {
                Console.WriteLine(symbol);
                node.Add(new Node() { character = symbol.Key, frequency = symbol.Value });
            }



            while (node.Count > 1)
            {
                // ordering the nodes on the basis of frequency
                List<Node> orderedNodes = node.OrderBy(node => node.frequency).ToList<Node>();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    List<Node> takenNode = orderedNodes.Take(2).ToList<Node>();

                    // Create a parent node by combining the frequencies
                    Node parent = new Node()
                    {
                        character = '*',
                        frequency = takenNode[0].frequency + takenNode[1].frequency,
                        leftNode = takenNode[0],
                        rightNode = takenNode[1]
                    };

                    node.Remove(takenNode[0]);
                    node.Remove(takenNode[1]);
                    node.Add(parent);
                }

                this.rootNode = node.FirstOrDefault();

            }

        }

        // Encode function for encoding the characters in binary form
        public BitArray Encode(string input)
        {
            List<bool> encodedInput = new List<bool>();

            for (int i = 0; i < input.Length; i++)
            {
                List<bool> encodedCharacter = this.rootNode.Traverse_Tree(input[i], new List<bool>());
                encodedInput.AddRange (encodedCharacter);
            }

            BitArray BitArray = new BitArray(encodedInput.ToArray());

            return BitArray;
        }

        public string Decode(BitArray BitArray)
        {
            Node currentNode = this.rootNode;
            string decoded = "";

            foreach (bool bit in BitArray)
            {
                if (bit)
                {
                    if (currentNode.rightNode != null)
                    {
                        currentNode = currentNode.rightNode;
                    }
                }
                else
                {
                    if (currentNode.leftNode != null)
                    {
                        currentNode = currentNode.leftNode;
                    }
                }

                if (IsLeaf(currentNode))
                {
                    decoded += currentNode.character;
                    currentNode = this.rootNode;
                }
            }

            return decoded;
        }

        public bool IsLeaf(Node node)
        {

            return (node.leftNode == null && node.rightNode == null);

        }
    }
}
