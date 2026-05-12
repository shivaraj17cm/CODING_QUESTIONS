namespace CODING_QUESTIONS.Problems
{
    public class ValidParenthesesProblem : IProblem
    {
        public int Id => 18;
        public string Name => "Valid Parentheses (Stack)";

        public void Run()
        {
            Test("()");
            Test("()[]{}");
            Test("(]");
            Test("([)]");
            Test("{[]}");
            Test("");
            Test("((()))");
        }

        private void Test(string s)
        {
            bool result = IsValid(s);
            Console.WriteLine($"\"{s}\" -> {(result ? "Valid" : "Invalid")}");
        }

        private bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var stack = new Stack<char>();

            foreach (char c in s)
            {
                // Push opening brackets
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    // If stack is empty, no matching opening bracket
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    // Check for matching pair
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            // If stack is empty, all brackets matched
            return stack.Count == 0;
        }
    }
}
