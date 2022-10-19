using System;

namespace RandomSentencesGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this is your first random-generated sentence: ");
            while (true)
            {
                string randomName = GetRandomNumber(names);
                string randomPlaces = GetRandomNumber(places);
                string randomVerbs = GetRandomNumber(verbs);
                string randomNouns = GetRandomNumber(nouns);
                string randomAdverbs = GetRandomNumber(adverbs);
                string randomDetails = GetRandomNumber(details);

                string who = $"{randomName} from {randomPlaces}";
                string action = $"{randomAdverbs} {randomVerbs} {randomNouns}";
                string sentence = $"{who} {action} {randomDetails}.";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.ReadKey();
            }



          
            
        }

        static string GetRandomNumber(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];

            return word;
        }

    }
}
