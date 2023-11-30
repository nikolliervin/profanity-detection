using System;
using profanity_detector;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var detect = new profanity_detector.ProfanityDetection();
            Console.WriteLine(detect.Detect("Fuck you!"));
            Console.ReadLine();
        }
    }
}
