using DokanNet;
using System;

namespace FlexStorage
{
    internal static class Program
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
//                if (driveLetter == null || driveLetter.Length != 1)
//                {
//                    System.Console.WriteLine("Please check your input.");
//                    System.Console.ReadKey();
//                    return;
//                }
//                driveLetter = driveLetter.ToUpper();
//
//                System.Console.WriteLine("Mount To : Volume Label : (eg: John's Disk)");
//                String volumeLabel = System.Console.ReadLine();
//                if (volumeLabel == null)
//                {
//                    System.Console.WriteLine("Please check your input.");
//                    System.Console.ReadKey();
//                    return;
//                }

//                String mountDir = "C:\\LSR", driveLetter = "N", volumeLabel = "Nyx's Disk";
                String mountDir = "C:\\", driveLetter = "N", volumeLabel = "Nyx's Disk";
                Mirror mirror = new Mirror(mountDir, driveLetter, volumeLabel);

                mirror.Mount(driveLetter + ":\\", DokanOptions.DebugMode | DokanOptions.KeepAlive, 5);

                Console.WriteLine("Success");
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Please check your input.");
                System.Console.ReadKey();
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