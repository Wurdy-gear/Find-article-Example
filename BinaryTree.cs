using System;

namespace BinaryTreeExample
{
    public class BinaryTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }

        public Node Find(int value)
        {
            if (root != null)
            {
                return root.Find(value);
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            
            if (root != null)
            {
                root.Insert(value);
            }
            else
            {
                root = new Node(value);
            }
        }

    }
}
