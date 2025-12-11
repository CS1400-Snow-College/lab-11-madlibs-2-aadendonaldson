// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Json;

string generatedStory1 = "story1.txt";
string generatedStory2 = "story2.txt";

List<string> firstStory = new List<string>(File.ReadAllLines(generatedStory1));
List<string> secondStory = new List<string>(File.ReadAllLines(generatedStory2));
Dictionary<string, List<string>> answers = new Dictionary<string, List<string>>();

// assign values to keys like keys are indexes in an array
answers["verb"] = new List<string>();
answers["adjective"] = new List<string>();
answers["nown"] = new List<string>();
answers["plural-nown"] = new List<string>();
answers["place"] = new List<string>();

// check number of unique keys
//Debug.Assert(answers.Count == 3);

// ask if a key is in the dictionary
///Debug.Assert(categoryToWords.ContainsKey("fruit"));
//Debug.Assert(!categoryToWords.ContainsKey("country"));

// get the value for a given key using the key like an index into an array
//Debug.Assert(categoryToWords["fruit"].Count == 0);

answers["adjective"].Add("blue");
answers["adjective"].Add("short");
answers["adjective"].Add("young");

answers["verb"].Add("blue");
answers["verb"].Add("short");
answers["verb"].Add("young");

answers["nown"].Add("boy");
answers["nown"].Add("dog");
answers["nown"].Add("bear");

answers["plural-nown"].Add("blue");
answers["plural-nown"].Add("short");
answers["plural-nown"].Add("young");

answers["place"].Add("blue");
answers["place"].Add("short");
answers["place"].Add("young");

//Debug.Assert(categoryToWords["fruit"].Count == 2);
//Debug.Assert(categoryToWords["day"].Count == 0);
