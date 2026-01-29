namespace CODING_QUESTIONS.Problems
{
    public class PalindromeStringProblem : IProblem
    {
        public int Id => 11;
        public string Name => "Check if a string is a palindrome";

        public void Run()
        {
            string input = "A man a plan a canal Panama";

            Console.WriteLine($"Input : \"{input}\"");

            bool isPalindrome = IsPalindrome(input);

            Console.WriteLine($"Output: {(isPalindrome ? "Palindrome" : "Not a Palindrome")}");
        }

        private bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return true;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                // Skip spaces
                if (input[left] == ' ')
                {
                    left++;
                    continue;
                }

                if (input[right] == ' ')
                {
                    right--;
                    continue;
                }

                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
