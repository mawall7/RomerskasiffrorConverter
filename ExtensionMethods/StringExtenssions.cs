using System;
using System.Collections.Generic;
using ExtensionMethods;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsKeysOfDict(this string s, Dictionary<string, int> d)
        {
            bool result = true;
            
                foreach (char item in s)
                {
                    if (!d.ContainsKey(item.ToString()))
                        result = false;

                }
            
            return result;
        }
    }
}
