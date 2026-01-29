namespace CODING_QUESTIONS.Problems
{
    public class ArrayRotationProblem : IProblem
    {
        public int Id => 13;
        public string Name => "Left / Right rotate an array by K places";

        public void Run()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int k = 2;

            Console.WriteLine("Original Array: " + string.Join(", ", array));

            LeftRotate(array, k);
            Console.WriteLine($"Left Rotated by {k}: " + string.Join(", ", array));

            // Reset array
            array = new int[] { 1, 2, 3, 4, 5 };

            RightRotate(array, k);
            Console.WriteLine($"Right Rotated by {k}: " + string.Join(", ", array));
        }

        private void LeftRotate(int[] arr, int k)
        {
            int n = arr.Length;
            k %= n;

            Reverse(arr, 0, k - 1);
            Reverse(arr, k, n - 1);
            Reverse(arr, 0, n - 1);
        }

        private void RightRotate(int[] arr, int k)
        {
            int n = arr.Length;
            k %= n;

            Reverse(arr, 0, n - 1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, n - 1);
        }

        private void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }
    }
}
