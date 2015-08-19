using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        var newList = list.ToArray();
        var pairs = (from number in list where newList.Contains(sum - number) select Tuple.Create(Array.IndexOf(newList, number), Array.LastIndexOf(newList, sum - number))).ToList();
        
        return pairs.Count > 0 ? pairs[0] : null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 6, 1, 3, 5, 6, 7, 9 }, 12);
        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    }
}