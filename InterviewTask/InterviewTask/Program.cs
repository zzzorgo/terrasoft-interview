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
 */

namespace InterviewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Dictionary<char, int> counter = GetMaxRateChars(inputString);

            PrintCounter(counter);
            Console.ReadLine();
        }

        /**
         * Целевой метод
         */
        static Dictionary<char, int> GetMaxRateChars(string inputString)
        {
            char[] alphabet = { 'a', 'b', 'c' };
            Dictionary<char, int> counter = InitCounter(alphabet);

            foreach (char c in inputString)
            {
                if (alphabet.Contains(c))
                {
                    counter[c]++;
                }
                else
                {
                    continue;
                }
            }

            return counter;
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
