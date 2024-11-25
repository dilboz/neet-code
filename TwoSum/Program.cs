public class Program
{
    public static void Main()
    {
        Console.WriteLine(string.Join(",", TwoSum(new int[] {2, 7, 11, 15}, 9)));
        Console.WriteLine(string.Join(",", TwoSum(new int[] {3, 2, 4}, 6)));
        Console.WriteLine(string.Join(",", TwoSum(new int[] {3, 3}, 6)));
    }

    private static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dict.TryGetValue(complement, value: out var value))
            {
                return [value, i];
            }

            dict[nums[i]] = i;
        }

        return [0, 0];
    }
}