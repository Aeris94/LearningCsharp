using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTreeImplementation
{
    public class TreeNode<T>
    {
        private T item;
        private bool hasParent;
        private List<TreeNode<T>> children;

        public TreeNode(T item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("Cannot insert a null value!!");
            }
            this.item = item;
            this.children = new List<TreeNode<T>>();
        }

        //method for reaching the value of the node
        public T Item 
        {
            get
            {
                return item;
            }
            set
            {
                this.item = value;
            }
        }

        //the number of the children in the node
        public int Count
        {
            get
            {
                return this.children.Count;
            }
        }

        //adding childern to the node
        public void AddChild(TreeNode<T> child)
        {
            if(child == null)
            {
                throw new ArgumentNullException("Cannot insert a null value!!");
            }
            if(child.hasParent == true)
            {
                throw new ArgumentException("The child alredy had a parent!");
            }
            child.hasParent = true;
            this.children.Add(child);
        }

        //gets a child of the node at given index
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }

    //a class representing tree
    public class Tree<T>
    {
        private TreeNode<T> treeRoot;

        //construct root witch a single value
        public Tree(T rootValue)
        {
            if(rootValue == null)
            {
                throw new ArgumentNullException("Cannot insert a null value.");
            }
            this.treeRoot = new TreeNode<T>(rootValue);
        }

        //constructs root witch a root and its children
        public Tree(T rootValue, params Tree<T>[] children) : this(rootValue)
        {
            foreach (Tree<T> item in children)
            {
                this.treeRoot.AddChild(item.treeRoot);
            }
        }

        //returning the tree root
        public TreeNode<T> Root
        {
            get
            {
                return this.treeRoot;
            }
        }

        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if(root == null)
            {
                return;
            }
            Console.WriteLine(spaces + root.Item);
            TreeNode<T> child = null;
            for (int i = 0; i < root.Count; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
            
        }

        public void TraverseDFS()
        {
            this.PrintDFS(this.treeRoot, string.Empty);
        }
    }

}
