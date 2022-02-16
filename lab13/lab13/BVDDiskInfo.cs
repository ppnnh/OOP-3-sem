
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public static class BVDDiskInfo
    {
        private static DriveInfo[] di;

        static BVDDiskInfo() => di = DriveInfo.GetDrives();

        //2a
        public static string GetFreeSpace()
        {
            long space = 0;
            foreach (var d in di)
                space += d.AvailableFreeSpace;

            return "Free space\t" + space.ToString();
        }
        //2b
        public static string GetFileSystem() => di[0].DriveFormat;
        //2c
        public static string GetDiskInfo()
        {
            string res = "";
            foreach (var d in di)
            {
                res += "Disk Name " + d.Name + '\n';
                res += "Disk space " + d.TotalSize.ToString() + '\n';
                res += "Disk free space " + d.TotalFreeSpace.ToString() + '\n';
                res += "Volume label " + d.RootDirectory.ToString() + "\n\n";
            }
            return res;
        }
    }
}