namespace Tetil_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flight numune = new Flight("Heyder Eliyev airport", "2 gun sonra", "Dubai", 550);
            Hotel numune1 = new Hotel("Fairmont hotel", 5, "Paris", 600);
            numune.ShowInfo();
            numune1.ShowInfo();
        }
    }
}
