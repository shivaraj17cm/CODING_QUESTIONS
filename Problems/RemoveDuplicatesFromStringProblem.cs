using System.Text;

namespace CODING_QUESTIONS.Problems
{
    public class RemoveDuplicatesFromStringProblem : IProblem
    {
        public int Id => 7;
        public string Name => "Remove duplicate characters from a string";

        public void Run()
        {
            string input = "programming";

            Console.WriteLine($"Input : {input}");

            string result = RemoveDuplicates(input);

            Console.WriteLine($"Output: {result}");
        }

        private string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var seen = new HashSet<char>();
            var result = new StringBuilder();

            foreach (char ch in input)
            {
                if (seen.Add(ch))   // Add returns false if already exists
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
