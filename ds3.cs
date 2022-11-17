using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class MyList
    {
        static void Main()
        {
            int k,j;
            Console.Write("Введите к: ");
            k = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            List<int> num = new List<int>(k);

            for (int i =0; i <k; i++)
            {
                num.Add(rand.Next(0, 30));
            }

            foreach (var person in num)//перебор списка и его вывод
            {
                Console.WriteLine(person);
            }
            //ИЛИ
            Console.WriteLine("Добавим в список числа 2 5 6 ");
            num.AddRange(new[] { 2, 5, 6 });//добавляем массив
             for (int i = 0; i < num.Count; i++)
              {
               Console.WriteLine(num[i]);
              }

             //*КАК РЕАЛИЗОВАТЬ ДОБАВЛЕНИЕ МАССИВА С КЛАВИАТУРЫ *//

            //Console.WriteLine("Добавим в список 3 числа: ");
           // for (int i = 0; i < 3; i++)
           // {
           //     int[] nums = new int[i];
           // }
           // num.AddRange(nums);
           // for (int i = 0; i < num.Count; i++)
           // {
          //      Console.WriteLine(num[i]);
          //  }

            Console.Write("Добавим в начало списока число: ");
            int d = Convert.ToInt32(Console.ReadLine());
            num.Insert(0, d);
            foreach (var person in num)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Удалим первый элемент");
            num.RemoveAt(0);
            foreach (var person in num)
            {
                Console.WriteLine(person);
            }

            Console.Write("Удалим 2 элемента начиная с индекса: ");
            int t = Convert.ToInt32(Console.ReadLine());
            num.RemoveRange(t-1, 2);
            foreach (var person in num)
            {
                Console.WriteLine(person);
            }

            Console.Write("Введите число, наличие которого будем проверять: ");
            int u = Convert.ToInt32(Console.ReadLine());
            var res = num.Contains(u);
            Console.WriteLine(res);

            Console.Write("Длинна списка: ");//если бы мы не вводили длину списка
            Console.WriteLine(num.Count);


            Console.Write("Введите индекс элемента, который мы заменим на 0: ");
            j = Convert.ToInt32(Console.ReadLine());
            num[j-1] = 0;
            foreach (var person in num)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Перевернем список");//можно перевернуть часть списка num.Reverse(откуда, сколько)
            num.Reverse();
            foreach (var person in num)
            {
                Console.WriteLine(person);
            }
        }
    }
}
