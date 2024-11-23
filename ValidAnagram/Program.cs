public class Program
{
    public static void Main()
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("rat", "car"));
    }

    private static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach (var c in t)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]--;
            }
            else
            {
                return false;
            }
        }

        return dict.Values.All(v => v == 0);
    }
}