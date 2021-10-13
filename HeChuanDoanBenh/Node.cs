using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeChuanDoanBenh
{
    class Node
    {
        private string name;
        private string text;
        private int value;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return name + " " + text;
        }

    }
}
