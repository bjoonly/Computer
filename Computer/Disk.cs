using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Disk : IDisk
    {
        private string memory;
        public string Memory
        { 
            get { return memory; }
            set
            {
                memory = value;
            }
        }
        private int memSize;
        public int MemSize
        {
            get { return memSize; }
            set
            {
                if (value < 0)
                    value = 0;
                memSize = value;
            }
        }
        public Disk() : this("",0) { }
        public Disk(string memory,int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }
        virtual public string GetName()
        {
            return "Disk";
        }
        public string Read()
        {
            return $"Read from {GetName()}\n{Memory}";
        }

        public void Write(string text)
        {
            Console.WriteLine("Write "+text+" in memory of "+GetName());
            Memory = text;
        }
        public override string ToString()
        {
            return $"Name: {GetName()}\nMemory: {Memory}\nMemory size: {MemSize}";
        }
    }
}
