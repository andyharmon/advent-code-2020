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
                var locationStrings = policy[0].Split('-');
                int location1 = int.Parse(locationStrings[0]) - 1;
                int location2 = int.Parse(locationStrings[1]) - 1;

                // get character to search
                char letterToSearch = char.Parse(policy[1]);

                // do search
                if (PasswordElements[1][location1] == letterToSearch
                    && PasswordElements[1][location2] == letterToSearch)
                {
                    runningTotal++;
                }
            }

            Console.WriteLine($"The answer is {runningTotal}");
        }
    }
}
