using System;

namespace Records
{
    record Tweet(string Text, DateTime Date);

    class User
    {
        public int ID { get; init; }

        public string Name { get; init; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BasicRecordDemo();

            ImmutableClassDemo();
        }

        static void BasicRecordDemo()
        {
            Tweet tweet = new("Hello C# 9", DateTime.Now);


            (string Text, DateTime Date) = tweet;

            Console.WriteLine($"Text: {Text}, Date: {Date}");

            // not allowed
            //tweet.Text = "Goodbye C# 8";

            Tweet goodbyeTweet = tweet with { Text = "Goodbye C# 9" };

            Console.WriteLine(goodbyeTweet);

            Tweet helloTweet = goodbyeTweet with { Text = "Hello C# 9" };

            Console.WriteLine(
                $"Does tweet equal helloTweet: {tweet == helloTweet}");
            Console.WriteLine(
                $"Does tweet reference equal helloTweet: {object.ReferenceEquals(tweet, helloTweet)}");
        }

        static void ImmutableClassDemo()
        {
            User user = new() { ID = 1, Name = "Joe" };

            // not allowed
            //user.Name = "John";
        }
    }
}
