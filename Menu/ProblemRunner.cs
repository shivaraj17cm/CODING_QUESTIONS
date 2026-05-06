using CODING_QUESTIONS.Problems;

namespace CODING_QUESTIONS.Menu
{
    public class ProblemRunner
    {
        private readonly List<IProblem> _problems;

        public ProblemRunner()
        {
            _problems = new List<IProblem>
            {
                new TwoSumProblem(),
                new ReverseWordsProblem(),
                new ReverseArrayProblem(),
                new CharacterOccurrenceProblem(),
                new MoveZerosProblem(),
                new FirstNonRepeatingCharacterProblem(),
                new RemoveDuplicatesFromStringProblem(),
                new ReverseStringProblem(),
                new SwapTwoNumbersProblem(),
                new ExtractSurnameProblem(),
                new PalindromeStringProblem(),
                new LongestSubstringWithoutRepeatingProblem(),
                new ArrayRotationProblem(),
                new PrimeNumberProblem(),
                new IsAnagramTugofWarASCII()
            };
        }

        public void ShowMenu()
        {
            Console.WriteLine("==== Deloitte Coding Prep ====");

            foreach (var problem in _problems)
            {
                Console.WriteLine($"{problem.Id}. {problem.Name}");
            }

            Console.WriteLine("0. Exit");
        }

        public void Run()
        {
            while (true)
            {
                ShowMenu();
                Console.Write("\nSelect a problem: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (choice == 0)
                    break;

                var selected = _problems.FirstOrDefault(p => p.Id == choice);

                if (selected == null)
                {
                    Console.WriteLine("Invalid selection.");
                    continue;
                }

                Console.WriteLine("\n--- Running Problem ---\n");
                selected.Run();
                Console.WriteLine("\n-----------------------\n");
            }
        }
    }
}
