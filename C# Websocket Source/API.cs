using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace WordFinderServer
{
    public class UsedWordBase
    {
        public string FullWord { get; set; }
        public string Letters { get; set; }
    }
    public class API
    {
        private static string[] dictionary = new WebClient().DownloadString("https://raw.githubusercontent.com/DeLuxe1337001/jklm-bombparty-bot/main/dictionary.txt").Split('\n');
        private static List<UsedWordBase> UsedWords = new List<UsedWordBase>();
        public static string Find(string letters)
        { 
            foreach(var word in dictionary)
            {
                if (word.Contains(letters))
                {
                    if (UsedWords.Exists(x => x.FullWord == word && x.Letters == letters) == true)
                    {
                        Console.WriteLine("This word is already used!");
                        break;
                    }
                    Console.WriteLine(word.ToUpper());
                    UsedWordBase uwb = new UsedWordBase();
                    uwb.Letters = letters;
                    uwb.FullWord = word;

                    UsedWords.Add(uwb);
                    return word.ToUpper();
                }
            }

            return "NULL";
        }
    }
}
