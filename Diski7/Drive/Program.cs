using System;

namespace Drive
{
    public class Program
    {

        static void Main(string[] argrs)
        {

            int a = Drives.Drivers();
            while (true)
            {
                int disk = Arrow.Move(a);

                if (Drives.paths.Count() == 0)
                {
                    Console.Clear();
                    Drives.getDrivers(Drives.disks[0].Name);
                    a = Drives.paths.Count();
                }

                else if (disk == -1)
                {
                    Console.Clear();

                    if (Drives.lastPathAt.Count() > 1)
                    {
                        int len = Drives.lastPathAt.Count() - 1;

                        string last = Drives.lastPathAt[len - 1];

                        Drives.lastPathAt.RemoveAt(len);
                        Drives.lastPathAt.RemoveAt(len - 1);
                        Drives.getDrivers(last);

                        a = Drives.paths.Count();

                        Arrow.pose = 0;
                    }

                    else if (Drives.lastPathAt.Count() == 1)
                    {
                        a = Drives.Drivers();
                        Drives.paths.Clear();

                        Arrow.pose = 0;
                    }
                }

                else
                {
                    Console.Clear();
                    Drives.getDrivers(Drives.paths[disk]);
                    a = Drives.paths.Count();
                    Arrow.pose = 0;

                }
                
                



            }
        }
    }
}