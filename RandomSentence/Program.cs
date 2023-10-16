﻿namespace RandomSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Denis", "Julien", "Borko", "Behatov", "Daniel", "Sasho", "Viktor" };
            string[] places = { "Sofia", "Varna", "Burgas", "Ruse", "Plovdiv", "Nesebar", "Veliko Tarnovo" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings"};
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this is your first random-generated sentence: ");
            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                //"Who from where", then "Action" and last "Details":
                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");

                Console.ReadLine();
            }
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}