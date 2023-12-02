using profanity_detector;
using System;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var detector = new ProfanityDetection();

            Console.WriteLine(detector.isToxic("you are such a bitch!"));

        }
    }
}
