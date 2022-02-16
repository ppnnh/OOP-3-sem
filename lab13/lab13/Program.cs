
using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\3 сем\ООП\лабы\lab13";
            Console.WriteLine(BVDDiskInfo.GetDiskInfo());
            BVDLog.Write(BVDDiskInfo.GetDiskInfo());

            Console.WriteLine(BVDFileInfo.GetFileInfo());
            BVDLog.Write(BVDFileInfo.GetFileInfo());
            BVDLog.Write("$Session - " + DateTime.Now.Date.ToString() + "$");

            BVDFileManager.MoveFiles(path);
            BVDFileManager.MoveDirectoriesByExtension(path, ".js");
            BVDFileManager.ToZip(path);

            Console.WriteLine("======================================");
            Console.WriteLine("============= FROM FILE ==============");
            Console.WriteLine($"============= COUNT: {BVDLog.GetRecordCount()}================");
            Console.WriteLine("======================================\n");
            Console.WriteLine(BVDLog.GetInfoByDay(DateTime.Now.Date));

            BVDFileManager.FromZip();

            BVDLog.Close();
        }
    }
}