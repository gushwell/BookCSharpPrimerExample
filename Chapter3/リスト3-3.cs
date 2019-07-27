using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Sample {
    public class Employee : Person {
        private int id;
        private string deptName;
        public int ID {
            get { return id; }
            set { id = value; }
        }
        public string DeptName {
            get { return deptName; }
            set { deptName = value; }
        }
    }
}
