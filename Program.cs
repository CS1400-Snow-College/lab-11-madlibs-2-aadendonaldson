// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization.Json;
class Program {
    static void Main(string[] filenames) {
       // List<string> firstStory = new List<string>(File.ReadAllLines("story1.txt"));
//List<string> secondStory = new List<string>(File.ReadAllLines("story2.txt"));
Dictionary<string, List<string>> answers = new Dictionary<string, List<string>>();

// assign values to keys like keys are indexes in an array
answers["verb"] = new List<string>();
answers["adjective"] = new List<string>();
answers["noun"] = new List<string>();
answers["plural-noun"] = new List<string>();
answers["place"] = new List<string>();
answers["past-tense-verb"] = new List<string>();

answers["adjective"].Add("blue");
answers["adjective"].Add("short");
answers["adjective"].Add("young");

answers["past-tense-verb"].Add("swam");
answers["past-tense-verb"].Add("ran");
answers["past-tense-verb"].Add("sleeped");

answers["verb"].Add("run");
answers["verb"].Add("feed");
answers["verb"].Add("swim");

answers["noun"].Add("boy");
answers["noun"].Add("dog");
answers["noun"].Add("bear");

answers["plural-noun"].Add("cats");
answers["plural-noun"].Add("geece");
answers["plural-noun"].Add("birds");

answers["place"].Add("New York City");
answers["place"].Add("Sleepy Town");
answers["place"].Add("Random Ahh City");

        foreach (string filename in filenames) 
        {
            List<string> firstStory = new List<string>(File.ReadAllLines(filename));
            ThePrintMethod(answers, firstStory);
            Console.WriteLine("      ");
        }
        static void ThePrintMethod(Dictionary<string, List<string>> digitalInput, List<string> story)
{
    foreach (string line in story)
    {
    string[]wordsArray = line.Split(' ');
    foreach (string word in wordsArray)
    {
        if (word.StartsWith("::"))
        {
            Random rand = new Random();
            int number = rand.Next(3);
            string cleanWord= word.TrimStart(':', ':');
            string newWord = digitalInput[cleanWord][number];
            Console.Write(newWord + " ");
        } 
        else
        {
            Console.Write(word + " ");
        }
            
    }
    }
}
 
}
    }

