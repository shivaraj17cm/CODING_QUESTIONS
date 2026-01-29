namespace CODING_QUESTIONS.Problems
{
    public class ReverseWordsProblem : IProblem
    {
        public int Id => 2;
        public string Name => "Reverse each word in a string";

        public void Run()
        {
            string input = "Hello World from Deloitte";

            string result = ReverseWords(input);

            Console.WriteLine($"Input : {input}");
            Console.WriteLine($"Output: {result}");
        }

        private string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Reverse(words[i]);
            }

            return string.Join(" ", words);
        }

        private string Reverse(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
