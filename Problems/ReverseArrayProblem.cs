namespace CODING_QUESTIONS.Problems
{
    public class ReverseArrayProblem : IProblem
    {
        public int Id => 3;
        public string Name => "Reverse an array";

        public void Run()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Input : " + string.Join(", ", array));

            ReverseArray(array);

            Console.WriteLine("Output: " + string.Join(", ", array));
        }

        private void ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                // swap
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }
    }
}
