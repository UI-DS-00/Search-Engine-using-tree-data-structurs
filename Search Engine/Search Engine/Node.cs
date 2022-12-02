using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Node<T>
    {
        public T val;
        public Node<T> parent;
        public List<Node<T>> child = new List<Node<T>>();

        public void addChild(T val)
        {
            this.child.Add(new Node<T>(val));
        }
        public void addChild(T val , int i)
        {
            this.child[i].addChild(val);
        }

        public Node()
        {

        }
        public Node(T val ,Node<T> parent = null)
        {
            this.val = val;
            this.parent = parent;
        }
    }
}
