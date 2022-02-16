using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Collections;

namespace Лаба_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector.OutAssemblyName("Test");
            Reflector.OutPublicConstructors("Test");
            Reflector.OutPublicMethods("Test");
            Reflector.MethodForType("Test");
            Reflector.OutInterfaces("Test");
            Reflector.OutMethodsWithParm("Test", "String");
            Reflector.Voke("Лаба_12.Test", "Toconsole");

            object[] ls = new object[] { "50cent" };
            object ts1 = Reflector.Create("Test", ls);

            Reflector.file.Close();
        }
    }
}
