﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CList
{
    public class CustomList<T> : IEnumerable where T: IComparable
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

        public void Add(T item)        
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
            array[Count++] = item;
        }
        public bool Remove(T item)
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
            } while (foundItem == false && counter <= Count);                              
            if (foundItem)
            {
                Count--;
                for (int i = counter; i < Count; i++)
                {
                    array[i] = array[i + 1];
                }                
                CapacityDecrementer();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CapacityDecrementer()
        {
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
        public override string ToString()
        {
            string value = string.Empty;
            for (int i = 0; i < Count; i++)
            {
                if (string.IsNullOrEmpty(value))
                {
                    value += array[i].ToString();
                }
                else
                {
                    value += string.Format(", {0}", array[i]);
                }                
            }
            return value;
        }        
        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> temporary = firstList;
            foreach (T item in secondList)
            {
                temporary.Add(item);
            }
            return temporary;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> temporary = firstList;            
            foreach (T item in secondList)
            {
                temporary.Remove(item);               
            }
            return temporary;
        }
        public CustomList<T> Zip(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> temporary = new CustomList<T>();
            if (firstList.Count <= secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    temporary.Add(firstList[i]);
                    temporary.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    temporary.Add(firstList[i]);
                    temporary.Add(secondList[i]);
                }
            }                       
            return temporary;            
        }
        public T[] Sort()
        {
            //BubbleSort https://en.wikipedia.org/wiki/Bubble_sort
            if (Count == 1)
            {
                return array;
            }
            bool swapItem = false;
            for (int i = 0; i < (Count - 1); i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {//swap if first item bigger than next item
                    T temporary = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temporary;
                    swapItem = true;
                }                    
            }
            if (swapItem)
            {
                Sort();
            }                      
            return array;
        }        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
    }
}
