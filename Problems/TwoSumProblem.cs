namespace CODING_QUESTIONS.Problems
{
    public class TwoSumProblem : IProblem
    {
        public int Id => 1;
        public string Name => "Find two numbers that add up to a target";

        public void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            var result = TwoSum(nums, target);

            Console.WriteLine($"Indexes: {result[0]}, {result[1]}");
        }

        private int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
