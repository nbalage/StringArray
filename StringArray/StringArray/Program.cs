using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings =
            {
                "You only live forever in the lights you make",
                "When we were young we used to say",
                "That you only hear the music when your heart begins to break",
                "Now we are the kids from yesterday"
            };

            Console.WriteLine("1.");
            foreach (string s in strings)
            {
                Console.WriteLine($"\"{s}\" has {WordCount(s)} words.");
            }

            Console.WriteLine("2.");
            foreach (string s in strings)
            {
                foreach (var word in StartWithVowel(s))
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("3.");
            foreach (string s in strings)
            {
                Console.WriteLine($"{LongestWord(s)}");
            }

            Console.WriteLine("4.");
            foreach (string s in strings)
            {
                Console.WriteLine($"Average word length: {AverageWordCount(s)}.");
            }

            Console.WriteLine("5.");
            foreach (string s in strings)
            {
                var orderedWords = WordsInAlphabeticOrder(s);
                foreach (var word in orderedWords)
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static int WordCount(string sentence)
        {
            var count = sentence.Count(c => c == ' ');

            return count + 1;
        }

        private static IEnumerable<string> StartWithVowel(string sentence)
        {
            var chars = new List<char>
            {
                'a', 'e', 'i', 'o', 'u'
            };
            var splits = sentence.Split(' ');

            return splits.Where(c => chars.Contains(c.ToLower().First()));
        }

        private static string LongestWord(string sentence)
        {
            var lengths = WordsWithLenght(sentence);

            return lengths.OrderByDescending(l => l.count).Select(l => l.word).First();
        }

        private static double AverageWordCount(string sentence)
        {
            var lengths = WordsWithLenght(sentence);

            return lengths.Average(l => l.count);
        }

        private static IOrderedEnumerable<string> WordsInAlphabeticOrder(string sentence)
        {
            var splits = sentence.Split(' ');

            return splits.Distinct().OrderBy(s => s[0]);
        }

        private static List<(string word, int count)> WordsWithLenght(string sentence)
        {
            List<(string word, int count)> lengths = new List<(string word, int count)>();

            foreach (var item in sentence.Split(' '))
            {
                lengths.Add((item, item.Length));
            }

            return lengths;
        }
    }
}
