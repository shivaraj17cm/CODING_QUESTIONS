namespace CODING_QUESTIONS.Problems
{
    public interface IProblem
    {
        int Id { get; }
        string Name { get; }
        void Run();
    }
}
