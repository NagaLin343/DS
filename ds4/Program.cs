using System;
using System.Collections;
using System.Collections.Generic;
namespace DS4
{
    class Program
    {
            static void Main(string[] args)
            {
                var list = new LinkedList<int>();
            for (int i = 0; i <= 4; i++)
            {
                Console.Write($"Введите {i+1} элемент: ");
                int k = Convert.ToInt32(Console.ReadLine());
                list.Add(k);
            }
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
         
                Console.Write($"Введите индекс элемент: ");
                int index = Convert.ToInt32(Console.ReadLine());
                list.Delete(index);

                foreach (int i in list)
            {
                Console.WriteLine(i);
            }

                list.Clear();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
        }
        }
    
}
