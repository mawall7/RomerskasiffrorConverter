using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//Romerska siffror converter. AddKeys() populerar en lista med de numeriska värdena för de romerska siffrorna som översätts av en dictionary som är private i klasssen Handler. Compared results() metoden sköter logiken (för addition eller subtraktion).  
namespace RomerskasiffrorConverter
{
    class Program
    {
                
        public static void Main(string[] args)
        {
            int? results = 0;
            string keys = null;



            //Handler newHandler = new Handler();
            Handler newHandler = Handler.Createhandlerclass();
            newHandler.CreateNewDict();
            List<int> numbers = new List<int>();
           
            Console.Write("Romerska siffror-Converter 2023\nSkriv ett romerskt tal: ");
            
            //Readkey
            while (string.IsNullOrWhiteSpace(keys))
            {
                keys = Console.ReadLine().ToUpper();
                
            }

            
            foreach (int item in AddKeys(keys, newHandler))
            {
               
                numbers.Add(item);
                                
            }
            
                
             for (int i = numbers.Count - 1; i >= 0; i--)
             {
                int? Compared = Comparedresults(i, i - 1, numbers);
                if (Compared != null)
                {
                    results = results + Compared;
                    --i;
                }
                else if (Compared == null)
                    results = results + numbers[i];

            }

            Console.WriteLine(results);
            
            
            Console.ReadKey();
        }

        private static int? Comparedresults(int i, int v, List<int>numbers)
        {
            int? result;
            int y = 0; 
            if(v>=0) y = numbers[v];
            int x = numbers[i]; 
            result = y > x ? x + y :  x - y;
            if (x == y) result = null;
            return result;
            
        }
        public static IEnumerable AddKeys(string k, Handler h)
        {
            //h.CreateNewDict();
            for (int i = 0; i < k.Length; i++)
            {
                yield return h.GetResultValue(k[i].ToString());

            }
          
        }
    }


}
