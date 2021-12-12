using System;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine().Trim();
            Console.WriteLine("What is your favourite mode of transport?");
            var transport = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Pick an out of the way travel destination");
            var destination = Console.ReadLine().Trim();
            Console.WriteLine("Pick an adverb e.g. playfully, sadly");
            var adverb = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Pick a plural noun");
            var noun = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("What's your favourite mythical creature?");
            var mythicalCreature = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Pick a superpower");
            var superpower = Console.ReadLine().Trim().ToLower();

            Console.WriteLine($"{(char.ToUpper(name[0]) + name.Substring(1))} went on a quest to find the last {mythicalCreature} of {(char.ToUpper(destination[0]) + destination.Substring(1))}.");
            Console.WriteLine($"{(char.ToUpper(name[0]) + name.Substring(1))} took the {transport} to {(char.ToUpper(destination[0]) + destination.Substring(1))} and was sitting {adverb}");
            Console.WriteLine($"by themself, when suddenly hundreds of {noun} appeared");
            Console.WriteLine($"and used their secret power of {superpower}. {(char.ToUpper(name[0]) + name.Substring(1))} was so surprised");
            Console.WriteLine($"that they forgot all about their quest, got the next {transport} home");
            Console.WriteLine($"and lived happily ever after.");
        }
    }
}
