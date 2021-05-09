using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// Generic Binary search tree is defined
    /// Due to generic class, Icomparable method is defined to use CompareTo inside the program
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BST<T> where T : IComparable
    {
        /// <summary>
        /// Getting and setting nodedata.
        /// </summary>
        public T NodeData
        {
            get;
            set;
        }

        /// <summary>
        /// Getting and setting the left tree.
        /// </summary>
        public BST<T> leftTree { get; set; }


        /// <summary>
        /// Getting and setting the right tree.
        /// </summary>
        public BST<T> rightTree { get; set; }


        /// <summary>
        /// Initializing the nodeDat,left tree and right tree.
        /// </summary>
        /// <param name="nodeData"></param>
        public BST(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;


        /// <summary>
        /// Insert a element into bst.
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BST<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BST<T> (item);
                else
                    this.rightTree.Insert(item);
            }
        }

        /// <summary>
        /// Displaying the BST(nodes).
        /// </summary>
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size of binary search tree is : " + (1 + this.leftCount + this.rightCount));
        }
    }
}
