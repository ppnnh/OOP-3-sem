
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public static class BVDFileInfo
    {
        private const string path = @"D:\3 сем\ООП\лабы\lab13\bvdlog.txt";
        private static FileInfo fi;

        static BVDFileInfo() => fi = new FileInfo(path);

        public static string GetPath() => "Dir name " + fi.DirectoryName + '\n';
        //2b
        public static string GetFileInfo()
        {
            string res = "";
            res += "Space " + fi.Length + '\n';
            res += "Extension " + fi.Extension + '\n';
            res += "Name " + fi.Name + "\n\n";
            return res;
        }
        //3c
        public static string GetTimeCreation() => "Time creation " + fi.CreationTime.ToString() + "\n\n";
    }
}