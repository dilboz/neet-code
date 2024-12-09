public class Program
{
    public static void Main()
    {
        var result = GroupAnagrams(new[] {"eat", "tea", "tan", "ate", "nat", "bat"});
        foreach (var list in result)
            Console.WriteLine(string.Join(",", list));
    }

    private static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var key = new string(str.OrderBy(c => c).ToArray());
            if (!map.TryGetValue(key, out var value))
            {
                value = [];
                map[key] = value; 
            }

            value.Add(str);
        }

        return map.Values.Select(IList<string> (list) => list).ToList();
    }
}