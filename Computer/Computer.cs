using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Computer
    {
        private int CountDisk { get; }
        private int CountPrintDevice { get; }
        private Disk[] Disks { get; }
        private IPrintInformation[] PrintDevice { get; }
        public Computer(int d, int pd)
        {
            if (d < 1)
                d = 1;
            CountDisk = d;
            Disks = new Disk[CountDisk];
            if (pd < 1)
                pd = 1;
            CountPrintDevice = pd;
            PrintDevice = new IPrintInformation[CountPrintDevice];
        }
        public void AddDevice(int index, IPrintInformation si)
        {
            if (PrintDevice[index] != null)
                throw new Exception("Unable to add a device to the selected slot.");

            PrintDevice[index] = si;
        }
        public void AddDisk(int index, Disk d)
        {
            if (Disks[index] != null)
                throw new Exception("Unable to add disk.");
            Disks[index] = d;
        }
        public bool CheckDisk(string device)
        {
            foreach (var disk in Disks)
            {
                if (disk.GetName() == device)
                    return true;
            }
            return false;
        }
        public void InsertReject(string device, bool b)
        {
            foreach (Disk disk in Disks)
            {
                if (disk != null && disk.GetName() == device)
                {
                    if (!(disk is IRemoveableDisk))
                        throw new Exception(disk.GetName() + " not removable disk.");

                    if (b)
                        (disk as IRemoveableDisk).Insert();
                    else
                        (disk as IRemoveableDisk).Reject();

                    return;
                }
            }
            throw new Exception("Disk not found.");

        }
        public bool PrintInfo(string text, string ShowDevice)
        {
            foreach (IPrintInformation dev in PrintDevice)
            {
                if (dev != null && dev.GetName() == ShowDevice)
                {
                    dev.Print(text);
                    return true;
                }
            }
            return false;
        }
        public string ReadInfo(string device)
        {
            foreach (Disk disk in Disks)
            {
                if (disk != null && disk.GetName() == device)
                {
                    return disk.Read();
                }
            }
            throw new Exception("Disk not found.");
        }
        public void ShowDisk()
        {
            foreach (Disk disk in Disks)
            {
                if (disk != null)
                {
                    Console.WriteLine(disk);
                }
            }

        }
        public void ShowPrintDevice()
        {
            foreach (IPrintInformation dev in PrintDevice)
            {
                if (dev != null)
                    Console.WriteLine(dev);
            }
        }
       public bool WriteInfo(string text, string device)
        {
            foreach (Disk disk in Disks)
            {
                if (disk != null && disk.GetName() == device)
                {
                    disk.Write(text);
                    return true;
                }
            }
            return false;

        }
    }
}
