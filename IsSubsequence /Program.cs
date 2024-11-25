public class Program
{
    public static void Main()
    {
        Console.WriteLine(IsSubsequence("abc", "ahbgdc"));
        Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
    }

    private static bool IsSubsequence(string s, string t)
    {
        var i = 0;
        var j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                i++;
            }

            j++;
        }

        return i == s.Length;
    }
}