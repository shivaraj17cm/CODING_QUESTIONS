namespace CODING_QUESTIONS.Problems
{
    public class IsAnagramTugofWarASCII : IProblem
    {
        public int Id => 16;
        public string Name => "Check if two strings are anagrams using ASCII Tug of War";

        public void Run()
        {
            Test("deva", "veda");
            Test("listen", "silent");
            Test("hello", "world");
            Test("abc", "ab");
        }

        private void Test(string s1, string s2)
        {
            bool result = IsAnagram(s1, s2);
            Console.WriteLine($"\"{s1}\" & \"{s2}\" -> {(result ? "Anagram" : "Not Anagram")}");
        }

        private bool IsAnagram(string s1, string s2)
        {
            // 1. Length check
            if (s1.Length != s2.Length) return false;

            // 2. ASCII 256 frequency array
            int[] charCounts = new int[256];

            // 3. Increment for s1, Decrement for s2 (Tug of War)
            for (int i = 0; i < s1.Length; i++)
            {
                charCounts[s1[i]]++;
                charCounts[s2[i]]--;
            }

            // 4. If all counts are 0, strings are anagrams
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] != 0) return false;
            }

            return true;
        }
    }
}
