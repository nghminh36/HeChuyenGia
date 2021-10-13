using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeChuanDoanBenh
{
    class Road
    {
        private Node node;
        private Rule rule;

        internal Node Node
        {
            get { return node; }
            set { node = value; }
        }


        internal Rule Rule
        {
            get { return rule; }
            set { rule = value; }
        }
    }
}
