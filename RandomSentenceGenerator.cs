using System;

namespace RandomSentenceGeneratorByRosi
{
    internal class RandomSentenceGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Ivo", "Rosi", "Misho", "Anna", "Paola", "Ivet", "Tea", "Magi", "Ventsi", "Indi" };
            string[] places = { "Sofia", "Paris", "Milano", "Lille", "Pernik", "Pleven", "Burgas", "Budapest" };
            string[] verbs = { "eats", "sleeps", "holds", "looks at the", "thinks about the", "smiles at the", "plays with the", "drags the"};
            string[] nouns = { "bike", "sea", "book", "dog", "laptop", "teapot", "bottle", "cocktail" };
            string[] adverbs = { "slowly", "sadly", "fastly", "smilingly", "jokingly", "ironically", "happily" };
            string[] details = { "at home", "at the party", "near the metrostation", "on the roof"};

            Console.WriteLine("Hello! This is your first randomly generated sentence:");

            while (true)
            {

                Console.ReadLine(); //wait for ENTER to be pressed

                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomDetails = GetRandomWord(details);
                string randomAdverb = GetRandomWord(adverbs);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";

                string sentence = $"{who} {action} {randomDetails}.";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [ENTER] to generate a new one.");
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
