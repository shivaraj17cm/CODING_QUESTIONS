namespace CODING_QUESTIONS.Problems
{
    public class FirstNonRepeatingCharacterProblem : IProblem
    {
        public int Id => 6;
        public string Name => "Find the first non-repeating character in a string";

        public void Run()
        {
            string input = "aabbcdeff";

            Console.WriteLine($"Input : {input}");

            char? result = FirstNonRepeatingCharacter(input);

            if (result.HasValue)
                Console.WriteLine($"Output: {result.Value}");
            else
                Console.WriteLine("Output: No non-repeating character found");
        }

        private char? FirstNonRepeatingCharacter(string input)
        {
            var frequencyMap = new Dictionary<char, int>();

            // First pass: count occurrences
            foreach (char ch in input)
            {
                if (ch == ' ')
                    continue;

                if (frequencyMap.ContainsKey(ch))
                    frequencyMap[ch]++;
                else
                    frequencyMap[ch] = 1;
            }

            // Second pass: find first character with count = 1
            foreach (char ch in input)
            {
                if (ch != ' ' && frequencyMap[ch] == 1)
                    return ch;
            }

            return null;
        }
    }
}
