using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1 , T2>
    {
        T1[] keys;
        T2[] values;
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempKeyArray = keys;
            keys = new T1[keys.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
            }
            keys[keys.Length - 1] = key;
            T2[] tempValueArray = values;
            values = new T2[values.Length + 1];
            for (int j = 0; j < tempValueArray.Length; j++)
            {
                values[j] = tempValueArray[j];
            }
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }

        }
        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"Category ID: {keys[i]} - Material Type: {values[i]}");
            }
        }
    }
}
