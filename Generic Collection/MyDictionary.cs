using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class MyDictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string,string> d = new Dictionary<string,string>();
            Console.WriteLine("Synonyms:");
            d.Add("Admit", "Confess");
            d.Add("reply", "answer");
            d.Add("Thief" , "Burglar");
            d.Add("Rich", "Wealthy");
            d.Add("Weeping", "Crying");

            foreach(KeyValuePair<string,string> kvp in d)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value );
            }

            foreach(var i in d.Keys)
            {
                Console.WriteLine(i);
            }
            foreach(var i in d.Values)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
