using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace DS3
{
    internal class List
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"Введите {i} элемент: ");
                int k = Convert.ToInt32(Console.ReadLine());
                myList.Add(k);
            }

            Console.Write($"Введите индекс элемент: ");
            int index = Convert.ToInt32(Console.ReadLine());
            myList.RemoveAt(index);

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            myList.Clear();

            Console.WriteLine("////////////////////////");

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("////////////////////////");


        }
    }
}
