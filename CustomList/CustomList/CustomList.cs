using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CList
{
    public class CustomList<T>
    {
        public T[] array;
        public int Count;  //needs to be read only
        public int Capacity; // { get; }; needs to be read only
        
        public T this[int i]  // indexer
        {
            get => array[i];
            set => array[i] = value;
        }
        
        // Can use .Equals()
        public CustomList()
        {
            Capacity = 4;
            Count = 0;
            array = new T[Capacity];
        }

        public void Add(T newItem)        
        {
            if (Count == Capacity)
            {
                Capacity += 4;
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

        }
    }
}
