public class Program
{
    public static void Main()
    { 
        Console.WriteLine(string.Join(",",ConcatenationOfArray([1, 2, 1])));
        Console.WriteLine(string.Join(",", ConcatenationOfArray([1, 3, 2, 1])));
    }
    
    private static int[] ConcatenationOfArray(int[] nums)
    {
        var result = new int[nums.Length * 2];
        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }
        return result;
    }
}