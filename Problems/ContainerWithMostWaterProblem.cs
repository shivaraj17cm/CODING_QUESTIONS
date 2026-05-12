namespace CODING_QUESTIONS.Problems
{
    public class ContainerWithMostWaterProblem : IProblem
    {
        public int Id => 17;
        public string Name => "Container With Most Water (Two Pointer)";

        public void Run()
        {
            Test(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Test(new int[] { 1, 1 });
            Test(new int[] { 4, 3, 2, 1, 4 });
            Test(new int[] { 1, 2, 1 });
        }

        private void Test(int[] height)
        {
            int result = MaxArea(height);
            Console.WriteLine($"Height: [{string.Join(", ", height)}] -> Max Water: {result}");
        }

        private int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int maxWater = 0;

            while (left < right)
            {
                // Height is limited by the shorter wall
                int minHeight = Math.Min(height[left], height[right]);

                // Distance between the walls
                int width = right - left;

                // Water stored
                int area = minHeight * width;

                // Update maximum
                maxWater = Math.Max(maxWater, area);

                // Move the shorter wall inward
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxWater;
        }
    }
}
