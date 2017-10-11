using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    class DynamicList<T>
    {
        private class ListNode
        {
            public T Elemnet { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T element)
            {
                this.Elemnet = element;
                NextNode = null;
            }

            public ListNode(T element, ListNode previousNode)
            {
                this.Elemnet = element;
                previousNode.NextNode = this;
            }
        }

        private ListNode head;//first element reference
        private ListNode tail;//second element reference
        private int count = 0;//number of elements in the list

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
        }

        public int Length
        {
            get
            {
                return this.count;
            }
        }

        //adding elements to the list
        public void Add(T element)
        {
            if (count == 0)
            {
                this.head = new ListNode(element);
                this.tail = head;
            }
            else
            {
                ListNode newNode = new ListNode(element, tail);
                this.tail = newNode;
            }
            this.count++;
        }

        //removes item by index and returns its value
        public T Remove(int index)
        {
            if(index < 0 || index >= this.count)
            {
                throw new Exception("Invalid index: " + index);
            }

            int indexCount = 0;
            ListNode node = this.head;
            ListNode prevNode = null;

            while(indexCount < index)
            {
                prevNode = node;
                node = node.NextNode;
                indexCount++;
            }
            RemoveListNode(node, prevNode);
            return node.Elemnet;
        }

        //removes element by value and returns index
        public int Remove(T element)
        {
            int indexOfEelement = 0;
            ListNode node = this.head;
            ListNode prevNode = null;

            while(node != null)
            {
                if(object.Equals(node.Elemnet, element))
                {
                    break;
                }
                indexOfEelement++;
                prevNode = node;
                node = node.NextNode;
            }

            if (node != null)
            {
                RemoveListNode(node, prevNode);
                return indexOfEelement;
            }
            else
            {
                return -1;
            }
        }


        private void RemoveListNode(ListNode node, ListNode prevNode)
        {
            this.count--;
            if(node == null) //if there is only one node in the list
            {
                this.head = null;
                this.tail = null;
            }
            else if(prevNode == null) //if the fist node was removed - updating the head of the list
            {
                this.head = node.NextNode;
            }
            else
            {
                prevNode.NextNode = node.NextNode;
            }

            //if the tail was removed
            if(object.ReferenceEquals(this.tail, node))
            {
                this.tail = prevNode;
            }
        }

        //searching the list for given element
        public int IndexOf(T element)
        {
            int currentPosition = 0;
            ListNode node = this.head;
            while (node != null)
            {
                if(object.ReferenceEquals(node.Elemnet, element))
                {
                    return currentPosition;
                }
                node = node.NextNode;
                currentPosition++;
            }
            return -1;
        }

        //checking if given element exist
        public bool Contains(T element)
        {
            return IndexOf(element) == -1 ? false : true;
        }

        //indexer - reaching elements by index
        public T this[int index]
        {
            get
            {
                if(index < 0 || index > this.count)
                {
                    throw new Exception("Invalid index: " + index);
                }

                ListNode node = this.head;
                for(int i = 0; i < index; i++)
                {
                    node = node.NextNode;
                }
                return node.Elemnet;
            }
            set
            {
                if (index < 0 || index > this.count)
                {
                    throw new Exception("Invalid index: " + index);
                }
                ListNode node = this.head;
                for(int i = 0; i < index; i++)
                {
                    node = node.NextNode;
                }
                node.Elemnet = value;
            }
        }
    }
        
}
