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
        int capacityIncrementer;

        public int Count { get; private set; } //needs to be read only

        public int Capacity { get; set; } 
        
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[i];
            }
            set
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                array[i] = value;
            }
        }

        // Can use .Equals()
        public CustomList()
        {
            Capacity = 0;
            capacityIncrementer = 4;
            Count = 0;
            array = new T[Capacity];
        }

        public void Add(T newItem)        
        {
            if (Count == Capacity)
            {
                Capacity += capacityIncrementer;
                T[] temporary = array;
                array = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    array[i] = temporary[i];
                }                
            }
            array[Count++] = newItem;
        }
        public void Remove(T item)
        {
            bool foundItem = false;
            int counter = 0;
            do
            {
                for (int i = 0; i < Count; i++)
                {                    
                    if (array[i].Equals(item))
                    {
                        foundItem = true;
                        break;
                    }                    
                    counter++;
                }
            } while (foundItem == false);
            Count--;
            for (int i = counter; i < Count; i++)
            {
                array[i] = array[i + 1];
            }          
                      
            //decrement Capacity if too high
            if (Count <= (Capacity - capacityIncrementer))
            {
                Capacity -= capacityIncrementer;
                T[] temporary = array;
                array = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    array[i] = temporary[i];
                }
            }
        }
    }
}
