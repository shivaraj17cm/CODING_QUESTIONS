namespace CODING_QUESTIONS.Problems
{
    public class MaxSumSubarrayOfSizeKProblem : IProblem
    {
        public int Id => 17;
        public string Name => "Maximum sum of a contiguous subarray of size K (Fixed Window Sliding)";

        public void Run()
        {
            Test(new int[] { 2, 1, 5, 1, 3, 2 }, 3);
            Test(new int[] { 2, 3, 4, 1, 5 }, 2);
            Test(new int[] { 1, 1, 1, 1, 1 }, 3);
            Test(new int[] { 4, -1, 2, 1, 6, -5, 3 }, 4);
        }

        private void Test(int[] nums, int k)
        {
            int result = MaxSumSubarray(nums, k);
            Console.WriteLine($"Array: [{string.Join(", ", nums)}], K: {k} -> Max Sum: {result}");
        }

        private int MaxSumSubarray(int[] nums, int k)
        {
            // 1. Compute sum of the first window
            int windowSum = 0;
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }

            int maxSum = windowSum;

            // 2. Slide the window: add the next element, remove the first element of previous window
            for (int i = k; i < nums.Length; i++)
            {
                windowSum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }
    }
}
