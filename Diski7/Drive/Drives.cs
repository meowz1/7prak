using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Drives
    {
        public static List<System.IO.DriveInfo> disks = new List<System.IO.DriveInfo>();
        public static List<string> paths = new List<string>();
        public static List<string> lastPathAt = new List<string>();
        public static int Drivers()
        {
            int ct = 0;
            lastPathAt.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                if (d.IsReady == true)
                {
                    Console.WriteLine($"    {d.Name}      {d.DriveType} type");
                }
                else
                {
                    Console.WriteLine($"    {d.Name}");
                }
                ct++;
                disks.Add(d);
            }
            return ct;
        }

        public static void getDrivers(string path)
        {
            try{
                lastPathAt.Add(path);
                paths.Clear();
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);


                foreach (string s in dirs)
                {
                    Console.WriteLine($"    {s}");
                    paths.Add(s);
                }


                if (files.Length != 0)
                {
                    foreach (string s in files)
                    {
                        Console.WriteLine($"    {s}");
                        paths.Add(s);
                    }
                }
                

            }
            catch (IOException)
            {
                Console.WriteLine(Exception.ReferenceEquals);
            }
            
        }


    }
}
