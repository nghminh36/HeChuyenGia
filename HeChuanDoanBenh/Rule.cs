using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeChuanDoanBenh
{
    class Rule
    {
        private string name;
        private string suppose;
        private string conclusion;

        public string Conclusion
        {
            get { return conclusion; }
            set { conclusion = value; }
        }

        public string Suppose
        {
            get { return suppose; }
            set { suppose = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return name + " " + suppose + " => " + conclusion;
        }
    }
}
