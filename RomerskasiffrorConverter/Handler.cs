using System;
using System.Collections.Generic;
using System.Text;

namespace RomerskasiffrorConverter
{
   public class Handler
    {
        private Dictionary<string, int> RomannumbersDict { get; set; }
        public void GetDictValue(string key, Dictionary<string, int> dict)
        {
            Console.WriteLine(dict[key]);
        }

        public static Handler Createhandlerclass()
        {
            return new Handler();
        }

        public void CreateNewDict() 
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

        public void Present()
        {
            foreach (var item in RomannumbersDict)
            {
                Console.WriteLine(item.Key);
            }
        }
        public int GetResultValue(string s)
        {
            return RomannumbersDict[s];
        }
    }
}
