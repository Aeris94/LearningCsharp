using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListImplementation
{
    class CustomArrayList<T>
    {
        private T[] array;
        private int indexCount;

        private const int initialSize = 4; //initial capacity of array

        public CustomArrayList()
        {
            this.array = new T[initialSize];
            this.indexCount = 0; 
        }       
        
        public int Length()
        {
            return this.indexCount;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= indexCount)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
        }

        //indexer - acces the elemnt by given index
        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return this.array[index];
            }
            set
            {
                ValidateIndex(index);
                this.array[index] = value;
            }
        }
 
        public void Push(T item)
        {
            ResizeIfFull();
            this.array[this.indexCount] = item;
            indexCount = indexCount + 1;
        }

        public T Pop()
        {
            T popedValue = array[this.indexCount -1];
            array[this.indexCount -1] = default(T);
            this.indexCount = this.indexCount - 1;
            return popedValue;
        }

        //shift - removes first element an returns its value
        public T Shift()
        {
            T shiftedValue = array[0];
            this.indexCount--;
            Array.Copy(this.array, 1, this.array, 0, this.indexCount);
            this.array[indexCount] = default(T);
            return shiftedValue;
        }

        //unshift - insert value at the begging of the array
        public void Unshift(T item)
        {
            ResizeIfFull();
            Array.Copy(this.array, 0, this.array, 1, this.indexCount);
            this.indexCount++;
            this.array[0] = item;
        }
        
        //insert an element at the specific position
        public void Insert(T item, int index)
        {
            ValidateIndex(index);
            ResizeIfFull();
            Array.Copy(this.array, index, this.array, index + 1, this.indexCount - index);
            array[index] = item;
            this.indexCount++;
        }

        //delete an element by index
        public void RemoveAt(int index)
        {
            ValidateIndex(index);
            Array.Copy(this.array, index + 1, this.array, index, this.indexCount - index -1);
            this.indexCount--;
            this.array[indexCount] = default(T);
        }

        //delete an element by value
        public void Remove(T item)
        {
            int index = IndexOf(item);
            RemoveAt(index);
        }
        
        //searching array for element by object(retrun index)
        public int IndexOf(T item)
        {
            for(int i = 0; i < this.indexCount; i++)
            {
                if(object.Equals(item, this.array[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        //resizing the array
        private void ResizeIfFull()
        {
            if(this.indexCount >= array.Length)
            {
                T[] resizeArray = new T[this.array.Length * 2];
                Array.Copy(this.array, resizeArray, this.indexCount);
                this.array = resizeArray;
            }
        }

        //clearing the array
        public void Clear()
        {
            this.array = new T[initialSize];
            this.indexCount = 0;
        }
    }
}
