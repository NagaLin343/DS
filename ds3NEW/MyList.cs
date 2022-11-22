using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace DS3
{
    public class MyList<TItem> : IEnumerable<TItem>
    {
        private TItem[] array = new TItem[count];

        private static int count = 5;
        public int Count { get => count; }

        int length = 0;


        public void Add(TItem item)
        {

            if (length < count)
            {
                array[length] = item;
                length++;
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        public void RemoveAt(int index)
        {

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            count--;
            Array.Resize(ref array, count);

        }

        public void Remove(TItem item)
        {

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                    array[i] = array[i + 1];
            }

            count--;
            Array.Resize(ref array, count);

        }

        public void Clear()
        {
            array = new TItem[count];
        }


        public IEnumerator<TItem> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}