using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ExtensionMethods;


//Romerska siffror converter. AddKeys() populerar en lista med de numeriska värdena för de romerska siffrorna som översätts av en dictionary som är private i klasssen Handler. Compared results() metoden sköter logiken (för addition eller subtraktion).  
namespace RomerskasiffrorConverter
{
    using ExtensionMethods;
    public class Program
    {
        public delegate void GetStartinfodelegate();
        public static void Main(string[] args)
        {
            
            string keys = null;


            //Handler newHandler = new Handler();
            IRomanIntConverter newConverter = new RomanIntConverter();

            //List<int> numbers = new List<int>();
            //Console.WriteLine(newConverter.GetVersion());
            GetStartinfodelegate del = new GetStartinfodelegate(newConverter.GetVersion);
            del = del + newConverter.GetDate; //obs en multikast delegate där två metoder returnerar void. string returnerar bara den sista metodens string.
            //GetStartinfodelegate del2 = new GetStartinfodelegate(newConverter.GetDate);
            //GetStartinfodelegate del3 = del + del2 ;
            
            del.Invoke();
            //Console.Write("Romerska siffror-Converter 2023\n");
            Console.Write("Skriv ett romerskt tal: ");
            
            //Readkey
            while (string.IsNullOrWhiteSpace(keys) || !keys.IsKeysOfDict(newConverter.RomannumbersDict)) 
            {
               keys = Console.ReadLine().ToUpper();
                 
            }


            newConverter.AddKeys(keys);
            //numbers = newConverter.GetNumbers();

            int result = newConverter.ConvertToInt();
                
            Console.WriteLine(result);
            Console.ReadKey();
        }

        

        
    }


}
