using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Так как текст задания не исчерпывающий, то код программы будет основан на следующих допущениях
 * 
 * 1) Дефис в начале примеров ввода не является частью строки
 * 2) Пробелы и запятые не являются целевыми символами, а лишь разделителями
 * 3) Разделители бывают двух видов " " и ", "
 * 4) Алфавит строк состоит из трех символов: a, b, c
 * 5) Символы всегда остортированы внутри входной строки
 * 6) Отсортированный блок из одинаковых символов не может быть больше трех (пример недопустимого ввода: "aaaa")
 */

namespace InterviewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c' };
            Dictionary<char, int> counter = InitCounter(alphabet);

            string inputString = Console.ReadLine();

            foreach (char c in inputString)
            {
                if (alphabet.Contains(c)) {
                    counter[c]++;
                }
                else
                {
                    continue;
                }
            }
            PrintCounter(counter);
            Console.ReadLine();
        }

        static Dictionary<char, int> InitCounter(char[] alphabet)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            const int initialValue = 0;

            foreach (char c in alphabet)
            {
                counter.Add(c, initialValue);
            }

            return counter;
        }

        static void PrintCounter(Dictionary<char, int> counter)
        {
            foreach (var charItem in counter)
            {
                Console.WriteLine("{0}: {1}", charItem.Key, charItem.Value);
            }
        }
    }
}
