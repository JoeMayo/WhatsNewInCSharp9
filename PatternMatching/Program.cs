using System;
using System.Collections.Generic;

namespace PatternMatching
{
    interface ICustomer
    {
        int ID { get; init; }
        string Name { get; init; }
    }

    record GoldCustomer(int ID, string Name) : ICustomer;
    record SilverCustomer(int ID, string Name) : ICustomer;
    record BronzeCustomer(int ID, string Name) : ICustomer;

    class Program
    {
        static void Main(string[] args)
        {
            RangeDemo();
            TypeDemo();
        }

        static void TypeDemo()
        {
            List<ICustomer> customers = new()
            {
                new GoldCustomer(1, "Mary"),
                new SilverCustomer(2, "Joe"),
                new BronzeCustomer(3, "Chris")
            };

            foreach (var cust in customers)
            {
                decimal discount = cust switch
                {
                    GoldCustomer => .10m,
                    SilverCustomer => .05m,
                    BronzeCustomer => .01m,
                    _ => 0
                };

                Console.WriteLine($"{cust.GetType()} Discount: {discount:p0}");
            }
        }

        static void RangeDemo()
        {
            int score = 92;

            string grade = score switch
            {
                > 60 and < 70 => "D",
                >= 70 and < 80 => "C",
                >= 80 and < 90 => "B",
                >= 90 => "A",
                _ => "F"
            };

            if (grade is not "F")
                Console.WriteLine("You passed");

            if (grade is "A" or "B")
                Console.WriteLine(" ... and you did very well!");
        }
    }
}
