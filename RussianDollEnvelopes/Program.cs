/*
354. Russian Doll Envelopes
Solved
Hard
Topics
Companies
You are given a 2D array of integers envelopes where envelopes[i] = [wi, hi] represents the width and the height of an envelope.

One envelope can fit into another if and only if both the width and height of one envelope are greater than the other envelope's width and height.

Return the maximum number of envelopes you can Russian doll (i.e., put one inside the other).

Note: You cannot rotate an envelope.
 

Example 1:

Input: envelopes = [[5,4],[6,4],[6,7],[2,3]]
Output: 3
Explanation: The maximum number of envelopes you can Russian doll is 3 ([2,3] => [5,4] => [6,7]).
Example 2:

Input: envelopes = [[1,1],[1,1],[1,1]]
Output: 1

Constraints:

1 <= envelopes.length <= 105
envelopes[i].length == 2
1 <= wi, hi <= 105

*/
var result = MaxEnvelopes([[2, 100], [3, 200], [2, 300], [5, 500], [5, 400], [5, 250], [6, 370], [6, 360], [7, 380]]);

Console.WriteLine(result);
Console.ReadLine();

static int MaxEnvelopes(int[][] envelopes)
{
    Array.Sort(envelopes, (a, b) =>
    {
        if (a[0] == b[0])
        {
            return b[1] - a[1];
        }
        else
        {
            return a[0] - b[0];
        }
    });

    foreach (var item in envelopes)
    {
        Console.Write($"[{item[0]},{item[1]}] ");
    }

    var result = LengthOfLIS(envelopes);

    return result;
}

static int LengthOfLIS(int[][] envelopes)
{
    int n = envelopes.Length;
    int[] tails = new int[n];

    tails[0] = envelopes[0][1];
    int count = 0;

    for (int i = 1; i < n; i++)
    {
        int value = envelopes[i][1];
        if (value > tails[count])
        {
            count++;
            tails[count] = value;
        }
        else
        {
            int low = BinarySearch(tails, 0, count, value);

            tails[low] = value;
        }
    }

    return count + 1;
}

static int BinarySearch(int[] array, int low, int high, int value)
{
    while (low < high)
    {
        int mid = low + (high - low) / 2;
        if (value > array[mid])
        {
            low = mid + 1;
        }
        else
        {
            high = mid;
        }
    }

    return low;
}

