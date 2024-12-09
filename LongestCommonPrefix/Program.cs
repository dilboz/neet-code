public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
        Console.WriteLine(LongestCommonPrefix(["dog", "racecar", "car"]));
    }

    private static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        
        var prefix = strs[0];
        for (var i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                {
                    return "";
                }
            }
        }
        
        return prefix;
    }
}