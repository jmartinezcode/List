using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CList
{
    public class CustomList<T>
    {
        T[] array;
        int count;

        public int Count { get => count; } //needs to be read only
        int capacity;
        public int Capacity { get => capacity; set => capacity = value; } //needs to be read only
        
        public T this[int i] { get => array[i]; set => array[i] = value; }  // indexer        }

        // Can use .Equals()
        public CustomList()
        {
            capacity = 0;
            count = 0;
            array = new T[capacity];
        }

        public void Add(T newItem)        
        {
            if (count == capacity)
            {
                capacity += 4;
                T[] temporary = array;
                array = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    array[i] = temporary[i];
                }                
            }
            array[count++] = newItem;
        }
        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (true)
                {

                }
            }
            
            
            //decrement Capacity if too high
            if (count <= (capacity - 4))
            {
                capacity -= 4;
                T[] temporary = array;
                array = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    array[i] = temporary[i];
                }
            }
        }
    }
}
