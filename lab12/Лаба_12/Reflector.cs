using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Лаба_12
{
    static class Reflector
    {
        static string filePath = "D:\\3 сем\\ООП\\лабы\\Лаба_12\\file.txt";
        static string filePathR = "D:\\3 сем\\ООП\\лабы\\Лаба_12\\fileR.txt";
        public static StreamWriter file = new StreamWriter(filePath, false);
        static StreamReader fileR = new StreamReader(filePathR);

        static public void OutAssemblyName(string name)
        {
            file.WriteLine("======================================================1");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);
            file.WriteLine($"{TypeName}.Assembly = {myType.Assembly}");
            file.WriteLine("======================================================1\n");
        }

        static public void OutPublicConstructors(string name)
        {
            file.WriteLine("======================================================2");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);

            foreach (ConstructorInfo constr in myType.GetConstructors())
            {
                if (constr.IsPublic)
                {
                    file.Write(constr.Name + '(');
                    ParameterInfo[] parameters = constr.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
            file.WriteLine("======================================================2\n");
        }

        static public void OutPublicMethods(string name)
        {
            file.WriteLine("======================================================3");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);

            foreach (MethodInfo mi in myType.GetMethods())
            {
                if (mi.IsPublic)
                {
                    file.Write(mi.Name + '(');
                    ParameterInfo[] parameters = mi.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length) file.Write(", ");
                    }
                    file.WriteLine(");");
                }
            }
            file.WriteLine("======================================================3\n");
        }

        static public void MethodForType(string name)
        {
            file.WriteLine("======================================================4");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);

            foreach (FieldInfo fi in myType.GetFields())
            {
                file.WriteLine(fi.DeclaringType + " " + fi.FieldType + " " + fi.Name);
            }

            foreach (PropertyInfo pi in myType.GetProperties())
            {
                file.WriteLine(pi.DeclaringType + " " + pi.PropertyType + " " + pi.Name);
            }
            file.WriteLine("======================================================4\n");

        }
        static public void OutInterfaces(string name)
        {
            file.WriteLine("======================================================5");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);

            foreach (Type i in myType.GetInterfaces())
            {
                file.WriteLine("interface " + i.Name);
            }
            file.WriteLine("======================================================5\n");
        }
        static public void OutMethodsWithParm(string name, string parm)
        {
            file.WriteLine("======================================================6");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);

            foreach (MethodInfo mi in myType.GetMethods())
            {
                ParameterInfo[] param = mi.GetParameters();
                for (int j = 0; j < param.Length; j++)
                {
                    if (parm == param[j].ParameterType.Name)
                    {
                        file.Write(mi.Name + '(');
                        ParameterInfo[] parameters = mi.GetParameters();
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            file.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                            if (i + 1 < parameters.Length) file.Write(", ");
                        }
                        file.WriteLine(");");
                        break;
                    }
                }
            }
            file.WriteLine("======================================================6\n");
        }
        static public void Voke(string name, string method)
        {
            Console.WriteLine("======================================================7");
            List<string> ls = new List<string>();
            ls.Add(fileR.ReadLine());
            ls.Add(fileR.ReadLine());
            ls.Add(fileR.ReadLine());
            object[] parms = new object[] { ls };
            Type type = Type.GetType(name);
            object obj = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod(method);
            object result = methodInfo.Invoke(obj, parms);
            Console.WriteLine(result);
            Console.WriteLine("======================================================7\n");
        }

        public static object Create(string name, object[] parm)
        {
            Console.WriteLine("======================================================8");
            string TypeName = "Лаба_12." + name;
            Type myType = Type.GetType(TypeName, false, true);
            object obj = Activator.CreateInstance(myType, parm);
            Console.WriteLine(obj.ToString());
            Console.WriteLine("======================================================8\n");
            return obj;
        }
    }
}
