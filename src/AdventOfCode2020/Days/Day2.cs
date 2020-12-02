using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Days
{
    public class Day2 : IDay
    {
        public void Run()
        {
            int runningTotal = 0;
            var file = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Inputs/day2.txt"));
            List<string> passwords = new List<string>(file);

            foreach (var password in passwords)
            {
                string[] PasswordElements = password.Split(':');
                string[] policy = PasswordElements[0].Split(' ');

                // get bounds
                var boundStrings = policy[0].Split('-');
                int lowerBound = int.Parse(boundStrings[0]);
                int upperBound = int.Parse(boundStrings[1]);

                // get character to search
                char letterToSearch = char.Parse(policy[1]);

                // do search
                int passwordLetterCount = PasswordElements[1].Count(l => l == letterToSearch);
                if (passwordLetterCount >= lowerBound && passwordLetterCount <= upperBound)
                {
                    runningTotal++;
                }
            }

            Console.WriteLine($"The answer is {runningTotal}");
        }
    }
}
