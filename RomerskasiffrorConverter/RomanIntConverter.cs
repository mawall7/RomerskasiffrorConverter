using System;
using System.Collections.Generic;
using System.Text;

namespace RomerskasiffrorConverter
{
   public class RomanIntConverter
    {
        private Dictionary<string, int> RomannumbersDict { get; set; }
        private List<int> Numbers { get; }
        
        public void GetDictValue(string key, Dictionary<string, int> dict)
        {
            Console.WriteLine(dict[key]);
        }

        public void CreateNewDict() //to do move to konstruktor
        {
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

       
        public int GetResultValue(string s)
        {
            return RomannumbersDict[s];
        }

        private static void AddKeys(string keys)
        {
            foreach (int item in keys)
            {

                Numbers.Add(item);

            }

        }


    }
}
