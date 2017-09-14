using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCDictionary
{
    public class LanguageDictionary : ILanguageDictionary
    {
        /// <summary>
        /// This Dictionary Definition changed as per the One Key (one language) with Multiple Values (Multiple words) - (using as one to many relation)
        /// </summary>
        private Dictionary<string, List<string>> list;

        /// <summary>
        /// LanguageDictionary - Constructor
        /// </summary>
        /// <param name="list"></param>
        public LanguageDictionary(Dictionary<string, List<string>> list)
        {
            this.list = list;
        }

        /// <summary>
        /// Check - Checking the Word as per the Key
        /// </summary>
        /// <param name="language"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Check(string language, string word)
        {
            if (list.ContainsKey(language) && list[language].Contains(word))
                return true;

            else return false;
        }

        /// <summary>
        /// Add - Key Value adding in a Dictionary
        /// </summary>
        /// <param name="language"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool Add(string language, string word)
        {
            //Combination of Language and word already exists
            if (list.Any(i => i.Key == language && i.Value.Any(j => j == word)))
            {
                return false;
            }
            // Key/Laguage already exists
            else if (list.ContainsKey(language))
            {
                list[language].Add(word);
                return true;
            }
            //Languag and word does not exists
            else
            {
                list.Add(language, new List<string> { word });
                return true;
            }
        }

        /// <summary>
        /// Search - It is using to Search values in total list
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public IEnumerable<string> Search(string word)
        {
            List<string> lsistToReturn = new List<string>();

            foreach (var KeyItem in list)
            {
                foreach (var wordSValue in KeyItem.Value)
                {
                    if (wordSValue.StartsWith(word))
                    {
                        lsistToReturn.Add(wordSValue);
                    }
                }
            }
            return lsistToReturn;
        }


    }
}
