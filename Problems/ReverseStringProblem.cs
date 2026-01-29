namespace CODING_QUESTIONS.Problems
{
    public class ReverseStringProblem : IProblem
    {
        public int Id => 8;
        public string Name => "Reverse a string";

        public void Run()
        {
            string input = "Deloitte";

            Console.WriteLine($"Input : {input}");

            string result = ReverseString(input);

            Console.WriteLine($"Output: {result}");
        }

        private string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();

            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
