using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.Assignments
{
    public class DecemberSecond : IDecemberSecond
    {
        public int Calculate(string input)
        {
            var inputAsArray = input.ToArray();

            var resultSecondWay = CalculateShit(input);

            return resultSecondWay;
        }

        private int CalculateShit(string input)
        {
            var splittedByRow = input.Split('\n');

            int CheckSumValue = 0;
            foreach(var row in splittedByRow)
            {
                CheckSumValue += CalculateHighestDiffInRow(row);   
            }

            return CheckSumValue;
        }

        private int CalculateHighestDiffInRow(string row)
        {
            var rowAsChars = row.ToArray();

            var digitMarked = FindDigitItemsFromInput(rowAsChars);

            var replaced = ReplaceNonDigitItems(digitMarked);

            var fullstring = JoinListOfItemsToFullString(replaced);

            var splitted = SplitToSmallerItems(fullstring);

            var result = CalculateSumOfBiggestDiffsInAllItems(splitted);

            return result.Sum();   
        }        

        private static List<int> CalculateSumOfBiggestDiffsInAllItems(List<string> items)
        {
            var allValuesToSum = new List<int>();
            
            var myInts = Array.ConvertAll(items.ToArray(), s => int.Parse(s.ToString())).ToList();

            var max = myInts.Max();
            var min = myInts.Min();

            allValuesToSum.Add(max - min);         

            return allValuesToSum;
        }

        private static List<string> SplitToSmallerItems(string fullstring)
        {
            var items = fullstring.Split(';').ToList();

            items.RemoveAll(p => p.Length == 0);
            return items;
        }

        private static string JoinListOfItemsToFullString(List<string> allItemsWithDigitReplaced)
        {
            return string.Join("", allItemsWithDigitReplaced);
        }

        private static List<string> ReplaceNonDigitItems(List<IsDigitItem> isDigitItems)
        {
            var isDigitItemsReplacedWithChar = new List<string>();

            foreach (var item1 in isDigitItems)
            {
                if (item1.IsDigit)
                {
                    isDigitItemsReplacedWithChar.Add(item1.Character.ToString());
                }
                else
                {
                    isDigitItemsReplacedWithChar.Add(";");
                }
            }

            return isDigitItemsReplacedWithChar;
        }

        private static List<IsDigitItem> FindDigitItemsFromInput(char[] inputAsArray)
        {
            var isDigitItems = new List<IsDigitItem>();

            foreach (var item in inputAsArray)
            {
                isDigitItems.Add(new IsDigitItem
                {
                    Character = item,
                    IsDigit = char.IsDigit(item)
                });
            }

            return isDigitItems;
        }
    }


    
}
