using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class MyTree
    {
        static readonly int ALPHABET_SIZE = 26;

        internal class Node
        {
            public Node[] children = new Node[ALPHABET_SIZE];

            // isEndOfWord is true if the node represents
            // end of a word
            public bool isEndOfWord;

            public Node()
            {
                isEndOfWord = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                    children[i] = null;
            }
        };


        string _FileName;
        public string FileName { get { return _FileName; } set { _FileName = value; } }
        Node root = new Node();

        public void insert(String key)
        {
            int length = key.Length;
            int index;

            Node tmp = root;

            for (int i = 0; i < length; i++)
            {
                index = key[i] - 'a';
                if (key[i] < 97)
                    index += 32;
                //Console.WriteLine(key + "### " + index);
                if (tmp.children[index] == null)
                    tmp.children[index] = new Node();

                tmp = tmp.children[index];
            }

            // mark last node as leaf
            tmp.isEndOfWord = true;
        }

        public bool search(String key)
        {
            int length = key.Length;
            int index;
            Node tmp = root;

            for (int i = 0; i < length; i++)
            {
                index = key[i] - 'a';
                if (key[i] < 97)
                    index += 32;
                if (tmp.children[index] == null)
                    return false;

                tmp = tmp.children[index];
            }

            return (tmp.isEndOfWord);
        }



    }
}
