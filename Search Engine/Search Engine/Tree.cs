using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Tree <T>
    {
        Node<T> root = new Node<T>();
        public Node<T> newNode(T key)
        {
            Node<T> temp = new Node<T>();
            temp.val = key;
            return temp;
        }

        public Node<T> getRoot()
        {
            return this.root;
        }

        public Node<T> getParent(Node<T> p)
        {
            return p.parent;
        }
        public List<Node<T>> Children(Node<T> p)
        {
            return p.child;
        }
        public bool isRoot(Node<T> p)
        {
            return p.parent == null;
        }
        




    }
}
