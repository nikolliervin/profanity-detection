using System;
using profanity_detector;
using Profanity_detector;


namespace ModelTest
{
    internal class Program
    {
        static void Main(string[] args)
        {   
          
            var detect = new ProfanityDetection();
            Console.WriteLine(detect.Detect("Fuck!"));
            Console.ReadKey();
        }
    }
}
