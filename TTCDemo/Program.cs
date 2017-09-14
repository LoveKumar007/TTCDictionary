using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCDictionary;

namespace TTCDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
            LanguageDictionary LanguageDictionary = new LanguageDictionary(list);
            Console.WriteLine("Output of Add method with Language=English and word=word ");
            Console.WriteLine(LanguageDictionary.Add("English", "word"));

            Console.WriteLine("Output of Add method with Language=English and word=words ");
            Console.WriteLine(LanguageDictionary.Add("English", "words"));

            Console.WriteLine("Output of Add method with Language=Spanish and word=Hola ");
            Console.WriteLine(LanguageDictionary.Add("Spanish", "Hola"));

            Console.WriteLine("Output of Add method with Language=Spanish and word=Hola ");
            Console.WriteLine(LanguageDictionary.Add("Spanish", "Hola"));


            Console.WriteLine("Output of Check method with Language=Language and word=word ");
            Console.WriteLine(LanguageDictionary.Check("language", "word"));

            Console.WriteLine("Output of Check method with Language=English and word=words ");
            Console.WriteLine(LanguageDictionary.Check("English", "words"));

            Console.WriteLine("Output of Check method with Language=Spanish and word=Hola ");
            Console.WriteLine(LanguageDictionary.Check("Spanish", "Hola"));

            Console.WriteLine("Output of Check method with Language=Spanish and word=Amigo ");
            Console.WriteLine(LanguageDictionary.Check("Spanish", "Amigo"));



            ////Console.WriteLine("Output of Search method with Language=Language and word=word ");
            ////Console.WriteLine(LanguageDictionary.Search("word"));

            Console.WriteLine("Output of Search method with Language=English and word=words ");
            Console.WriteLine(LanguageDictionary.Search("wor").ToString());

            //Console.WriteLine("Output of Search method with Language=Spanish and word=Hola ");
            //Console.WriteLine(LanguageDictionary.Search("Hola"));

            //Console.WriteLine("Output of Search method with Language=Spanish and word=Amigo ");
            //Console.WriteLine(LanguageDictionary.Search("ho"));


            Console.ReadKey();

        }
    }
}
