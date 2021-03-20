using System;

namespace LargeRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            long bigNext = LongRandom.NextLong(random);
            long bigNextMax = LongRandom.NextLong(random, 6000000000);
            long bigNextRange = LongRandom.NextLong(random, 5000000000, 7000000000);
            Console.WriteLine($"Random 64-bit integer: {bigNext}{Environment.NewLine}Random 64-bit integer up to 6 billion: {bigNextMax}{Environment.NewLine}Random 64-bit integer between 5 and 7 billion: {bigNextRange}.");
        }
    }
}
