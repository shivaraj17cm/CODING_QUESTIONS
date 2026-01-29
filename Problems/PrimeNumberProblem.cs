namespace CODING_QUESTIONS.Problems
{
    public class PrimeNumberProblem : IProblem
    {
        public int Id => 14;
        public string Name => "Check if a number is prime";

        public void Run()
        {
            int number = 29;

            Console.WriteLine($"Input : {number}");

            bool isPrime = IsPrime(number);

            Console.WriteLine($"Output: {(isPrime ? "Prime" : "Not Prime")}");
        }

        private bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
