namespace CODING_QUESTIONS.Problems
{
    public class MoveZerosProblem : IProblem
    {
        public int Id => 5;
        public string Name => "Move all 0's to the end of the array";

        public void Run()
        {
            int[] array = { 0, 1, 0, 3, 12 };

            Console.WriteLine("Input : " + string.Join(", ", array));

            MoveZerosToEnd(array);

            Console.WriteLine("Output: " + string.Join(", ", array));
        }

        private void MoveZerosToEnd(int[] nums)
        {
            int index = 0;

            // Move all non-zero elements to the front
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index++] = nums[i];
                }
            }

            // Fill remaining positions with 0
            while (index < nums.Length)
            {
                nums[index++] = 0;
            }
        }
    }
}
