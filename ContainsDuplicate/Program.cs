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
            for (var i = 0; i < nums.Length; i++) {
                if (set.Contains(nums[i])) {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;
        }
    }
    
}