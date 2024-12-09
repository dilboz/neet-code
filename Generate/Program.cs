public class Program
{
    public static void Main(string[] args)
    {
        var result = Generate(5);
        foreach (var list in result)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }

    private static IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();
        if (numRows == 0)
        {
            return result;
        }

        result.Add(new List<int> {1});
        for (var i = 1; i < numRows; i++)
        {
            var prev = result[i - 1];
            var current = new List<int> {1};
            for (var j = 1; j < prev.Count; j++)
            {
                current.Add(prev[j - 1] + prev[j]);
            }
            current.Add(1);
            result.Add(current);
        }

        return result;
    }
}