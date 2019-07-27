using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List9_19 {
    class Program {
        static void Main(string[] args) {
            string[] names = { 
                "Microsoft", "Apple", "Oracle", "IBM", "Google", "Adobe",  
            };
            IEnumerable<string> query = names.Where(s => s.Length >= 6)
                                             .Select(s => s.ToLower());
            foreach (string s in query)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
