using System;
using System.Reflection;

namespace ReflectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Type.GetType("PluginReader.PersonInfo, PluginReader", false, true);
            Console.WriteLine(type.FullName);

            foreach (var mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.Name}");
            }

            Console.WriteLine("--------------------------------");

            foreach (var met in type.GetMethods(BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"{met.Name}");
            }

            Console.WriteLine("--------------------------------");

            foreach (var inter in type.GetInterfaces())
            {
                Console.WriteLine($"{inter.Name}");
            }
        }        
    }
}
