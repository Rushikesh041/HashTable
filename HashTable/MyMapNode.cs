using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        public readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public V[] array;
        public MyMapNode(int Size)
        {
            size = Size;
            items = new LinkedList<KeyValue<K, V>>[Size];
            array = new V[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public void Add(K key, V value)
        {
            int index = GetArrayPosition(key);
            if (items[index] == null)
            {
                items[index] = new LinkedList<KeyValue<K, V>>();
                items[index].AddLast(new KeyValue<K, V>() { Key = key, Value = value });
            }
            else
            {
                Console.WriteLine($"Key = '{key}' and Value = '{value}' is not added in Hash Table beacuse Size is Full");
            }
        }
        public void Get(K key)
        {
            int index = GetArrayPosition(key);
            bool Exist = false;
            foreach (KeyValue<K, V> item in items[index])
            {
                if (item.Key.Equals(key))
                {
                    Exist = true;
                    array[index] = item.Value;
                }
            }
            if (!Exist)
            {
                Console.WriteLine($"key = '{key}' Dosen't Exists in Hash Table");
            }

        }
        public void FrequencyOfWords(V[] arr, int arrLength)
        {
            bool[] visited = new bool[arrLength];
            int countWords = 0;
            for (int i = 0; i < arrLength; i++)
            {
                countWords++;
                if (visited[i] == true)
                {
                    continue;
                }

                int count = 1;
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine($"'{arr[i]}' is Repeated {count} times");
            }
            Console.Write($"\nTotal Words are : {countWords} \n\n");
        }
        public void Remove(K key)
        {
            int index = GetArrayPosition(key);
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in items[index])
            {
                if (item.Key.Equals(key))
                {
                    items[index].Remove(item);
                    break;
                }
            }
        }
    }
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

    }
}
