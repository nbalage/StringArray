using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

            foreach (string s in strings)
            {
                Console.WriteLine($"\"{s}\" has {WordCount(s)} words.");
            }

            Console.ReadKey();
        }

        private static int WordCount(string sentence)
        {
            var count = sentence.Count(c => c == ' ');

            return count + 1;
        }
    }
}
