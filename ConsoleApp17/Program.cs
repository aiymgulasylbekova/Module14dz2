using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {

        static Dictionary<string, int> CountWordFrequency(string text)
        {

            string[] words = text.Split(new[] { ' ', '.', ',', '-', '­', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);


            foreach (var word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится " +
                          "В доме, Который построил Джек. А это веселая птица­синица, Которая часто ворует " +
                          "пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            Dictionary<string, int> wordFrequency = CountWordFrequency(text);

            Console.WriteLine("Слово\t\tЧастота");
            Console.WriteLine("------------------------");
            foreach (var pair in wordFrequency)
            {
                Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            }
            Console.ReadKey();
        }

        
    }

}
