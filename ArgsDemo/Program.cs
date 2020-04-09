using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace ArgsDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"foreach args ({args.Length})");
            foreach (var arg in args)
            {
                Console.WriteLine($"  {arg}");
            }
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();
            var keyValues = config.AsEnumerable().ToList();
            Console.WriteLine($"Parsed args ({keyValues.Count})");
            foreach (var (key, value) in keyValues)
            {
                Console.WriteLine($"  {key} : {value}");
            }
        }
    }
}
