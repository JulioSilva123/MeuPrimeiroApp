using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("");
            Console.WriteLine("C# - .Net Framework 4.8");
            Console.WriteLine(Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();


            //Console.WriteLine(Assembly.GetEntryAssembly().FullName);            

        }
    }
}
