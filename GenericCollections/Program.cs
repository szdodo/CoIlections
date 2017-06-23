using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary[44] = "United Kingdom";
            dictionary[33] = "France";
            dictionary[31] = "Netherlands";
            dictionary[55] = "Brazil";

            Console.WriteLine("The 33 Code is for: {0}", dictionary[33]);

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }

            Console.Read();
        }
    }
}

