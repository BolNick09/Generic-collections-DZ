using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collections
{
    public class TaskDictionary
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public TaskDictionary() 
        {
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
        }
        public void translate()
        {
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
                foreach (var entry in dictionary)
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
        }


    }
}
