using System;

namespace AdditionalFeatures
{
    class Program
    {
        static Action hello = () => Console.WriteLine("Hello World!");

        static void Main(string[] args)
        {
            hello();
        }
    }
}
