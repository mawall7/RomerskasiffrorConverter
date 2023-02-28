using System;
using System.Collections.Generic;
using ExtensionMethods;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsNotInDictOrNull(this string s, Dictionary<string, int> d)
        {
            bool result = false;
            if (s != null)
            {

                foreach (char item in s)
                {
                    if (!d.ContainsKey(item.ToString()))
                        result = true;

                }
            }
            else if (s == null) result = true;
            return result;
        }
    }
}
