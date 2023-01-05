// See https://aka.ms/new-console-template for more information
var points = new int[2][] { new int[] { -2147483646, -2147483645 }, new int[] { 2147483646, 2147483647 } };
Solution s = new Solution();
var asnwer = s.FindMinArrowShots(points); 
Console.WriteLine(asnwer);


public class Solution
{
  public int FindMinArrowShots(int[][] points)
  {
    // O(nlogn)
    Array.Sort(points, new Comparer());
    int count = 1;
    var previous = points[0];
    for (int i = 1; i < points.Length; i++)
    {
      var current = points[i];
      var cStart = current[0];
      var cEnd = current[1];
      var prevStart = previous[0];
      var prevEnd = previous[1];
      if (cStart <= prevEnd)
      {
        //previous[0] = Math.Min(cStart, prevStart);
        //previous[1] = Math.Min(cEnd, prevEnd);
      }
      else
      {
        count++;
        previous = current;
      }
    }

    return count;
  }
  public class Comparer : IComparer<int[]>
  {
    public int Compare(int[] x, int[] y)
    {
      return x[0].CompareTo(y[0]);
    }
  }
}