using System;
using System.Collections.Generic;
using System.Text;

namespace RomerskasiffrorConverter
{
   public class RomanIntConverter  
    {
        public Dictionary<string, int> RomannumbersDict { get; }
        public List<int> Numbers { get; }

        public RomanIntConverter()
        {
            Numbers = new List<int>();

            RomannumbersDict = new Dictionary<string, int>()
            {
                {"I",1 },
                {"V", 5 },
                {"X", 10 },
                {"L", 50 },
                {"C",100 },
                {"D", 500 },
                {"M", 1000 }
            };
        }
        
        public void GetDictValue(string key, Dictionary<string, int> dict)
        {
            Console.WriteLine(dict[key]);
            
        }

        public List<int> GetNumbers() => Numbers;
       
        public int GetResultValue(string s)
        {
            return RomannumbersDict[s];
        }

        public void AddKeys(string keys)
        {
            int value;
            foreach(char item in keys)
            {
                value = GetResultValue(item.ToString());
                Numbers.Add(value);
            }
        }

        public int ConvertToInt()
        {
            int results = 0;
            
            for (int i = Numbers.Count - 1; i >= 0; i--)
            {
                int? Compared = Comparedresults(i, i - 1, Numbers);
                if (Compared != null)
                {
                    results = results + (int)Compared;
                    --i;
                }
                else if (Compared == null)
                    results = results + Numbers[i];

            }
            return results;
        }

        private static int? Comparedresults(int i, int v, List<int> numbers)
        {
            int? result;
            int y = 0;
            if (v >= 0) y = numbers[v];
            int x = numbers[i];
            result = y > x ? x + y : x - y;
            if (x == y) result = null;
            return result;

        }


    }
}
