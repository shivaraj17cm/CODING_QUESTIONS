namespace CODING_QUESTIONS.Problems
{
    public class LongestSubstringWithoutRepeatingProblem : IProblem
    {
        public int Id => 12;
        public string Name => "Find the longest substring without repeating characters";

        public void Run()
        {
            string input = "pwwkew";

            Console.WriteLine($"Input : {input}");

            var result = LongestSubstring(input);

            Console.WriteLine($"Output: \"{result.Substring}\"");
            Console.WriteLine($"Length: {result.Length}");
        }

        private (string Substring, int Length) LongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return (string.Empty, 0);

            var set = new HashSet<char>();
            int left = 0, maxLength = 0, startIndex = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);

                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                    startIndex = left;
                }
            }

            return (s.Substring(startIndex, maxLength), maxLength);
        }
    }
}
