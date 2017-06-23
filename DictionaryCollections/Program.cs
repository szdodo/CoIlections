using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable["0"] = "zero";
            hashtable["1"] = "one";
            hashtable["2"] = "two";
            hashtable["3"] = "three";
            hashtable["4"] = "four";
            hashtable["5"] = "five";
            hashtable["6"] = "six";
            hashtable["7"] = "seven";
            hashtable["8"] = "eight";
            hashtable["9"] = "nine";

            string ourNumber = "888-555-1212";

            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (hashtable.ContainsKey(digit))
                {
                    Console.WriteLine(hashtable[digit]);
                }
            }
        }
    }
}