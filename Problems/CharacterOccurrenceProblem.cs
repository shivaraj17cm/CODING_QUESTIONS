namespace CODING_QUESTIONS.Problems
{
    public class CharacterOccurrenceProblem : IProblem
    {
        public int Id => 4;
        public string Name => "Find occurrence of each character in a string";

        public void Run()
        {
            string input = "aabbc dde";

            Console.WriteLine($"Input : {input}");
            Console.WriteLine("Output:");

            var result = CountCharacters(input);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private Dictionary<char, int> CountCharacters(string input)
        {
            var frequencyMap = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (ch == ' ')
                    continue;

                if (frequencyMap.ContainsKey(ch))
                    frequencyMap[ch]++;
                else
                    frequencyMap[ch] = 1;
            }

            return frequencyMap;
        }
    }
}
