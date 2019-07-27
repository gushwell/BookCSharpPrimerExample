using System;
using System.Collections.Generic;

namespace DictionalySample {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("BCC", "Blind Carbon Copy");
            dict.Add("POP", "Post Office Protocol");
            dict.Add("MIME", "Multipurpose Internet Mail Extension");

            Console.WriteLine(dict["MIME"]);
            Console.WriteLine(dict["BCC"]);
            Console.WriteLine(dict["POP"]);
            Console.WriteLine();


            foreach (KeyValuePair<string, string> kv in dict) {
                Console.WriteLine(kv.Key + "=" + kv.Value);
            }
            Console.WriteLine();


            if (dict.ContainsKey("BCC"))
                Console.WriteLine("格納されています");
            Console.WriteLine();


            string value = "Blind Carbon Copy";
            if (dict.ContainsValue(value))
                Console.WriteLine("格納されています");
            Console.WriteLine();


            dict.Remove("POP");
            foreach (string key in dict.Keys) {
                Console.WriteLine(key + "=" + dict[key]);
            }
            Console.WriteLine();
            
            dict.Clear();
            Console.WriteLine(dict.Count);

            Console.ReadLine();


        }
    }
}
