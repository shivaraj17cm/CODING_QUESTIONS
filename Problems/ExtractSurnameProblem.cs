namespace CODING_QUESTIONS.Problems
{
    public class ExtractSurnameProblem : IProblem
    {
        public int Id => 10;
        public string Name => "Extract the surname from a full name";

        public void Run()
        {
            string fullName = "John Michael Doe";

            Console.WriteLine($"Input : \"{fullName}\"");

            string surname = ExtractSurname(fullName);

            Console.WriteLine($"Output: \"{surname}\"");
        }

        private string ExtractSurname(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return string.Empty;

            var parts = fullName
                .Trim()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return parts.Length > 0 ? parts[^1] : string.Empty;
        }
    }
}
