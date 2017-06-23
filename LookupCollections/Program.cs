﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;


namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary listDictionary = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            listDictionary["Estados Unidos"] = "United States of America";
            listDictionary["Canadá"] = "Canada";
            listDictionary["España"] = "Spain";

            Console.WriteLine(listDictionary["españa"]);
            Console.WriteLine(listDictionary["CANADÁ"]);
            Console.Read();
        }
    }
}
