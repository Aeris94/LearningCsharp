using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Net;

//Write a generic class GenericList<T>, which holds a list of elements of type T.
//Store the list of elements into an array with a limited capacity that is passed as a parameter
//of the constructor of the class. Add methods to add an item, to access an item by index, to remove
//an item by index, to insert an item at given position, to clear the list, to search for an item 
//by value and to override the method ToString(). 

//Implement auto-resizing functionality of the array from the previous task, when by adding an element, 
//it reaches the capacity of the array.

namespace Program
{
    class GenericList<T>
    {
        const int defaultCapacity = 10;
        private int capacity;
        private T[] arrayList;
        private int currentIndex = 0;

        public GenericList()
        {
            this.capacity = defaultCapacity;
            this.arrayList = new T[capacity];
        }

        public GenericList(int size)
        {
            this.capacity = size;
            this.arrayList = new T[size];
        }

        public override string ToString()
        {
            foreach (T item in arrayList)
            {
                Console.WriteLine(item);
            }
            return " ";
        }

        private void ResizeArray()
        {
            capacity = capacity * 2;
            T[] arrayCopy = new T[capacity];
            arrayList.CopyTo(arrayCopy, 0);
            arrayList = arrayCopy;
        }

        public void Add(T item)
        {
            if (currentIndex == capacity - 1)
            {
                ResizeArray();
            }
            arrayList[currentIndex] = item;
            currentIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index < currentIndex)
                {
                    return this.arrayList[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index must be in range of existing collection.");
                }
            }
            set
            {
                if (index < currentIndex)
                {
                    this.arrayList[index] = value;
                }
                else
                {
                    throw new AggregateException("Index must be in range of existing collection.");
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < currentIndex; i++)
            {
                arrayList[i] = arrayList[i + 1];
            }
            currentIndex--;
        }

        public void Clear()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                arrayList[i] = default(T);
            }
            currentIndex = 0;
        }

        public int FindIndexOf(T item)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (item.Equals(arrayList[i]))
                {
                    return i;
                }
            }
            return -1;
        } 
    }

    class Program
    {  
        static void Main(string[] args)
        {
            
        }
    } 
}
