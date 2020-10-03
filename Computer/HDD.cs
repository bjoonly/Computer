using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class HDD:Disk
    {
        public override string GetName()
        {
            return "HDD";
        }
        public HDD(string memory, int memSize):base(memory,memSize) {   }
    }
}
