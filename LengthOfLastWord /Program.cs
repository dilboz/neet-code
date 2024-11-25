public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLastWord("Hello World"));
        Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
        Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    }
    
    private static int LengthOfLastWord(string s)
    {
        var length = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ' && length > 0)
            {
                return length;
            }
            if (s[i] != ' ')
            {
                length++;
            }
        }
        return length;
        
        //two variants
        //return s.Trim().Split(' ').Last().Length;
    }
}