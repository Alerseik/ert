using System;

namespace _4_практическая
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b;
                int[] numbers = { 0, 1,2, 3, 4, 5, 6, 7, 8, 9 };

                Console.WriteLine("Введите два индекса элементов, которые хотите сложить. Номера элементов от 0 до " + (numbers.Length - 1));
                a = GetValueByIndex(numbers);
                b = GetValueByIndex(numbers);
                Console.WriteLine("Сумма двух элементов равна " + (a + b));
                Console.ReadKey();
            }

             static int GetValueByIndex(int[] array)
            {
                int a;
                while (true)
                {
                    try
                    {
                        int x = Convert.ToInt32(Console.ReadLine());
                        a = array[x];
                        Console.WriteLine("Элемент с индексом " + x + " равен " + a);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели не число");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Номер элемента должен быть в диапозона от 0 до " + (array.Length - 1));
                    }
                }
                return a;
            }
        }
    }
}

