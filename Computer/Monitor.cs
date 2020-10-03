using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return "Monitor";
        }

        public void Print(string str)
        {
            Console.WriteLine("Monitor show:" +str);
        }
        public override string ToString()
        {
            return "Show device " + GetName();
        }
    }
}
