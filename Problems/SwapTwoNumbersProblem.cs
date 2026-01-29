namespace CODING_QUESTIONS.Problems
{
    public class SwapTwoNumbersProblem : IProblem
    {
        public int Id => 9;
        public string Name => "Swap two numbers";

        public void Run()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            SwapUsingTemp(ref a, ref b);
            Console.WriteLine($"After Swap (using temp): a = {a}, b = {b}");

            // Swap back without temp to demonstrate both
            SwapWithoutTemp(ref a, ref b);
            Console.WriteLine($"After Swap (without temp): a = {a}, b = {b}");
        }

        private void SwapUsingTemp(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private void SwapWithoutTemp(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }
    }
}
