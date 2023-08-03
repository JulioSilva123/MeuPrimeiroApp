// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");
Console.WriteLine("");
Console.WriteLine("C# - .Net Framework 4.8");
Console.WriteLine(Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company);
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();