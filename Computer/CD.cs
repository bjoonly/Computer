using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class CD :Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk
        {
            get { return hasDisk; }
        }
        public CD(string memory, int memSize) : base(memory, memSize) {
            hasDisk = false;

        }

        public void Insert()
        {
            if (hasDisk)
                Console.WriteLine("Unable to insert disk.Disk is already inserted.");
            else
            {
                hasDisk = true;
                Console.WriteLine(GetName()+" is inserted");
            }
        }
        public override string GetName()
        {
            return "CD";
        }
        public void Reject()
        {
            if(!hasDisk)
                Console.WriteLine("No disk, which you can remove.");
            else
            {
                hasDisk = false;
                Console.WriteLine(GetName()+" is removed.");
            }
        }
       
    }
}
