using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> emogisDict = new Dictionary<string, long>(); 
            string input = Console.ReadLine();
            //string dotEmojiReg = @"[:]{2}([A-Z][a-z]{2,})[:]{2}";
            string dotEmojiReg = @"([*]{2})[A-Z][a-z]{2,}([*]{2})|([:]{2})[A-Z][a-z]{2,}([:]{2})";
            //string staremjireg = @"\*{2}([A-Z][a-z]{2,})\*{2}";
            string digitereg = @"(\d)";

            Regex em1 = new Regex (dotEmojiReg);
           // Regex em2 = new Regex(staremjireg);
            Regex dig = new Regex(digitereg);
            MatchCollection emogi1 = em1.Matches(input);
            //MatchCollection emogi2 = em2.Matches(input);
            MatchCollection digits = dig.Matches(input);
            long treshold = TresholCounter(digits);
            emogisDict =  TransferToDict(emogi1, emogisDict);
           // emogisDict =  TransferToDict(emogi2, emogisDict);
            int coolAll = emogisDict.Count;

            emogisDict = DictFilter(emogisDict, treshold);

            Console.WriteLine($"Cool threshold: {treshold}");

            if (coolAll>0)
            {
                Console.WriteLine($"{coolAll} emojis found in the text. The cool ones are:");
                foreach (var emogi in emogisDict)//.OrderByDescending(x=>x.Key))
                {
                    Console.WriteLine(emogi.Key);
                    
                }
            }

        }

        private static Dictionary<string, long> DictFilter(Dictionary<string, long> emogisDict, long treshold)
        {
            foreach (var emogi in emogisDict)
            {
                if (emogi.Value<treshold)
                {
                    emogisDict.Remove(emogi.Key);
                }
            }
            return emogisDict;
        }

        private static long TresholCounter(MatchCollection digits)
        {
            long n = 0;
            foreach (var item in digits)
            {
                if (n==0)
                {
                    n+= long.Parse(item.ToString());
                }
                else
                {
                    n *= long.Parse(item.ToString());
                }
               
            }
            return n;
        }

        private static Dictionary<string, long> TransferToDict(MatchCollection emogi1, Dictionary<string, long> emogisDict)
        {
            foreach (var item in emogi1)
            {
                string textOfCapt = item.ToString();
                string txt = item.ToString();
                txt = txt.Remove(0, 2);
                 txt= txt.Remove(txt.Length - 2, 2);
                long n = Calculator(txt);
                
                emogisDict.Add(textOfCapt, n);
            }
            return emogisDict;
        }

        private static long Calculator(string txt)
        {
            long digits = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                digits += (char)txt[i];
            }
            return digits;
        }
    }
    
}
