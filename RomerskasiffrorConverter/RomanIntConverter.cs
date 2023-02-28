using System;
using System.Collections.Generic;
using System.Text;

namespace RomerskasiffrorConverter
{
   public class RomanIntConverter
    {
        private Dictionary<string, int> RomannumbersDict { get; set; }
        public List<int> Numbers { get; set; }

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


    }
}
