using AdventOfCode2020.Days;
using System;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Advent of Code 2020 ---");

            IDay day = new Day1();
            day.Run();

            Console.WriteLine("Goodbye!");
        }
    }
}
