using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Так как текст задания не исчерпывающий, то код программы будет основан на следующих допущениях
 * 
 * 1) Примеры являются примерами выходной коллекции, а не входной строки
 * 2) Алфавит строк состоит из всех строчных букв латинского алфавита
 * 3) Вывод отсортирован в порядке веса символа
 */

namespace InterviewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            char[] maxRates = GetMaxRatesChars(inputString);

            PrintMaxRates(maxRates);
            Console.ReadLine();
        }

        /**
         * Целевой метод
         */
        static char[] GetMaxRatesChars(string inputString)
        {
            const int outputChatLimit = 3;
            char[] alphabet = InitAlphabet();
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

            char[] maxRates = counter
                .Select(c => c)
                .OrderByDescending(c => c.Value)
                .Where(c => c.Value > 0)
                .Take(outputChatLimit)
                .Select(c => c.Key)
                .ToArray();

            return maxRates;
        }

        static char[] InitAlphabet()
        {
            const char start = 'a';
            const char end = 'z';
            char[] alphabet = new char[end - start + 1];

            for (char c = start; c <= end; c++)
            {
                alphabet[c - start] = c;
            }

            return alphabet;
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

        static void PrintMaxRates(char[] maxRates)
        {
            foreach (char c in maxRates)
            {
                Console.Write("{0} ", c);
            }
        }
    }
}
