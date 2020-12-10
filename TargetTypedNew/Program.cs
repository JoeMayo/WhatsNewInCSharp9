using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TargetTypedNew
{
    class Program
    {
        // field
        Dictionary<string, List<int>> scores = new();

        // property
        public Version URL { get; set; } = new();

        static void Main(string[] args)
        {
            // reference type
            Stopwatch timer = new();

            // value type - constructor params
            TimeSpan duration = new(0, 1, 30);

            Console.WriteLine("Hello World!");
        }
    }
}
