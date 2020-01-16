using System;
using System.Linq;

namespace BiggestNumber_Sum
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] input = { 1, 1, 5, 5, 3, 3, 3 };

            Console.WriteLine(Challenge(input));
            Console.ReadLine();
        }

        public static int Challenge(int[] input)
        {
            int minOccurance = 1;
            foreach (var i in input.Distinct())
            {
                var occuranceCount = input.Count(x => x == i);
                minOccurance = minOccurance > occuranceCount ? minOccurance : occuranceCount;
            }

            var filteredArray = input.Where(x => input.Count(y => y == x) >= minOccurance - 1).ToArray();
            var adjacentSum = filteredArray.Skip(1).Zip(filteredArray, (second, first) => first + second).ToArray();

            return adjacentSum.Max();
        }
    }
}   
