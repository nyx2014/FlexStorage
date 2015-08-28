using DokanNet;
using System;

namespace DokanNetMirror
{
    internal class Programm
    {
        private static void Main(string[] args)
        {
            try
            {
//                System.Console.WriteLine("Mount From : (eg: C:\\foo\\bar)");
//                String mountDir = System.Console.ReadLine();
//
//                System.Console.WriteLine("Mount To : Drive Letter : (eg: N)");
//                String driveLetter = System.Console.ReadLine();

//                System.Console.WriteLine("Mount To : Volume Label : (eg: John's Disk)");
//                String volumeLabel = System.Console.ReadLine();

                String mountDir = "C:\\LSR", driveLetter = "N", volumeLabel = "Nyx's Disk";
                Mirror mirror = new Mirror(mountDir, driveLetter, volumeLabel);

                mirror.Mount(driveLetter + ":\\", DokanOptions.DebugMode | DokanOptions.KeepAlive, 5);

                Console.WriteLine("Success");
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Please check your input.");
                System.Console.ReadKey();
            }
            catch (DokanException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Maybe drive letter already used ?");
                System.Console.ReadKey();
            }
        }
    }
}