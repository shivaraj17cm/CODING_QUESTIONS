namespace CODING_QUESTIONS.Problems
{
    public class SearchInsertPositionProblem : IProblem
    {
        public int Id => 15;
        public string Name => "Find index or insert position of a target in a sorted array";

        public void Run()
        {
            int[] nums = { 1, 3, 5, 6 };

            Console.WriteLine("Array  : " + string.Join(", ", nums));

            Test(nums, 5);
            Test(nums, 2);
            Test(nums, 7);
            Test(nums, 0);
        }

        private void Test(int[] nums, int target)
        {
            int position = SearchInsert(nums, target);
            Console.WriteLine($"Target {target} -> Position {position}");
        }

        private int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;

                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            // left is the correct insertion index
            return left;
        }
    }
}