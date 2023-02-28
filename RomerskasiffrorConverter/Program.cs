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
            RomanIntConverter newConverter = new RomanIntConverter();
            newConverter.CreateNewDict();
            List<int> numbers = new List<int>();
           
            Console.Write("Romerska siffror-Converter 2023\nSkriv ett romerskt tal: ");
            
            //Readkey
            while (string.IsNullOrWhiteSpace(keys)) //to do Extensionmetod på string för att bara tillåta ivxcm 
            {
                keys = Console.ReadLine().ToUpper();
                
            }


            newConverter.AddKeys(keys);
            numbers = newConverter.GetNumbers();
            
           

            int result = Getresultfromints(numbers);
                
            Console.WriteLine(result);
            
            
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
        

        public static int Getresultfromints(List<int> numbers)
        {
            int results = 0;
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int? Compared = Comparedresults(i, i - 1, numbers);
                if (Compared != null)
                {
                    results = results + (int)Compared;
                    --i;
                }
                else if (Compared == null)
                    results = results + numbers[i];

            }
            return results;
        }

        //public static IEnumerable AddKeys(string k, RomanIntConverter h)
        //{
        //    //h.CreateNewDict();
        //    for (int i = 0; i < k.Length; i++)
        //    {
        //        yield return h.GetResultValue(k[i].ToString());

        //    }

        //}
    }


}
