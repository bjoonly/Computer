using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Computer computer = new Computer(4, 2);
            Console.WriteLine("Add printer: ");
            computer.AddDevice(0, new Printer());
            computer.ShowPrintDevice();
            Console.WriteLine("\nAdd monitor: ");
            computer.AddDevice(1, new Monitor());
            computer.ShowPrintDevice();
            Console.WriteLine("\nAdd CD: ");
            computer.AddDisk(0,new CD("Some info on CD disk",700));
            computer.ShowDisk();
            Console.WriteLine("\nAdd HDD: ");
            computer.AddDisk(1, new HDD("Some info on HDD disk", 1));
            computer.ShowDisk();
            Console.WriteLine("\nAdd DVD: ");
            computer.AddDisk(2, new DVD("Some info on DVD disk", 8));
            computer.ShowDisk();
            Console.WriteLine("\nAdd Flash: ");
            computer.AddDisk(3, new Flash("Some info on Flash disk", 256));
            computer.ShowDisk();
            Console.WriteLine("\nPrint info: ");
            computer.PrintInfo("Line to show in device","Printer");
            Console.WriteLine("\nWrite info to disk:");
            computer.WriteInfo("Text for writing", "HDD");
            Console.WriteLine("\nRead info from disk:");
            Console.WriteLine(computer.ReadInfo("HDD"));
            Console.WriteLine("\nInsert disk:");
            computer.InsertReject("Flash", true);
            Console.WriteLine("\nReject disk:");
            computer.InsertReject("Flash", false);
         
        }
    }
}
