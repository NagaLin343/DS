using System;
using System.Collections.Generic;
using System.Collections;

namespace DS5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 7, 4, 1, 3, 8, 5, 6 };
            Console.Write("Введите номер сортировки (1-Пузырек 2-Шейкер 3-Вставка 4-Выбором): ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k == 1)
            {

                for (int i = array.Length; i > 0; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (array[j + 1] < array[j])
                        {
                            int a = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = a;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            else if (k == 2)
            {
                int left = 0;
                int right = array.Length - 1;
                while (left <= right)
                {
                    for (int i = right; i > left; i--)
                    {
                        if (array[i - 1] > array[i])
                        {
                            int b = array[i - 1];
                            array[i - 1] = array[i];
                            array[i] = b;
                        }
                    }
                    left++;
                    for (int i = left; i < right; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int b = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = b;
                        }
                    }
                    right--;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            // else if (k == 3) Расческа(как реализовать?)
            // {
            //    const double factor = 1.247; // Фактор уменьшения
            //    double step = array.Length - 1;

            //while (step >= 1)
            //  {
            //         for (int i = 0; i + step < array.Length; ++i)
            //         {
            //             if (array[i] > array[i + Convert.ToInt32(step)])
            //             {
            //                 int c = array[i];
            //                 array[i] = array[i+ Convert.ToInt32(step)];
            //                 array[i + Convert.ToInt32(step)] = i;
            //             }
            //         }
            //         step /= factor;
            //     }
            //     // сортировка пузырьком

            //     for (int i = array.Length; i > 0; i--)
            //     {
            //         for (int j = 0; j < i - 1; j++)
            //         {
            //             if (array[j + 1] < array[j])
            //             {
            //                 int a = array[j + 1];
            //                 array[j + 1] = array[j];
            //                 array[j] = a;
            //             }
            //         }
            //     }
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         Console.WriteLine(array[i]);
            //     }

            // }

            else if (k == 3)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int x = array[i];
                    int j = i;
                    while (j > 0 && array[j - 1] > x)
                    {
                        array[j] = array[j - 1];
                        j--;
                    }
                    array[j] = x;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            else if (k == 4)
            {
                for (int i = 0; i != array.Length; i++)
                {
                    int j = Min(i,array);
                    int d = array[i];
                    array[i] = array[j];
                    array[j] = d;
                  
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            static int Min(int i,int[] arg)
            { 
                int min = arg[i];
                int k=0;
                for (int j = i; j < arg.Length; j++)
                {
                    if (min >= arg[j])
                    {
                        min = arg[j];
                        k = j;
                    }
                }
                return k;
            }

        }
    }
}