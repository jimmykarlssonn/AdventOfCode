using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017
{
    public class DecemberFirst : IDecemberFirst
    {
        public int Calculate(string numbers)
        {
            var numbersAssArray = numbers.ToArray();

            int[] allInts = Array.ConvertAll(numbersAssArray, s => int.Parse(s.ToString()));

            var numbersToCalculateWith = new List<int>();

            var currentPosition = 0;

            foreach (var number in allInts)
            {          
                if (currentPosition == allInts.Count() - 1)
                {
                    if (allInts.Last() == allInts.First())
                    {
                        numbersToCalculateWith.Add(allInts.First());
                        {
                            currentPosition++;
                            continue;
                        }                        
                    }
                }

                if (number == allInts[currentPosition + 1])
                {
                    numbersToCalculateWith.Add(number);
                    currentPosition++;
                    continue;
                }

                currentPosition++;
            }

            var result = numbersToCalculateWith.Sum();

            Console.WriteLine(result.ToString());

            return numbersToCalculateWith.Sum();

        }
    }
}
