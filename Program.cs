using System.Collections;
using System.Collections.Generic;
namespace Generic_collections
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Необощенная к
            //ArrayList arrayList = new ArrayList 
            //    (
            //        new int[] {1, 3, 44},
            //        new string[] {"test1", "test2"}
            //    );

            /*ArrayList arrayList = new ArrayList();

             Console.WriteLine($"Default cap: { arrayList.Capacity}");

             arrayList.Add("one");
             Console.WriteLine($"Default cap: {arrayList.Capacity}");

             arrayList.Add (new int[] { 1, 3, 44 });
             Console.WriteLine($"Default cap: {arrayList.Capacity}");


             Stack st1 = new Stack();
             Stack st2 = new Stack(7);
             Stack st3 = new Stack(new ArrayList { 3, 5, 7});*/
            /*
            Hashtable dictionary = new Hashtable();

            dictionary.Add("Россия", "Russia");
            dictionary.Add("Великобритания", "Great Britain");
            dictionary.Add("Франция", "France");
            dictionary.Add("Германия", "Germany");
            dictionary.Add("Испания", "Spain");
            dictionary.Add("Италия", "Italy");
            dictionary.Add("Япония", "Japan");
            dictionary.Add("Китай", "China");
            dictionary.Add("США", "USA");
            dictionary.Add("Канада", "Canada");

            // Запросить у пользователя направление перевода
            Console.WriteLine("Введите направление перевода (0 - русский-английский 1 - английский-русский):");
            int direction = Int32.Parse(Console.ReadLine());

            // Запросить у пользователя слово для перевода
            Console.WriteLine("Введите слово для перевода:");
            string word = Console.ReadLine();

            // Выполнить перевод
            string translation = "";
            if (direction == 0)
            {
                translation = (string)dictionary[word];
            }
            else if (direction == 1)
            {
                foreach (DictionaryEntry entry in dictionary)
                {
                    if (entry.Value.Equals(word))
                    {
                        translation = (string)entry.Key;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Неверное направление перевода");
                return;
            }

            // Вывести перевод
            Console.WriteLine($"Перевод: {translation}");
            */

            /*int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            RangeOfArray range = new RangeOfArray(array, 3, 7);

            Console.WriteLine("Длина диапазона:");
            Console.WriteLine(range.Length); // 5

            Console.WriteLine("Элементы диапазона:");
            for (int i = 0; i < range.Length; i++)
            {
                Console.WriteLine(range[i]); // 4, 5, 6, 7, 8
            } */


            Console.WriteLine("Task 1");
            TaskDictionary dictionary = new TaskDictionary();
            dictionary.translate();
            Console.WriteLine("------------------------");
            Console.WriteLine("Task2");





        }
    }

    
}
