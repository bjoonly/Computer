using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Printer : IPrintInformation
    {
        public string GetName()
        {
            return "Printer";
        }

        public void Print(string str)
        {
            Console.WriteLine("Printer print: "+str);
        }
        public override string ToString()
        {
            return "Show device " + GetName();
        }
    }
}
