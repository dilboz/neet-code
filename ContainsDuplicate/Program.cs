namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(ContainsDuplicate(nums));
        }

        private static bool ContainsDuplicate(int[] nums) {
            var set = new HashSet<int>();
            foreach (var t in nums)
            {
                if (set.Contains(t)) {
                    return true;
                }
                set.Add(t);
            }
            return false;
        }
    }
    
}