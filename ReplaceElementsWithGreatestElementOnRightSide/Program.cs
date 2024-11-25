public class Program
{
    public static void Main()
    { 
        Console.WriteLine(string.Join(",", ReplaceElements(new int[] {17, 18, 5, 4, 6, 1})));
        Console.WriteLine(string.Join(",", ReplaceElements(new int[] {400})));
    }
    
    private static int[] ReplaceElements(int[] arr)
    {
        var max = -1;
        for (var i = arr.Length - 1; i >= 0; i--)
        {
            var temp = arr[i];
            arr[i] = max;
            max = Math.Max(max, temp);
        }
        return arr;
    }
}