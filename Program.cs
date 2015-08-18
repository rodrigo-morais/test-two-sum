using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        Tuple<int, int> sums = null;
        var find = false;
        var count = 0;
        var middle = list.Count > 0 ? ((list.Count / 2) + 1) : 0;

        while (count < middle && !find)
        {
            var second = sum - list[count];
            var previous = sum - list[list.Count - count - 1];

            second = list.IndexOf(second);
            previous = list.IndexOf(previous);

            if (second > -1)
            {
                find = true;
                sums = Tuple.Create(count, second);
            }
            else if (previous > -1)
            {
                find = true;
                sums = Tuple.Create(list.Count - count - 1, previous);
            }

            count++;
        }

        return sums;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    }
}