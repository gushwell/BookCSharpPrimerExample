using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    public class Person {
        private string _name;
        private int _age;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public int Age {
            get { return _age; }
            set { _age = value; }
        }
        public string Format() {
            return string.Format("{0}({1})", Name, Age);
        }
    }
}

