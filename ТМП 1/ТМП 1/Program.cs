using System;
using System.Collections.Generic;

namespace ТМП_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            Queue<string> people = new Queue <string>();
            people.Enqueue("Кот");
            people.Enqueue("Миша");
            people.Enqueue("Филин");
            people.Enqueue("Жига");
            people.Enqueue("Мерседес");
            people.Enqueue("Поэт");
            foreach(string person in people)
            {
                Console.WriteLine(person);
            }
            int[] arr = { 1, 3, 9, 12, 2, 4 };
            int n = arr.Length;

            Sort ob = new Sort();
            ob.sort(arr);

            Console.WriteLine("Sorted array is");
            ob.printArray(arr);
        }
    }
}
